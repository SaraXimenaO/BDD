using Be.Corebvba.Aubergine;

namespace BDD_ProyectoFinal {
  public class BDD_Cuenta {

    private ClasesDeDominio.Cuenta cuenta = new ClasesDeDominio.Cuenta();
    private ClasesDeDominio.CajeroAutomatico cajeroAutomatico = new ClasesDeDominio.CajeroAutomatico();
    private ClasesDeDominio.Tarjeta tarjeta = new ClasesDeDominio.Tarjeta();
    private decimal CantidadEntregada;

    public BDD_Cuenta() {
      cajeroAutomatico.tarjeta = tarjeta;
    }

    [DSL(@"el_saldo_de_la_cuenta_es_(?<MontoInicial>.+)")]
    private void SaldoInicialCuentaEsX(decimal MontoInicial) {
      cuenta.Saldo = MontoInicial;
    }

    [DSL(@"la_tarjeta_es_(?<estado>.+)")]
    private void EstadotarjetaEsX(ClasesDeDominio.Estadotarjeta estado) {
      tarjeta.estadoTarjeta = estado;
    }


    [DSL(@"el_cajeroautomatico_contiene_(?<MontoInicial>.+)")]
    private void SaldoCajeroEs(decimal MontoInicial) {
      cajeroAutomatico.AvailableCash = MontoInicial;
    }

    [DSL(@"el_titular_de_la_cuenta_solicita_(?<cantidad>.+)")]
    private void SolicitarX(decimal cantidad) {
      CantidadEntregada = cajeroAutomatico.ProcesarSolicitud(cuenta, cantidad);
    }

    [DSL]
    private decimal suficiente_dinero() {
      return 1m;
    }

    [DSL(@"el_cajero_automatico_debe_entregar_(?<cantidad>.+)")]
    private bool MontoEntregadoDebeSerIgualX(decimal cantidad) {
      return CantidadEntregada == cantidad;
    }

    [DSL(@"el_saldo_de_la_cuenta_debe_ser_(?<cantidad>.+)")]
    private bool SaldoCuentaDebeSerIgualA(decimal cantidad) {
      return cuenta.Saldo == cantidad;
    }

    [DSL]
    private bool el_cajero_automatico_no_debe_entregar_ningun_dinero() {
      return CantidadEntregada == 0;
    }

    [DSL]
    private bool entregar_tarjeta() {
      return cajeroAutomatico.tarjeta == null;
    }

    [DSL]
    private bool el_cajero_automático_debe_retener_la_tarjeta() {
      return cajeroAutomatico.Retenertarjeta.Contains(tarjeta);
    }

    [DSL(@"el_cajero_automatico_debe_decir_que_(?<mensaje>.+)")]
    private bool atmmsg(string mensaje) {
      return (cajeroAutomatico.Mensaje ?? "").Replace(" ", "_").ToLower().Contains(mensaje);
    }
  }
}
