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
    public class Pais : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        // Use CodeRush to create XPO classes and properties with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/118557
        public Pais(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            Visible = true;
            FechaCreacion = DateTime.Today;
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }
        private string _Nombre;
        [XafDisplayName("Ingresa el nombre del País"), ToolTip("Ingresa el nombre del País")]
        //[ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)]
        //[Persistent("DatabaseColumnName"), RuleRequiredField(DefaultContexts.Save)]
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


        private DateTime _FechaCreacion;
        //[XafDisplayName("Ingresa el FechaCreacion del País"), ToolTip("Ingresa el FechaCreacion del País")]
        //[ModelDefault("EditMask", "(000)-00"), Index(0), FechaCreacionInListView(false)]
        //[Persistent("DatabaseColumnName"), RuleRequiredField(DefaultContexts.Save)]
        public DateTime FechaCreacion
        {
            get { return _FechaCreacion; }
            set { SetPropertyValue(nameof(FechaCreacion), ref _FechaCreacion, value); }
        }


        private Catalogo_Idioma _Idioma;
        public Catalogo_Idioma Idioma
        {
            get { return _Idioma; }
            set { SetPropertyValue(nameof(Idioma), ref _Idioma, value); }
        }


        private FileData _Imagen;
        [VisibleInListView(false)]
        public FileData Imagen
        {
            get { return _Imagen; }
            set { SetPropertyValue(nameof(Imagen), ref _Imagen, value); }
        }




        //[Action(Caption = "My UI Action", ConfirmationMessage = "Are you sure?", ImageName = "Attention", AutoCommit = true)]
        //public void ActionMethod() {
        //    // Trigger a custom business logic for the current record in the UI (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112619.aspx).
        //    this.PersistentProperty = "Paid";
        //}
    }
}