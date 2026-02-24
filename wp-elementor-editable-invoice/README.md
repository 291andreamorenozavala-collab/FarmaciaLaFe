# Elementor Editable Invoice

Plugin para WordPress que añade un widget de Elementor para crear facturas editables con preview en tiempo real.

## Características
- Edición inline de datos de cliente, fechas, items y notas.
- Cálculo automático de subtotal, impuesto y total.
- Preview sincronizado en tiempo real.
- Animaciones suaves para agregar/eliminar filas.
- Optimización base: JS vanilla, debounce en inputs y CSS con `contain`.

## Instalación
1. Copiar la carpeta `wp-elementor-editable-invoice` dentro de `/wp-content/plugins/`.
2. Activar el plugin en el panel de WordPress.
3. En Elementor, buscar el widget **Editable Invoice** dentro de la categoría General.

## Recomendaciones de performance
- Activar caché de página y minificación en producción.
- Usar fuentes del sistema o precargadas para reducir CLS.
- Mantener pocas filas visibles en móvil para mejorar interacción.
