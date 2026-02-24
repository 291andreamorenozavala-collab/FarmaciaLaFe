<?php

if (!defined('ABSPATH')) {
    exit;
}

class Elementor_Editable_Invoice_Widget extends \Elementor\Widget_Base {
    public function get_name() {
        return 'editable_invoice';
    }

    public function get_title() {
        return esc_html__('Editable Invoice', 'elementor-editable-invoice');
    }

    public function get_icon() {
        return 'eicon-form-horizontal';
    }

    public function get_categories() {
        return ['general'];
    }

    public function get_style_depends() {
        return ['elementor-editable-invoice'];
    }

    public function get_script_depends() {
        return ['elementor-editable-invoice'];
    }

    protected function register_controls() {
        $this->start_controls_section(
            'section_invoice',
            [
                'label' => esc_html__('Configuración de factura', 'elementor-editable-invoice'),
            ]
        );

        $this->add_control(
            'invoice_title',
            [
                'label' => esc_html__('Título', 'elementor-editable-invoice'),
                'type' => \Elementor\Controls_Manager::TEXT,
                'default' => esc_html__('Create Invoice', 'elementor-editable-invoice'),
            ]
        );

        $this->add_control(
            'invoice_number',
            [
                'label' => esc_html__('Número', 'elementor-editable-invoice'),
                'type' => \Elementor\Controls_Manager::TEXT,
                'default' => 'INV-006489162154',
            ]
        );

        $this->add_control(
            'issued_date',
            [
                'label' => esc_html__('Fecha de emisión', 'elementor-editable-invoice'),
                'type' => \Elementor\Controls_Manager::TEXT,
                'default' => '11 May 2025',
            ]
        );

        $this->add_control(
            'due_date',
            [
                'label' => esc_html__('Fecha límite', 'elementor-editable-invoice'),
                'type' => \Elementor\Controls_Manager::TEXT,
                'default' => '15 May 2025',
            ]
        );

        $this->add_control(
            'tax_rate',
            [
                'label' => esc_html__('Impuesto (%)', 'elementor-editable-invoice'),
                'type' => \Elementor\Controls_Manager::NUMBER,
                'min' => 0,
                'max' => 100,
                'step' => 0.1,
                'default' => 5,
            ]
        );

        $this->add_control(
            'accent_color',
            [
                'label' => esc_html__('Color de acento', 'elementor-editable-invoice'),
                'type' => \Elementor\Controls_Manager::COLOR,
                'default' => '#ff5a30',
            ]
        );

        $this->end_controls_section();
    }

    protected function render() {
        $settings = $this->get_settings_for_display();
        $invoice_id = 'invoice-' . wp_rand(1000, 9999);
        ?>
        <section class="efi-invoice" id="<?php echo esc_attr($invoice_id); ?>" style="--efi-accent: <?php echo esc_attr($settings['accent_color']); ?>;">
            <header class="efi-head">
                <div>
                    <h3 class="efi-title"><?php echo esc_html($settings['invoice_title']); ?></h3>
                    <p class="efi-subtitle"><?php esc_html_e('Genera y gestiona facturas de forma rápida.', 'elementor-editable-invoice'); ?></p>
                </div>
                <button type="button" class="efi-button" data-action="download"><?php esc_html_e('Descargar', 'elementor-editable-invoice'); ?></button>
            </header>

            <div class="efi-grid">
                <div class="efi-panel">
                    <label><?php esc_html_e('Cliente', 'elementor-editable-invoice'); ?></label>
                    <input data-bind="clientName" type="text" value="Sid Vicious" />

                    <label><?php esc_html_e('Correo del cliente', 'elementor-editable-invoice'); ?></label>
                    <input data-bind="clientEmail" type="email" value="vicious@gmail.com" />

                    <div class="efi-row">
                        <div>
                            <label><?php esc_html_e('Factura #', 'elementor-editable-invoice'); ?></label>
                            <input data-bind="invoiceNumber" type="text" value="<?php echo esc_attr($settings['invoice_number']); ?>" />
                        </div>
                        <div>
                            <label><?php esc_html_e('Moneda', 'elementor-editable-invoice'); ?></label>
                            <select data-bind="currency">
                                <option value="USD">USD</option>
                                <option value="EUR">EUR</option>
                                <option value="DOP">DOP</option>
                            </select>
                        </div>
                    </div>

                    <div class="efi-row">
                        <div>
                            <label><?php esc_html_e('Fecha emisión', 'elementor-editable-invoice'); ?></label>
                            <input data-bind="issuedDate" type="text" value="<?php echo esc_attr($settings['issued_date']); ?>" />
                        </div>
                        <div>
                            <label><?php esc_html_e('Fecha límite', 'elementor-editable-invoice'); ?></label>
                            <input data-bind="dueDate" type="text" value="<?php echo esc_attr($settings['due_date']); ?>" />
                        </div>
                    </div>

                    <label><?php esc_html_e('Detalle de proyecto', 'elementor-editable-invoice'); ?></label>
                    <input data-bind="project" type="text" value="UI/IX Design" />

                    <div class="efi-table" data-items>
                        <div class="efi-table-head">
                            <span><?php esc_html_e('Item', 'elementor-editable-invoice'); ?></span>
                            <span><?php esc_html_e('Cant.', 'elementor-editable-invoice'); ?></span>
                            <span><?php esc_html_e('Costo', 'elementor-editable-invoice'); ?></span>
                            <span><?php esc_html_e('Importe', 'elementor-editable-invoice'); ?></span>
                            <span></span>
                        </div>
                    </div>

                    <button type="button" class="efi-link" data-action="add-item">+ <?php esc_html_e('Agregar item', 'elementor-editable-invoice'); ?></button>

                    <label><?php esc_html_e('Notas / Términos', 'elementor-editable-invoice'); ?></label>
                    <textarea data-bind="notes" rows="3">Thank you for your business. Contact us for any questions.</textarea>

                    <input type="hidden" data-tax-rate value="<?php echo esc_attr($settings['tax_rate']); ?>" />
                </div>

                <aside class="efi-preview">
                    <h4><?php esc_html_e('Invoice Preview', 'elementor-editable-invoice'); ?></h4>
                    <p><strong><?php esc_html_e('Invoice:', 'elementor-editable-invoice'); ?></strong> <span data-preview="invoiceNumber"></span></p>
                    <p><strong><?php esc_html_e('Cliente:', 'elementor-editable-invoice'); ?></strong> <span data-preview="clientName"></span></p>
                    <p><strong><?php esc_html_e('Email:', 'elementor-editable-invoice'); ?></strong> <span data-preview="clientEmail"></span></p>
                    <p><strong><?php esc_html_e('Proyecto:', 'elementor-editable-invoice'); ?></strong> <span data-preview="project"></span></p>
                    <p><strong><?php esc_html_e('Emisión:', 'elementor-editable-invoice'); ?></strong> <span data-preview="issuedDate"></span></p>
                    <p><strong><?php esc_html_e('Vence:', 'elementor-editable-invoice'); ?></strong> <span data-preview="dueDate"></span></p>
                    <div data-preview-items class="efi-preview-items"></div>

                    <div class="efi-totals">
                        <div><span><?php esc_html_e('Subtotal', 'elementor-editable-invoice'); ?></span><strong data-total="subtotal">$0.00</strong></div>
                        <div><span><?php esc_html_e('Impuesto', 'elementor-editable-invoice'); ?> (<span data-total="taxRate"></span>%)</span><strong data-total="tax">$0.00</strong></div>
                        <div><span><?php esc_html_e('Total', 'elementor-editable-invoice'); ?></span><strong data-total="grand">$0.00</strong></div>
                    </div>

                    <p class="efi-notes" data-preview="notes"></p>
                </aside>
            </div>

            <template data-item-template>
                <div class="efi-item-row">
                    <input type="text" data-field="name" placeholder="Website Design" value="Website Design" />
                    <input type="number" data-field="qty" min="1" step="1" value="1" />
                    <input type="number" data-field="price" min="0" step="0.01" value="120" />
                    <output data-field="amount">$120.00</output>
                    <button type="button" class="efi-delete" aria-label="Delete item">×</button>
                </div>
            </template>
        </section>
        <?php
    }
}
