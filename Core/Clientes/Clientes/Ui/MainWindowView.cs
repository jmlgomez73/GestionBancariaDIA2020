﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clientes.Ui
{

    using Draw = System.Drawing;
    using WForms = System.Windows.Forms;
    class MainWindowView : WForms.Form
    {

        public MainWindowView()
        {
            this.Build();
        }

        void Build()
        {
            var pnlMain = new WForms.TableLayoutPanel
            {
                Dock = WForms.DockStyle.Fill
            };


            pnlMain.Controls.Add(this.tDni());
            pnlMain.Controls.Add(this.BuildDni());
            pnlMain.Controls.Add(this.tNombre());
            pnlMain.Controls.Add(this.BuildNombre());
            pnlMain.Controls.Add(this.tTelefono());
            pnlMain.Controls.Add(this.BuildTelefono());
            pnlMain.Controls.Add(this.tEmail());
            pnlMain.Controls.Add(this.BuildEmail());
            pnlMain.Controls.Add(this.tDireccion());
            pnlMain.Controls.Add(this.BuildDireccion());

            pnlMain.Controls.Add(this.BuildBtAnhade());
            pnlMain.Controls.Add(this.BuildBtBuscar());
            pnlMain.Controls.Add(this.BuildBtEditar());
            pnlMain.Controls.Add(this.BuildBtEliminar());
            pnlMain.Controls.Add(this.BuildBtListar());


            this.Controls.Add(pnlMain);
            this.Text = "Gestión de Clientes";
            this.MinimumSize = new Draw.Size(300, 415);
        }


        //Creado para meter el texto del dni del cliente
        WForms.Label tDni()
        {
            titulodni = new WForms.Label
            {
                Dock = WForms.DockStyle.Top
            };

            titulodni.Text = "Introduce el dni del cliente a añadir";
            titulodni.MaximumSize = new Draw.Size(800, 20);

            return titulodni;

        }

        //Caja para introducir el dni
        WForms.Panel BuildDni()
        {
            var toret = new WForms.Panel
            {
                Dock = WForms.DockStyle.Top
            };

            this.dni = new WForms.TextBox
            {
                Dock = WForms.DockStyle.Fill,
                Text = "",
                TextAlign = WForms.HorizontalAlignment.Right
            };

            toret.Controls.Add(this.dni);
            toret.MaximumSize = new Draw.Size(800, 20);

            return toret;
        }

        //Creado para meter el texto del dni del nombre
        WForms.Label tNombre()
        {
            titulonombre = new WForms.Label
            {
                Dock = WForms.DockStyle.Top
            };

            titulonombre.Text = "Introduce el nombre del cliente";
            titulonombre.MaximumSize = new Draw.Size(800, 20);

            return titulonombre;

        }

        //Caja para introducir el nombre
        WForms.Panel BuildNombre()
        {
            var toret = new WForms.Panel
            {
                Dock = WForms.DockStyle.Top
            };

            this.nombre = new WForms.TextBox
            {
                Dock = WForms.DockStyle.Fill,
                Text = "",
                TextAlign = WForms.HorizontalAlignment.Right
            };

            toret.Controls.Add(this.nombre);
            toret.MaximumSize = new Draw.Size(800, 20);

            return toret;
        }

        //Creado para meter el texto del telefono del cliente
        WForms.Label tTelefono()
        {
            titulotelefono = new WForms.Label
            {
                Dock = WForms.DockStyle.Top
            };

            titulotelefono.Text = "Introduce el teléfono del cliente (formato sin espacios)";
            titulotelefono.MaximumSize = new Draw.Size(800, 20);

            return titulotelefono;

        }

        //Caja para introducir el telefono
        WForms.Panel BuildTelefono()
        {
            var toret = new WForms.Panel
            {
                Dock = WForms.DockStyle.Top
            };

            this.telefono = new WForms.TextBox
            {
                Dock = WForms.DockStyle.Fill,
                Text = "",
                TextAlign = WForms.HorizontalAlignment.Right
            };

            toret.Controls.Add(this.telefono);
            toret.MaximumSize = new Draw.Size(800, 20);

            return toret;
        }

        //Creado para meter el texto del email del cliente
        WForms.Label tEmail()
        {
            tituloemail = new WForms.Label
            {
                Dock = WForms.DockStyle.Top
            };

            tituloemail.Text = "Introduce el email del cliente";
            tituloemail.MaximumSize = new Draw.Size(800, 20);

            return tituloemail;

        }

        //Caja para introducir el email
        WForms.Panel BuildEmail()
        {
            var toret = new WForms.Panel
            {
                Dock = WForms.DockStyle.Top
            };

            this.email = new WForms.TextBox
            {
                Dock = WForms.DockStyle.Fill,
                Text = "",
                TextAlign = WForms.HorizontalAlignment.Right
            };

            toret.Controls.Add(this.email);
            toret.MaximumSize = new Draw.Size(800, 20);

            return toret;
        }

        //Creado para meter el texto de la dirección postal del cliente
        WForms.Label tDireccion()
        {
            titulodireccion = new WForms.Label
            {
                Dock = WForms.DockStyle.Top
            };

            titulodireccion.Text = "Introduce la dirección postal del cliente";
            titulodireccion.MaximumSize = new Draw.Size(800, 20);

            return titulodireccion;

        }

        //Caja para introducir la dirección postal
        WForms.Panel BuildDireccion()
        {
            var toret = new WForms.Panel
            {
                Dock = WForms.DockStyle.Top
            };

            this.direccion = new WForms.TextBox
            {
                Dock = WForms.DockStyle.Fill,
                Text = "",
                TextAlign = WForms.HorizontalAlignment.Right
            };

            toret.Controls.Add(this.direccion);
            toret.MaximumSize = new Draw.Size(800, 20);

            return toret;
        }


        //Boton para anhadir un nuevo cliente
        WForms.Button BuildBtAnhade()
        {
            this.BtAnhade = new WForms.Button
            {
                Dock = WForms.DockStyle.Bottom,
                Text = "Añadir cliente"
            };
            this.MaximumSize = new Draw.Size(2000, 20);

            return this.BtAnhade;
        }


        //Boton para listar los clientes
        WForms.Button BuildBtListar()
        {
            this.BtListar = new WForms.Button
            {
                Dock = WForms.DockStyle.Bottom,
                Text = "Listar clientes"
            };
            this.MaximumSize = new Draw.Size(2000, 20);

            return this.BtListar;
        }


        //Boton para buscar un cliente
        WForms.Button BuildBtBuscar()
        {
            this.BtBuscar = new WForms.Button
            {
                Dock = WForms.DockStyle.Bottom,
                Text = "Buscar cliente"
            };
            this.MaximumSize = new Draw.Size(2000, 20);

            return this.BtBuscar;
        }


        //Boton para editar un cliente
        WForms.Button BuildBtEditar()
        {
            this.BtEditar = new WForms.Button
            {
                Dock = WForms.DockStyle.Bottom,
                Text = "Editar cliente"
            };
            this.MaximumSize = new Draw.Size(2000, 20);

            return this.BtEditar;
        }

        //Boton para eliminar un cliente
        WForms.Button BuildBtEliminar()
        {
            this.BtEliminar = new WForms.Button
            {
                Dock = WForms.DockStyle.Bottom,
                Text = "Eliminar cliente"
            };
            this.MaximumSize = new Draw.Size(2000, 20);

            return this.BtEliminar;
        }


        public WForms.Label titulodni
        {
            get; private set;
        }
        public WForms.TextBox dni
        {
            get; private set;
        }


        public WForms.Label titulonombre
        {
            get; private set;
        }
        public WForms.TextBox nombre
        {
            get; private set;
        }

        public WForms.Label titulotelefono
        {
            get; private set;
        }

        public WForms.TextBox telefono
        {
            get; private set;
        }

        public WForms.Label tituloemail
        {
            get; private set;
        }

        public WForms.TextBox email
        {
            get; private set;
        }

        public WForms.Label titulodireccion
        {
            get; private set;
        }

        public WForms.TextBox direccion
        {
            get; private set;
        }

        public WForms.Button BtAnhade
        {
            get; private set;
        }

        public WForms.Button BtListar
        {
            get; private set;
        }

        public WForms.Button BtBuscar
        {
            get; private set;
        }

        public WForms.Button BtEditar
        {
            get; private set;
        }

        public WForms.Button BtEliminar
        {
            get; private set;
        }

    }
}