using System;
using System.Collections.Generic;

namespace BDD_ProyectoFinal {

  public class ClasesDeDominio {

    public class Cuenta {
      public Decimal Saldo { get; set; }

      public decimal RetirarDinero(decimal monto) {
        if (monto > Saldo)
          return 0;
        else {
          Saldo -= monto;
          return monto;
        }
      }
    }

    public class Tarjeta {
      public Estadotarjeta estadoTarjeta { get; set; }
    }

    public class CajeroAutomatico {
      public Tarjeta tarjeta { get; set; }
      public decimal AvailableCash { get; set; }
      public IList<Tarjeta> Retenertarjeta { get; private set; }
      public string Mensaje { get; private set; }

      public CajeroAutomatico() {
        Retenertarjeta = new List<Tarjeta>();
      }

      public Decimal ProcesarSolicitud(Cuenta cuenta, decimal monto) {
        decimal efectivo = cuenta.RetirarDinero(monto);

        if (efectivo == 0) {
          Mensaje = "Hay fondos insuficientes disponibles en su cuenta";
        } else {
          Mensaje = "Por favor toma su efectivo";
        }

        tarjeta = null;
        return efectivo;
      }
    }

    public enum Estadotarjeta {
      Valida,
      Invalida
    }
  }
}
