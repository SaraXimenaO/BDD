using Be.Corebvba.Aubergine;

namespace BDD_ProyectoFinal {
  public class Titular_Cuenta_retira_efectivo : Story<BDD_Cuenta> {

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

    private class La_Tarjeta_Ha_Sido_deshabilitada : Scenario {
      private Given la_tarjeta_es_Invalida;

      private When the_Account_Holder_requests_20;

      private Then el_cajero_automatico_debe_retener_la_tarjeta;

      private Then the_ATM_should_say_the_card_has_been_retained;
    }

  }
}
