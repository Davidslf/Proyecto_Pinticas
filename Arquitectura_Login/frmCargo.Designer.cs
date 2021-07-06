
namespace Arquitectura_Login
{
    partial class frmCargo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Datos = new System.Windows.Forms.GroupBox();
            this.Id_Cargo = new System.Windows.Forms.Label();
            this.txt_IdCargo = new System.Windows.Forms.TextBox();
            this.Nombre_Cargo = new System.Windows.Forms.Label();
            this.txt_Salario = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.Salario = new System.Windows.Forms.Label();
            this.listar = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BuscarBox1 = new System.Windows.Forms.GroupBox();
            this.Cargo = new System.Windows.Forms.Label();
            this.txtbus_car = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Datos.SuspendLayout();
            this.listar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.BuscarBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Datos
            // 
            this.Datos.Controls.Add(this.Id_Cargo);
            this.Datos.Controls.Add(this.txt_IdCargo);
            this.Datos.Controls.Add(this.Nombre_Cargo);
            this.Datos.Controls.Add(this.txt_Salario);
            this.Datos.Controls.Add(this.txt_Nombre);
            this.Datos.Controls.Add(this.Salario);
            this.Datos.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datos.Location = new System.Drawing.Point(253, 28);
            this.Datos.Name = "Datos";
            this.Datos.Size = new System.Drawing.Size(283, 158);
            this.Datos.TabIndex = 16;
            this.Datos.TabStop = false;
            this.Datos.Text = "Datos";
            // 
            // Id_Cargo
            // 
            this.Id_Cargo.AutoSize = true;
            this.Id_Cargo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id_Cargo.Location = new System.Drawing.Point(62, 32);
            this.Id_Cargo.Name = "Id_Cargo";
            this.Id_Cargo.Size = new System.Drawing.Size(54, 15);
            this.Id_Cargo.TabIndex = 1;
            this.Id_Cargo.Text = "Id_cargo";
            // 
            // txt_IdCargo
            // 
            this.txt_IdCargo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txt_IdCargo.Location = new System.Drawing.Point(136, 29);
            this.txt_IdCargo.Name = "txt_IdCargo";
            this.txt_IdCargo.Size = new System.Drawing.Size(100, 21);
            this.txt_IdCargo.TabIndex = 3;
            // 
            // Nombre_Cargo
            // 
            this.Nombre_Cargo.AutoSize = true;
            this.Nombre_Cargo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre_Cargo.Location = new System.Drawing.Point(33, 79);
            this.Nombre_Cargo.Name = "Nombre_Cargo";
            this.Nombre_Cargo.Size = new System.Drawing.Size(89, 15);
            this.Nombre_Cargo.TabIndex = 0;
            this.Nombre_Cargo.Text = "Nombre_Cargo";
            // 
            // txt_Salario
            // 
            this.txt_Salario.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txt_Salario.Location = new System.Drawing.Point(136, 121);
            this.txt_Salario.Name = "txt_Salario";
            this.txt_Salario.Size = new System.Drawing.Size(100, 21);
            this.txt_Salario.TabIndex = 5;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txt_Nombre.Location = new System.Drawing.Point(136, 79);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(100, 21);
            this.txt_Nombre.TabIndex = 4;
            // 
            // Salario
            // 
            this.Salario.AutoSize = true;
            this.Salario.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salario.Location = new System.Drawing.Point(72, 124);
            this.Salario.Name = "Salario";
            this.Salario.Size = new System.Drawing.Size(44, 15);
            this.Salario.TabIndex = 2;
            this.Salario.Text = "Salario";
            // 
            // listar
            // 
            this.listar.Controls.Add(this.dataGridView1);
            this.listar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listar.Location = new System.Drawing.Point(144, 325);
            this.listar.Name = "listar";
            this.listar.Size = new System.Drawing.Size(500, 113);
            this.listar.TabIndex = 15;
            this.listar.TabStop = false;
            this.listar.Text = "Listar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(488, 88);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // BuscarBox1
            // 
            this.BuscarBox1.Controls.Add(this.Cargo);
            this.BuscarBox1.Controls.Add(this.txtbus_car);
            this.BuscarBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarBox1.Location = new System.Drawing.Point(144, 196);
            this.BuscarBox1.Name = "BuscarBox1";
            this.BuscarBox1.Size = new System.Drawing.Size(500, 116);
            this.BuscarBox1.TabIndex = 14;
            this.BuscarBox1.TabStop = false;
            this.BuscarBox1.Text = "Buscar";
            // 
            // Cargo
            // 
            this.Cargo.AutoSize = true;
            this.Cargo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cargo.Location = new System.Drawing.Point(88, 49);
            this.Cargo.Name = "Cargo";
            this.Cargo.Size = new System.Drawing.Size(40, 15);
            this.Cargo.TabIndex = 1;
            this.Cargo.Text = "Cargo";
            // 
            // txtbus_car
            // 
            this.txtbus_car.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtbus_car.Location = new System.Drawing.Point(172, 49);
            this.txtbus_car.Name = "txtbus_car";
            this.txtbus_car.Size = new System.Drawing.Size(274, 21);
            this.txtbus_car.TabIndex = 0;
            this.txtbus_car.TextChanged += new System.EventHandler(this.txtbus_car_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.registrarToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(60, 21);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // registrarToolStripMenuItem
            // 
            this.registrarToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrarToolStripMenuItem.Name = "registrarToolStripMenuItem";
            this.registrarToolStripMenuItem.Size = new System.Drawing.Size(72, 21);
            this.registrarToolStripMenuItem.Text = "Registrar";
            this.registrarToolStripMenuItem.Click += new System.EventHandler(this.registrarToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(77, 21);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(65, 21);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // frmCargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Datos);
            this.Controls.Add(this.listar);
            this.Controls.Add(this.BuscarBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCargo";
            this.Text = "frmCargo";
            this.Datos.ResumeLayout(false);
            this.Datos.PerformLayout();
            this.listar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.BuscarBox1.ResumeLayout(false);
            this.BuscarBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Datos;
        private System.Windows.Forms.Label Id_Cargo;
        private System.Windows.Forms.TextBox txt_IdCargo;
        private System.Windows.Forms.Label Nombre_Cargo;
        private System.Windows.Forms.TextBox txt_Salario;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label Salario;
        private System.Windows.Forms.GroupBox listar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox BuscarBox1;
        private System.Windows.Forms.Label Cargo;
        private System.Windows.Forms.TextBox txtbus_car;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
    }
}