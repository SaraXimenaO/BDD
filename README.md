# Ejercicio BDD

# Autores: 
- Sara Ximena Ortiz Reyes
- Endi Romero
         
# Herramientas

- Aplicación .Net 3.5
- Visual Studio
- Be.Corebvba.Aubergine.dll 1.0.0.0
- Gherkin


# Introducción
Simulador de cajero automático

# Instalación 

1. instalar SDK Net 3.5
2. Descargar o clonar el proyecto del respositorio
3. Ejecutar proyecto


# Historias de usuario

private As_an Titular_Cuenta;
private I_want retirar_efectivo_de_un_cajero_automatico;
private So_that Poder_obtener_dinero_cuando_el_banco_este_cerrado;



private class La_Cuenta_tiene_fondos_suficientes_Para_Retiros : Scenario {
private Given el_saldo_de_la_cuenta_es_100;
private Given la_tarjeta_es_Valida;
private Given el_cajeroautomatico_contiene_suficiente_dinero;



private When el_titular_de_la_cuenta_solicita_20;



private Then el_cajero_automatico_debe_entregar_20;
private Then el_saldo_de_la_cuenta_debe_ser_80;
private Then entregar_tarjeta;
}



private class Fondos_insuficientes_En_La_Cuenta : Scenario {
private Given el_saldo_de_la_cuenta_es_10;
private Given la_tarjeta_es_Valida;
private Given el_cajeroautomatico_contiene_suficiente_dinero;



private When el_titular_de_la_cuenta_solicita_20;



private Then el_cajero_automatico_no_debe_entregar_ningun_dinero;
private Then el_cajero_automatico_debe_decir_que_hay_fondos_insuficientes;



private Then el_saldo_de_la_cuenta_debe_ser_10;
private Then entregar_tarjeta;
}


# Conclusiones

1. Aprendimos a crear y configurar las BDD para un proyecto hecho en .net
2. Nos quedó mas claro el funcionamiento de las BDD y su utilización
