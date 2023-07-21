using DevExpress.Data.Filtering;
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
    public class Recursos_Pais : BaseObject
    { 
        public Recursos_Pais(Session session)
            : base(session)
        {
        }
        #region Propiedades

        private Pais _Pais;
        [Association("Pais-Recursos")]
        [RuleRequiredField(DefaultContexts.Save)]
        public Pais Pais
        {
            get { return _Pais; }
            set { SetPropertyValue(nameof(Pais), ref _Pais, value); }
        }

        private string _Nombre;
        [RuleRequiredField(DefaultContexts.Save)]
        public string Nombre
        {
            get { return _Nombre; }
            set { SetPropertyValue(nameof(Nombre), ref _Nombre, value); }
        }

        private string _Descripcion;
        [XafDisplayName("Descripción")]
        [Size(SizeAttribute.Unlimited)]
        public string Descripcion
        {
            get { return _Descripcion; }
            set { SetPropertyValue(nameof(Descripcion), ref _Descripcion, value); }
        }

        private FileData _Archivo;
        public FileData Archivo
        {
            get { return _Archivo; }
            set { SetPropertyValue(nameof(Archivo), ref _Archivo, value); }
        }

        private string _UrlArchivo;
        [XafDisplayName("Url Archivo")]
        [Size(SizeAttribute.Unlimited)]
        public string UrlArchivo
        {
            get { return _UrlArchivo; }
            set { SetPropertyValue(nameof(UrlArchivo), ref _UrlArchivo, value); }
        }

        private bool _Visible;
        public bool Visible
        {
            get { return _Visible; }
            set { SetPropertyValue(nameof(Visible), ref _Visible, value); }
        }

        private int _Orden;
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
            var ultimoRegistro = Session.Query<Recursos_Pais>().OrderByDescending(p => p.Orden).FirstOrDefault();
            if (ultimoRegistro == null)
                this.Orden = 1;
            else
                this.Orden = ultimoRegistro.Orden + 1;

        }

        [Action(Caption = "Activar / Desactivar", AutoCommit = true)]
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