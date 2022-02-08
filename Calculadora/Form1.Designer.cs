namespace Calculadora
{
    partial class Calculadora
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
            this.tresult = new System.Windows.Forms.TextBox();
            this.lhistorial = new System.Windows.Forms.Label();
            this.btnuno = new System.Windows.Forms.Button();
            this.btntres = new System.Windows.Forms.Button();
            this.btndos = new System.Windows.Forms.Button();
            this.btncinco = new System.Windows.Forms.Button();
            this.btnseis = new System.Windows.Forms.Button();
            this.btncuatro = new System.Windows.Forms.Button();
            this.btnocho = new System.Windows.Forms.Button();
            this.btnnueve = new System.Windows.Forms.Button();
            this.btnsiete = new System.Windows.Forms.Button();
            this.btncero = new System.Windows.Forms.Button();
            this.btndecimal = new System.Windows.Forms.Button();
            this.btnmultiplicar = new System.Windows.Forms.Button();
            this.btnrestar = new System.Windows.Forms.Button();
            this.btnsumar = new System.Windows.Forms.Button();
            this.btnresultado = new System.Windows.Forms.Button();
            this.btnmodulo = new System.Windows.Forms.Button();
            this.btndividir = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tresult
            // 
            this.tresult.Location = new System.Drawing.Point(30, 76);
            this.tresult.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tresult.Name = "tresult";
            this.tresult.ReadOnly = true;
            this.tresult.Size = new System.Drawing.Size(214, 23);
            this.tresult.TabIndex = 0;
            // 
            // lhistorial
            // 
            this.lhistorial.AutoSize = true;
            this.lhistorial.Location = new System.Drawing.Point(46, 41);
            this.lhistorial.Name = "lhistorial";
            this.lhistorial.Size = new System.Drawing.Size(0, 15);
            this.lhistorial.TabIndex = 1;
            this.lhistorial.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnuno
            // 
            this.btnuno.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnuno.Location = new System.Drawing.Point(28, 258);
            this.btnuno.Name = "btnuno";
            this.btnuno.Size = new System.Drawing.Size(49, 42);
            this.btnuno.TabIndex = 2;
            this.btnuno.Text = "1";
            this.btnuno.UseVisualStyleBackColor = true;
            this.btnuno.Click += new System.EventHandler(this.btnuno_Click);
            // 
            // btntres
            // 
            this.btntres.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntres.Location = new System.Drawing.Point(138, 258);
            this.btntres.Name = "btntres";
            this.btntres.Size = new System.Drawing.Size(49, 42);
            this.btntres.TabIndex = 3;
            this.btntres.Text = "3";
            this.btntres.UseVisualStyleBackColor = true;
            this.btntres.Click += new System.EventHandler(this.btntres_Click);
            // 
            // btndos
            // 
            this.btndos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndos.Location = new System.Drawing.Point(83, 258);
            this.btndos.Name = "btndos";
            this.btndos.Size = new System.Drawing.Size(49, 42);
            this.btndos.TabIndex = 4;
            this.btndos.Text = "2";
            this.btndos.UseVisualStyleBackColor = true;
            this.btndos.Click += new System.EventHandler(this.btndos_Click);
            // 
            // btncinco
            // 
            this.btncinco.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncinco.Location = new System.Drawing.Point(83, 210);
            this.btncinco.Name = "btncinco";
            this.btncinco.Size = new System.Drawing.Size(49, 42);
            this.btncinco.TabIndex = 7;
            this.btncinco.Text = "5";
            this.btncinco.UseVisualStyleBackColor = true;
            this.btncinco.Click += new System.EventHandler(this.btncinco_Click);
            // 
            // btnseis
            // 
            this.btnseis.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnseis.Location = new System.Drawing.Point(138, 210);
            this.btnseis.Name = "btnseis";
            this.btnseis.Size = new System.Drawing.Size(49, 42);
            this.btnseis.TabIndex = 6;
            this.btnseis.Text = "6";
            this.btnseis.UseVisualStyleBackColor = true;
            this.btnseis.Click += new System.EventHandler(this.btnseis_Click);
            // 
            // btncuatro
            // 
            this.btncuatro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncuatro.Location = new System.Drawing.Point(28, 210);
            this.btncuatro.Name = "btncuatro";
            this.btncuatro.Size = new System.Drawing.Size(49, 42);
            this.btncuatro.TabIndex = 5;
            this.btncuatro.Text = "4";
            this.btncuatro.UseVisualStyleBackColor = true;
            this.btncuatro.Click += new System.EventHandler(this.btncuatro_Click);
            // 
            // btnocho
            // 
            this.btnocho.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnocho.Location = new System.Drawing.Point(83, 162);
            this.btnocho.Name = "btnocho";
            this.btnocho.Size = new System.Drawing.Size(49, 42);
            this.btnocho.TabIndex = 10;
            this.btnocho.Text = "8";
            this.btnocho.UseVisualStyleBackColor = true;
            this.btnocho.Click += new System.EventHandler(this.btnocho_Click);
            // 
            // btnnueve
            // 
            this.btnnueve.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnueve.Location = new System.Drawing.Point(138, 162);
            this.btnnueve.Name = "btnnueve";
            this.btnnueve.Size = new System.Drawing.Size(49, 42);
            this.btnnueve.TabIndex = 9;
            this.btnnueve.Text = "9";
            this.btnnueve.UseVisualStyleBackColor = true;
            this.btnnueve.Click += new System.EventHandler(this.btnnueve_Click);
            // 
            // btnsiete
            // 
            this.btnsiete.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsiete.Location = new System.Drawing.Point(28, 162);
            this.btnsiete.Name = "btnsiete";
            this.btnsiete.Size = new System.Drawing.Size(49, 42);
            this.btnsiete.TabIndex = 8;
            this.btnsiete.Text = "7";
            this.btnsiete.UseVisualStyleBackColor = true;
            this.btnsiete.Click += new System.EventHandler(this.btnsiete_Click);
            // 
            // btncero
            // 
            this.btncero.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncero.Location = new System.Drawing.Point(28, 306);
            this.btncero.Name = "btncero";
            this.btncero.Size = new System.Drawing.Size(104, 42);
            this.btncero.TabIndex = 11;
            this.btncero.Text = "0";
            this.btncero.UseVisualStyleBackColor = true;
            this.btncero.Click += new System.EventHandler(this.btncero_Click);
            // 
            // btndecimal
            // 
            this.btndecimal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndecimal.Location = new System.Drawing.Point(138, 306);
            this.btndecimal.Name = "btndecimal";
            this.btndecimal.Size = new System.Drawing.Size(49, 42);
            this.btndecimal.TabIndex = 12;
            this.btndecimal.Text = ".";
            this.btndecimal.UseVisualStyleBackColor = true;
            this.btndecimal.Click += new System.EventHandler(this.btndecimal_Click);
            // 
            // btnmultiplicar
            // 
            this.btnmultiplicar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmultiplicar.Location = new System.Drawing.Point(193, 162);
            this.btnmultiplicar.Name = "btnmultiplicar";
            this.btnmultiplicar.Size = new System.Drawing.Size(49, 42);
            this.btnmultiplicar.TabIndex = 13;
            this.btnmultiplicar.Text = "X";
            this.btnmultiplicar.UseVisualStyleBackColor = true;
            this.btnmultiplicar.Click += new System.EventHandler(this.btnmultiplicar_Click);
            // 
            // btnrestar
            // 
            this.btnrestar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrestar.Location = new System.Drawing.Point(193, 210);
            this.btnrestar.Name = "btnrestar";
            this.btnrestar.Size = new System.Drawing.Size(49, 42);
            this.btnrestar.TabIndex = 14;
            this.btnrestar.Text = "-";
            this.btnrestar.UseVisualStyleBackColor = true;
            this.btnrestar.Click += new System.EventHandler(this.btnrestar_Click);
            // 
            // btnsumar
            // 
            this.btnsumar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsumar.Location = new System.Drawing.Point(193, 258);
            this.btnsumar.Name = "btnsumar";
            this.btnsumar.Size = new System.Drawing.Size(49, 42);
            this.btnsumar.TabIndex = 15;
            this.btnsumar.Text = "+";
            this.btnsumar.UseVisualStyleBackColor = true;
            this.btnsumar.Click += new System.EventHandler(this.btnsumar_Click);
            // 
            // btnresultado
            // 
            this.btnresultado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnresultado.Location = new System.Drawing.Point(193, 306);
            this.btnresultado.Name = "btnresultado";
            this.btnresultado.Size = new System.Drawing.Size(49, 42);
            this.btnresultado.TabIndex = 16;
            this.btnresultado.Text = "=";
            this.btnresultado.UseVisualStyleBackColor = true;
            this.btnresultado.Click += new System.EventHandler(this.btnresultado_Click);
            // 
            // btnmodulo
            // 
            this.btnmodulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodulo.Location = new System.Drawing.Point(28, 114);
            this.btnmodulo.Name = "btnmodulo";
            this.btnmodulo.Size = new System.Drawing.Size(49, 42);
            this.btnmodulo.TabIndex = 17;
            this.btnmodulo.Text = "%";
            this.btnmodulo.UseVisualStyleBackColor = true;
            this.btnmodulo.Click += new System.EventHandler(this.btnmodulo_Click);
            // 
            // btndividir
            // 
            this.btndividir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndividir.Location = new System.Drawing.Point(83, 114);
            this.btndividir.Name = "btndividir";
            this.btndividir.Size = new System.Drawing.Size(49, 42);
            this.btndividir.TabIndex = 18;
            this.btndividir.Text = "/";
            this.btndividir.UseVisualStyleBackColor = true;
            this.btndividir.Click += new System.EventHandler(this.btndividir_Click);
            // 
            // btnreset
            // 
            this.btnreset.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.Location = new System.Drawing.Point(138, 114);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(49, 42);
            this.btnreset.TabIndex = 19;
            this.btnreset.Text = "C";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiar.Location = new System.Drawing.Point(193, 114);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(49, 42);
            this.btnlimpiar.TabIndex = 20;
            this.btnlimpiar.Text = "<";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 373);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btndividir);
            this.Controls.Add(this.btnmodulo);
            this.Controls.Add(this.btnresultado);
            this.Controls.Add(this.btnsumar);
            this.Controls.Add(this.btnrestar);
            this.Controls.Add(this.btnmultiplicar);
            this.Controls.Add(this.btndecimal);
            this.Controls.Add(this.btncero);
            this.Controls.Add(this.btnocho);
            this.Controls.Add(this.btnnueve);
            this.Controls.Add(this.btnsiete);
            this.Controls.Add(this.btncinco);
            this.Controls.Add(this.btnseis);
            this.Controls.Add(this.btncuatro);
            this.Controls.Add(this.btndos);
            this.Controls.Add(this.btntres);
            this.Controls.Add(this.btnuno);
            this.Controls.Add(this.lhistorial);
            this.Controls.Add(this.tresult);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Calculadora";
            this.Text = "CALCULADORA";
            this.Load += new System.EventHandler(this.tresultado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tresult;
        private System.Windows.Forms.Label lhistorial;
        private System.Windows.Forms.Button btnuno;
        private System.Windows.Forms.Button btntres;
        private System.Windows.Forms.Button btndos;
        private System.Windows.Forms.Button btncinco;
        private System.Windows.Forms.Button btnseis;
        private System.Windows.Forms.Button btncuatro;
        private System.Windows.Forms.Button btnocho;
        private System.Windows.Forms.Button btnnueve;
        private System.Windows.Forms.Button btnsiete;
        private System.Windows.Forms.Button btncero;
        private System.Windows.Forms.Button btndecimal;
        private System.Windows.Forms.Button btnmultiplicar;
        private System.Windows.Forms.Button btnrestar;
        private System.Windows.Forms.Button btnsumar;
        private System.Windows.Forms.Button btnresultado;
        private System.Windows.Forms.Button btnmodulo;
        private System.Windows.Forms.Button btndividir;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btnlimpiar;
    }
}

