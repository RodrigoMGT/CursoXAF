﻿using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace CursoXAF.Module.BusinessObjects
{
    [DefaultClassOptions]
    //[ImageName("BO_Contact")]
    //[DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class Catalogo_Idioma : XPObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public Catalogo_Idioma(Session session)
            : base(session)
        {
        }

        #region Propiedades

        private string _Nombre;
        [RuleRequiredField(DefaultContexts.Save)]
        public string Nombre
        {
            get { return _Nombre; }
            set { SetPropertyValue(nameof(Nombre), ref _Nombre, value); }
        }


        private bool _Visible;
        //[XafDisplayName("Ingresa el Visible del País"), ToolTip("Ingresa el Visible del País")]
        //[ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)]
        //[Persistent("DatabaseColumnName"), RuleRequiredField(DefaultContexts.Save)]
        public bool Visible
        {
            get { return _Visible; }
            set { SetPropertyValue(nameof(Visible), ref _Visible, value); }
        }

        private int _Orden;
        //[XafDisplayName("Ingresa el Orden del País"), ToolTip("Ingresa el Orden del País")]
        //[ModelDefault("EditMask", "(000)-00"), Index(0), OrdenInListView(false)]
        //[Persistent("DatabaseColumnName"), RuleRequiredField(DefaultContexts.Save)]
        public int Orden
        {
            get { return _Orden; }
            set { SetPropertyValue(nameof(Orden), ref _Orden, value); }
        }


        #endregion

        #region Asociaciones
        #endregion

        #region Metodos
        public override void AfterConstruction()
        {
            base.AfterConstruction();

            this.Visible = true;
            var ultimoRegistro = Session.Query<Catalogo_Idioma>().OrderByDescending(p => p.Orden).FirstOrDefault();
            if (ultimoRegistro == null)
                this.Orden = 1;
            else
                this.Orden = ultimoRegistro.Orden + 1;

        }


        [Action(Caption = "Activar / Desactivar", ConfirmationMessage = "Deseas cambiar el Campo Visible?", AutoCommit = true)]
        public void ActivarDesactivar()
        {
            this.Visible = !this.Visible;

            //if (this.Visible == true)
            //    this.Visible = false;
            //else
            //    this.Visible = true;

        }
        #endregion

    }
}