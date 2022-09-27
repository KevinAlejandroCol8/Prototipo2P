
namespace CapaVista
{
    partial class AsignacionCursoMaestro
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
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtBusacar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ListAsignacion = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtEliminar = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtCarrera = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdAsignacion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.txtSede = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.txtAula = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.txtMaestro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.txtCurso = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ListCarrera = new System.Windows.Forms.DataGridView();
            this.ListaSede = new System.Windows.Forms.DataGridView();
            this.ListaAula = new System.Windows.Forms.DataGridView();
            this.ListCurso = new System.Windows.Forms.DataGridView();
            this.listMaestro = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListAsignacion)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListCarrera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListaSede)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListaAula)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListCurso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listMaestro)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(150, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(337, 31);
            this.label9.TabIndex = 53;
            this.label9.Text = "Asignacion CUrso Maestro";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtBusacar);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(29, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(517, 82);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modificar";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(390, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtBusacar
            // 
            this.txtBusacar.Location = new System.Drawing.Point(110, 33);
            this.txtBusacar.Name = "txtBusacar";
            this.txtBusacar.Size = new System.Drawing.Size(260, 20);
            this.txtBusacar.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Buscar Id";
            // 
            // ListAsignacion
            // 
            this.ListAsignacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListAsignacion.Location = new System.Drawing.Point(29, 411);
            this.ListAsignacion.Name = "ListAsignacion";
            this.ListAsignacion.RowHeadersWidth = 51;
            this.ListAsignacion.Size = new System.Drawing.Size(590, 126);
            this.ListAsignacion.TabIndex = 51;
            this.ListAsignacion.Tag = "asignacioncursosmastros";
            this.ListAsignacion.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListAsignacion_CellDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.txtMaestro);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.txtCurso);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.txtAula);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.txtSede);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.txtEliminar);
            this.groupBox2.Controls.Add(this.btnIngresar);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.txtCarrera);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtIdAsignacion);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(29, 148);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(590, 257);
            this.groupBox2.TabIndex = 50;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Carrera";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(158, 44);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 24);
            this.button2.TabIndex = 44;
            this.button2.Text = "?";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtEliminar
            // 
            this.txtEliminar.Location = new System.Drawing.Point(342, 231);
            this.txtEliminar.Name = "txtEliminar";
            this.txtEliminar.Size = new System.Drawing.Size(28, 20);
            this.txtEliminar.TabIndex = 28;
            this.txtEliminar.Tag = "";
            this.txtEliminar.Visible = false;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(478, 55);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(78, 45);
            this.btnIngresar.TabIndex = 14;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(478, 119);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(78, 42);
            this.button4.TabIndex = 17;
            this.button4.Text = "Modificar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // txtCarrera
            // 
            this.txtCarrera.Location = new System.Drawing.Point(185, 47);
            this.txtCarrera.Name = "txtCarrera";
            this.txtCarrera.Size = new System.Drawing.Size(217, 20);
            this.txtCarrera.TabIndex = 23;
            this.txtCarrera.Tag = "codigo_carrera";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Codigo Carrera";
            // 
            // txtIdAsignacion
            // 
            this.txtIdAsignacion.Location = new System.Drawing.Point(158, 17);
            this.txtIdAsignacion.Name = "txtIdAsignacion";
            this.txtIdAsignacion.Size = new System.Drawing.Size(244, 20);
            this.txtIdAsignacion.TabIndex = 7;
            this.txtIdAsignacion.Tag = "codigo_asignacion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "ID Asignacion";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(158, 80);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(25, 24);
            this.button3.TabIndex = 47;
            this.button3.Text = "?";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtSede
            // 
            this.txtSede.Location = new System.Drawing.Point(185, 83);
            this.txtSede.Name = "txtSede";
            this.txtSede.Size = new System.Drawing.Size(217, 20);
            this.txtSede.TabIndex = 46;
            this.txtSede.Tag = "codigo_sede";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Codigo Sede";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(158, 116);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(25, 24);
            this.button5.TabIndex = 50;
            this.button5.Text = "?";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // txtAula
            // 
            this.txtAula.Location = new System.Drawing.Point(185, 119);
            this.txtAula.Name = "txtAula";
            this.txtAula.Size = new System.Drawing.Size(217, 20);
            this.txtAula.TabIndex = 49;
            this.txtAula.Tag = "codigo_aula";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "Codigo Aula";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(158, 183);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(25, 24);
            this.button6.TabIndex = 56;
            this.button6.Text = "?";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // txtMaestro
            // 
            this.txtMaestro.Location = new System.Drawing.Point(185, 186);
            this.txtMaestro.Name = "txtMaestro";
            this.txtMaestro.Size = new System.Drawing.Size(217, 20);
            this.txtMaestro.TabIndex = 55;
            this.txtMaestro.Tag = "codigo_maestro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 54;
            this.label4.Text = "Codigo Maestro";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(158, 147);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(25, 24);
            this.button7.TabIndex = 53;
            this.button7.Text = "?";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // txtCurso
            // 
            this.txtCurso.Location = new System.Drawing.Point(185, 150);
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.Size = new System.Drawing.Size(217, 20);
            this.txtCurso.TabIndex = 52;
            this.txtCurso.Tag = "codigo_curso";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(68, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 51;
            this.label7.Text = "Codigo Curso";
            // 
            // ListCarrera
            // 
            this.ListCarrera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListCarrera.Location = new System.Drawing.Point(625, 155);
            this.ListCarrera.Name = "ListCarrera";
            this.ListCarrera.RowHeadersWidth = 51;
            this.ListCarrera.Size = new System.Drawing.Size(350, 382);
            this.ListCarrera.TabIndex = 54;
            this.ListCarrera.Tag = "tbl_usuarios";
            this.ListCarrera.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListUsuarios_CellClick);
            // 
            // ListaSede
            // 
            this.ListaSede.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaSede.Location = new System.Drawing.Point(625, 155);
            this.ListaSede.Name = "ListaSede";
            this.ListaSede.RowHeadersWidth = 51;
            this.ListaSede.Size = new System.Drawing.Size(350, 382);
            this.ListaSede.TabIndex = 55;
            this.ListaSede.Tag = "tbl_usuarios";
            this.ListaSede.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListaSede_CellClick);
            // 
            // ListaAula
            // 
            this.ListaAula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaAula.Location = new System.Drawing.Point(625, 155);
            this.ListaAula.Name = "ListaAula";
            this.ListaAula.RowHeadersWidth = 51;
            this.ListaAula.Size = new System.Drawing.Size(350, 382);
            this.ListaAula.TabIndex = 56;
            this.ListaAula.Tag = "tbl_usuarios";
            this.ListaAula.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListaAula_CellClick);
            this.ListaAula.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListaAula_CellContentClick);
            // 
            // ListCurso
            // 
            this.ListCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListCurso.Location = new System.Drawing.Point(625, 155);
            this.ListCurso.Name = "ListCurso";
            this.ListCurso.RowHeadersWidth = 51;
            this.ListCurso.Size = new System.Drawing.Size(350, 382);
            this.ListCurso.TabIndex = 57;
            this.ListCurso.Tag = "tbl_usuarios";
            this.ListCurso.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListCurso_CellClick);
            // 
            // listMaestro
            // 
            this.listMaestro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listMaestro.Location = new System.Drawing.Point(625, 155);
            this.listMaestro.Name = "listMaestro";
            this.listMaestro.RowHeadersWidth = 51;
            this.listMaestro.Size = new System.Drawing.Size(350, 382);
            this.listMaestro.TabIndex = 58;
            this.listMaestro.Tag = "tbl_usuarios";
            this.listMaestro.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listMaestro_CellClick);
            // 
            // AsignacionCursoMaestro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 555);
            this.Controls.Add(this.listMaestro);
            this.Controls.Add(this.ListCurso);
            this.Controls.Add(this.ListaAula);
            this.Controls.Add(this.ListaSede);
            this.Controls.Add(this.ListCarrera);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ListAsignacion);
            this.Controls.Add(this.groupBox2);
            this.Name = "AsignacionCursoMaestro";
            this.Text = "AsignacionCursoMaestro";
            this.Load += new System.EventHandler(this.AsignacionCursoMaestro_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListAsignacion)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListCarrera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListaSede)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListaAula)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListCurso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listMaestro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBusacar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView ListAsignacion;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox txtMaestro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox txtCurso;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txtAula;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtSede;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtEliminar;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtCarrera;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIdAsignacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView ListCarrera;
        private System.Windows.Forms.DataGridView ListaSede;
        private System.Windows.Forms.DataGridView ListaAula;
        private System.Windows.Forms.DataGridView ListCurso;
        private System.Windows.Forms.DataGridView listMaestro;
    }
}