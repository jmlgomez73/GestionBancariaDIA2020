﻿using System.Security.Permissions;

namespace DIA_P2_banco.Cuentas
{
    public class CuentaCorriente : Cuenta
    {
        public CuentaCorriente(string ccc, Cliente cliente) : 
            base(ccc, cliente)
        {
            base.Tipo = "Corriente";
            base.InteresMensual = 0.0d;
        }

        public void AddDeposito(Deposito deposito)
        {
            base.Saldo += deposito.Cantidad;
            this.Depositos.Add(deposito);
        }
        
        public bool DeleteDeposito(Deposito deposito)
        {
            base.Saldo -= deposito.Cantidad;
            if (this.Depositos.Remove(deposito)) return true;
            else return false;
        }

        public void AddRetirada(Retirada retirada)
        {
            base.Saldo -= retirada.Cantidad;
            this.Retiradas.Add(retirada);
        }

        public bool DeleteRetirada(Retirada retirada)
        {
            base.Saldo += retirada.Cantidad;
            if (this.Retiradas.Remove(retirada)) return true;
            else return false;
        }
    }
}