using System;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Win.Templates;
using DevExpress.XtraBars.Ribbon;
using System.Windows.Forms;

namespace CustomizeOfficeNavigationBar.Win {
    public class OfficeNavigationBarCustomizationController : WindowController {
        private void Frame_TemplateChanged(object sender, EventArgs e) {
            Form form = Frame.Template as Form;
            if(form != null) {
                form.Load += Form_Load;
            }
        }
        private void Form_Load(object sender, EventArgs e) {
            IOfficeNavigationBarHolder officeNavigationBarHolder = sender as IOfficeNavigationBarHolder;
            if(officeNavigationBarHolder != null) {
                officeNavigationBarHolder.OfficeNavigationBar.MaxItemCount = 4;
            }
        }
        protected override void OnActivated() {
            base.OnActivated();
            Frame.TemplateChanged += Frame_TemplateChanged;
        }
        protected override void OnDeactivated() {
            Frame.TemplateChanged -= Frame_TemplateChanged;
            base.OnDeactivated();
        }

        public OfficeNavigationBarCustomizationController() {
            TargetWindowType = WindowType.Main;
        }
    }
}
