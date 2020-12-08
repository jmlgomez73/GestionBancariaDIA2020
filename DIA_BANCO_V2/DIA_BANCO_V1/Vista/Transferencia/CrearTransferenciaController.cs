
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace DIA_BANCO_V1
{
    using WForms = System.Windows.Forms;
    
    public class CrearTransferenciaController
    {
        public List<Transferencia> transferencias;
        public List<Cuenta> cuentas;
        
        public CrearTransferenciaController(List<Transferencia> trans, List<Cuenta> cuentas)
        {
            this.transferencias = trans;
            this.cuentas = cuentas; 
            
            this.View = new CrearTransferencia();

            string tipo = this.View.etp.Text;
            
            this.View.etp.SelectedIndexChanged += (sender, args) =>
            {
                tipo = this.View.etp.SelectedItem.ToString();
            };
            
            this.View.BCrearTransferencia.Click += (sender, args) => this.BCrearTransferencia(tipo);
        }
        
        /// <summary>
        /// Segun los parametros pasados, se crea una trasnferencia y se guarda (si no existe previamente ninguna transfernecia asociada al id pasado)
        /// </summary>
        /// <param name="tipo"></param>
        public void BCrearTransferencia(string tipo)
        {
            bool esta = false;
            bool fecha = false;

            bool ccc1 = false;
            
            int id;
            int.TryParse(this.View.eid.Text, out id);
            double importe;
            double.TryParse(this.View.eimporte.Text, out importe);
            DateTime data;

            if(DateTime.TryParse(this.View.efecha.Text, out data))
            {
                fecha = true;
            }
            else
            {
                fecha = false;
            }
            
            if (Regex.IsMatch(this.View.ecccdest.Text, "^[0-9]{20}$") &&  Banco.existeCCC(this.View.ecccdest.Text,this.cuentas))
            {
                ccc1 = true;
            }
            else
            {
                ccc1 = false;
            }

            Cuenta cuentaOrigen = Banco.getCuenta(this.View.ecccorigen.Text, this.cuentas);
            Cuenta cuentaDestino =  Banco.getCuenta(this.View.ecccdest.Text, this.cuentas);
            

            Transferencia t = new Transferencia( id, tipo, this.View.ecccorigen.Text,
                this.View.ecccdest.Text, importe, data);
            
            
            
            foreach (Transferencia transferencia in transferencias)
            {
                if (transferencia.Id == t.Id)
                {
                    esta = true;
                }
            }

            if (!esta && fecha && ccc1)
            {
                if (Banco.transferencia_sum_rest(cuentaOrigen, cuentaDestino, importe))
                {
                    this.transferencias.Add(t);
                    WForms.MessageBox.Show("Transferencia creada correctamente");
                }
                else
                {
                    WForms.MessageBox.Show("No hay saldo sufienciente para hacer la transferencia");
                    WForms.MessageBox.Show("Se cancelo la transferencia");
                }

                this.View.Hide();
                this.View.Close();
            }
            else 
            {
                if (!fecha)
                {
                    WForms.MessageBox.Show("Error: Fecha erronea");
                }

                if(!ccc1)
                {
                    WForms.MessageBox.Show("Error: CCC Destino incorrecto o no existe");
                }
                
                if(esta)
                {
                    WForms.MessageBox.Show("Error: Ya existe esta transferencia");
                }

            }
            

        }

        
        public CrearTransferencia View {
            get;
        }
    }
}