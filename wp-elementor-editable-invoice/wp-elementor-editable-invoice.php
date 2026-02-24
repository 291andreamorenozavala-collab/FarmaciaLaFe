<?php
/**
 * Plugin Name: Elementor Editable Invoice
 * Description: Widget de Elementor para crear facturas editables con vista previa en tiempo real, animaciones y enfoque en rendimiento.
 * Version: 1.0.0
 * Author: Codex
 * Text Domain: elementor-editable-invoice
 */

if (!defined('ABSPATH')) {
    exit;
}

final class Elementor_Editable_Invoice_Plugin {
    const VERSION = '1.0.0';

    public function __construct() {
        add_action('plugins_loaded', [$this, 'init']);
    }

    public function init() {
        if (!did_action('elementor/loaded')) {
            add_action('admin_notices', [$this, 'admin_notice_missing_elementor']);
            return;
        }

        add_action('elementor/widgets/register', [$this, 'register_widgets']);
        add_action('elementor/frontend/after_register_scripts', [$this, 'register_assets']);
        add_action('elementor/frontend/after_register_styles', [$this, 'register_assets']);
    }

    public function register_widgets($widgets_manager) {
        require_once __DIR__ . '/includes/class-elementor-editable-invoice-widget.php';
        $widgets_manager->register(new \Elementor_Editable_Invoice_Widget());
    }

    public function register_assets() {
        wp_register_style(
            'elementor-editable-invoice',
            plugins_url('assets/css/invoice-widget.css', __FILE__),
            [],
            self::VERSION
        );

        wp_register_script(
            'elementor-editable-invoice',
            plugins_url('assets/js/invoice-widget.js', __FILE__),
            [],
            self::VERSION,
            true
        );
    }

    public function admin_notice_missing_elementor() {
        if (!current_user_can('activate_plugins')) {
            return;
        }

        $message = esc_html__('Elementor Editable Invoice requiere Elementor activo.', 'elementor-editable-invoice');
        printf('<div class="notice notice-warning is-dismissible"><p>%s</p></div>', $message);
    }
}

new Elementor_Editable_Invoice_Plugin();
