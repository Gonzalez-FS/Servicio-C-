
namespace WindowsService3
{
    partial class ProjectInstaller
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.serviceProcessInstaller3 = new System.ServiceProcess.ServiceProcessInstaller();
            this.serviceInstaller3 = new System.ServiceProcess.ServiceInstaller();
            // 
            // serviceProcessInstaller3
            // 
            this.serviceProcessInstaller3.Account = System.ServiceProcess.ServiceAccount.LocalService;
            this.serviceProcessInstaller3.Password = null;
            this.serviceProcessInstaller3.Username = null;
            // 
            // serviceInstaller3
            // 
            this.serviceInstaller3.ServiceName = "Service3";
            // 
            // ProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.serviceProcessInstaller3,
            this.serviceInstaller3});

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller serviceProcessInstaller3;
        private System.ServiceProcess.ServiceInstaller serviceInstaller3;
    }
}