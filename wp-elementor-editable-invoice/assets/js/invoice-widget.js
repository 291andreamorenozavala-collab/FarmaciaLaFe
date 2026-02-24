(function () {
  'use strict';

  function debounce(callback, delay) {
    let timer;
    return function debounced() {
      const context = this;
      const args = arguments;
      clearTimeout(timer);
      timer = setTimeout(function () {
        callback.apply(context, args);
      }, delay);
    };
  }

  function formatCurrency(value, currencyCode) {
    return new Intl.NumberFormat(undefined, {
      style: 'currency',
      currency: currencyCode || 'USD'
    }).format(value || 0);
  }

  function createItemRow(template) {
    const clone = template.content.firstElementChild.cloneNode(true);
    clone.classList.add('is-entering');
    requestAnimationFrame(function () {
      clone.classList.remove('is-entering');
    });
    return clone;
  }

  function initInvoice(scope) {
    const itemsWrapper = scope.querySelector('[data-items]');
    const template = scope.querySelector('[data-item-template]');
    const previewItems = scope.querySelector('[data-preview-items]');
    const addItemButton = scope.querySelector('[data-action="add-item"]');
    const downloadButton = scope.querySelector('[data-action="download"]');
    const taxRateInput = scope.querySelector('[data-tax-rate]');

    if (!itemsWrapper || !template) {
      return;
    }

    function syncPreview() {
      scope.querySelectorAll('[data-bind]').forEach(function (field) {
        const key = field.getAttribute('data-bind');
        const target = scope.querySelector('[data-preview="' + key + '"]');
        if (target) {
          target.textContent = field.value || '';
        }
      });
    }

    function recalcTotals() {
      const currency = scope.querySelector('[data-bind="currency"]').value;
      let subtotal = 0;

      previewItems.innerHTML = '';

      itemsWrapper.querySelectorAll('.efi-item-row').forEach(function (row) {
        const name = row.querySelector('[data-field="name"]').value || 'Item';
        const qty = Number(row.querySelector('[data-field="qty"]').value || 0);
        const price = Number(row.querySelector('[data-field="price"]').value || 0);
        const amount = qty * price;

        row.querySelector('[data-field="amount"]').textContent = formatCurrency(amount, currency);
        subtotal += amount;

        const line = document.createElement('div');
        line.className = 'efi-preview-line';
        line.innerHTML = '<span>' + name + ' × ' + qty + '</span><strong>' + formatCurrency(amount, currency) + '</strong>';
        previewItems.appendChild(line);
      });

      const taxRate = Number(taxRateInput.value || 0);
      const tax = subtotal * (taxRate / 100);
      const grand = subtotal + tax;

      scope.querySelector('[data-total="subtotal"]').textContent = formatCurrency(subtotal, currency);
      scope.querySelector('[data-total="tax"]').textContent = formatCurrency(tax, currency);
      scope.querySelector('[data-total="grand"]').textContent = formatCurrency(grand, currency);
      scope.querySelector('[data-total="taxRate"]').textContent = taxRate.toFixed(1);
    }

    function bindRow(row) {
      row.addEventListener('input', debounce(function () {
        recalcTotals();
      }, 100));

      row.querySelector('.efi-delete').addEventListener('click', function () {
        row.classList.add('is-leaving');
        setTimeout(function () {
          row.remove();
          recalcTotals();
        }, 180);
      });
    }

    function addRow() {
      const row = createItemRow(template);
      itemsWrapper.appendChild(row);
      bindRow(row);
      recalcTotals();
    }

    addItemButton.addEventListener('click', addRow, { passive: true });

    scope.querySelectorAll('[data-bind], [data-tax-rate]').forEach(function (input) {
      input.addEventListener('input', debounce(function () {
        syncPreview();
        recalcTotals();
      }, 80));
      input.addEventListener('change', function () {
        syncPreview();
        recalcTotals();
      });
    });

    downloadButton.addEventListener('click', function () {
      window.print();
    });

    addRow();
    addRow();
    syncPreview();
    recalcTotals();
  }

  function initAll(root) {
    root.querySelectorAll('.efi-invoice').forEach(function (invoice) {
      if (invoice.dataset.ready === '1') {
        return;
      }
      invoice.dataset.ready = '1';
      initInvoice(invoice);
    });
  }

  if (window.elementorFrontend && window.elementorFrontend.hooks) {
    window.elementorFrontend.hooks.addAction('frontend/element_ready/editable_invoice.default', function ($scope) {
      initAll($scope[0]);
    });
  }

  document.addEventListener('DOMContentLoaded', function () {
    initAll(document);
  }, { passive: true });
})();
