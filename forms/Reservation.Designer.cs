
namespace GestionHotel.forms
{
    partial class Reservation
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.BoxNom = new System.Windows.Forms.TextBox();
            this.BoxPrenom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BoxVille = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BoxAdresse = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BoxTel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BoxPays = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BoxCodePostale = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BoxEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Valider = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.dateDebut = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postgresDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postgresDataSet = new GestionHotel.postgresDataSet();
            this.BoxArrhes = new System.Windows.Forms.TextBox();
            this.comboBoxchambre = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.categoriesTableAdapter = new GestionHotel.postgresDataSetTableAdapters.categoriesTableAdapter();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postgresDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postgresDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(16, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BoxNom
            // 
            this.BoxNom.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BoxNom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BoxNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxNom.Location = new System.Drawing.Point(144, 45);
            this.BoxNom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BoxNom.Multiline = true;
            this.BoxNom.Name = "BoxNom";
            this.BoxNom.Size = new System.Drawing.Size(299, 36);
            this.BoxNom.TabIndex = 1;
            this.BoxNom.TabStop = false;
            this.BoxNom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BoxNom.TextChanged += new System.EventHandler(this.BoxNom_TextChanged);
            // 
            // BoxPrenom
            // 
            this.BoxPrenom.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BoxPrenom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BoxPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BoxPrenom.Location = new System.Drawing.Point(708, 50);
            this.BoxPrenom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BoxPrenom.Multiline = true;
            this.BoxPrenom.Name = "BoxPrenom";
            this.BoxPrenom.Size = new System.Drawing.Size(299, 36);
            this.BoxPrenom.TabIndex = 3;
            this.BoxPrenom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(492, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prenom";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // BoxVille
            // 
            this.BoxVille.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BoxVille.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BoxVille.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BoxVille.Location = new System.Drawing.Point(148, 172);
            this.BoxVille.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BoxVille.Multiline = true;
            this.BoxVille.Name = "BoxVille";
            this.BoxVille.Size = new System.Drawing.Size(295, 36);
            this.BoxVille.TabIndex = 7;
            this.BoxVille.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BoxVille.TextChanged += new System.EventHandler(this.BoxVille_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(15, 172);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ville";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // BoxAdresse
            // 
            this.BoxAdresse.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BoxAdresse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BoxAdresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BoxAdresse.Location = new System.Drawing.Point(144, 111);
            this.BoxAdresse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BoxAdresse.Multiline = true;
            this.BoxAdresse.Name = "BoxAdresse";
            this.BoxAdresse.Size = new System.Drawing.Size(299, 36);
            this.BoxAdresse.TabIndex = 5;
            this.BoxAdresse.TabStop = false;
            this.BoxAdresse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(11, 111);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Adresse";
            // 
            // BoxTel
            // 
            this.BoxTel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BoxTel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BoxTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BoxTel.Location = new System.Drawing.Point(708, 232);
            this.BoxTel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BoxTel.Multiline = true;
            this.BoxTel.Name = "BoxTel";
            this.BoxTel.Size = new System.Drawing.Size(299, 36);
            this.BoxTel.TabIndex = 13;
            this.BoxTel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BoxTel.TextChanged += new System.EventHandler(this.BoxTel_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(492, 232);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Numero";
            // 
            // BoxPays
            // 
            this.BoxPays.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BoxPays.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BoxPays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BoxPays.Location = new System.Drawing.Point(708, 111);
            this.BoxPays.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BoxPays.Multiline = true;
            this.BoxPays.Name = "BoxPays";
            this.BoxPays.Size = new System.Drawing.Size(299, 36);
            this.BoxPays.TabIndex = 11;
            this.BoxPays.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(492, 111);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Nationalité";
            // 
            // BoxCodePostale
            // 
            this.BoxCodePostale.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BoxCodePostale.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BoxCodePostale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BoxCodePostale.Location = new System.Drawing.Point(707, 172);
            this.BoxCodePostale.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BoxCodePostale.Multiline = true;
            this.BoxCodePostale.Name = "BoxCodePostale";
            this.BoxCodePostale.Size = new System.Drawing.Size(300, 36);
            this.BoxCodePostale.TabIndex = 9;
            this.BoxCodePostale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BoxCodePostale.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(491, 172);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "Code Postale";
            // 
            // BoxEmail
            // 
            this.BoxEmail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BoxEmail.Location = new System.Drawing.Point(144, 232);
            this.BoxEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BoxEmail.Multiline = true;
            this.BoxEmail.Name = "BoxEmail";
            this.BoxEmail.Size = new System.Drawing.Size(299, 36);
            this.BoxEmail.TabIndex = 15;
            this.BoxEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(16, 232);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 25);
            this.label8.TabIndex = 14;
            this.label8.Text = "Mail";
            // 
            // Valider
            // 
            this.Valider.BackColor = System.Drawing.Color.RoyalBlue;
            this.Valider.FlatAppearance.BorderSize = 0;
            this.Valider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Valider.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Valider.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Valider.Location = new System.Drawing.Point(885, 498);
            this.Valider.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Valider.Name = "Valider";
            this.Valider.Size = new System.Drawing.Size(123, 43);
            this.Valider.TabIndex = 16;
            this.Valider.Text = "Valider";
            this.Valider.UseVisualStyleBackColor = false;
            this.Valider.Click += new System.EventHandler(this.Valider_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Location = new System.Drawing.Point(11, 294);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 25);
            this.label11.TabIndex = 21;
            this.label11.Text = "Date début";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // dateDebut
            // 
            this.dateDebut.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDebut.CustomFormat = "dd-MM-yyyy";
            this.dateDebut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDebut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateDebut.Location = new System.Drawing.Point(144, 294);
            this.dateDebut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateDebut.Name = "dateDebut";
            this.dateDebut.Size = new System.Drawing.Size(299, 30);
            this.dateDebut.TabIndex = 22;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(705, 291);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(300, 30);
            this.dateTimePicker1.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label12.Location = new System.Drawing.Point(492, 299);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(123, 25);
            this.label12.TabIndex = 23;
            this.label12.Text = "Date départ";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label14.Location = new System.Drawing.Point(492, 353);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 25);
            this.label14.TabIndex = 27;
            this.label14.Text = "Prix / nuit";
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "categories";
            this.categoriesBindingSource.DataSource = this.postgresDataSetBindingSource;
            // 
            // postgresDataSetBindingSource
            // 
            this.postgresDataSetBindingSource.DataSource = this.postgresDataSet;
            this.postgresDataSetBindingSource.Position = 0;
            // 
            // postgresDataSet
            // 
            this.postgresDataSet.DataSetName = "postgresDataSet";
            this.postgresDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BoxArrhes
            // 
            this.BoxArrhes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BoxArrhes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BoxArrhes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BoxArrhes.Location = new System.Drawing.Point(707, 353);
            this.BoxArrhes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BoxArrhes.Multiline = true;
            this.BoxArrhes.Name = "BoxArrhes";
            this.BoxArrhes.Size = new System.Drawing.Size(300, 36);
            this.BoxArrhes.TabIndex = 28;
            this.BoxArrhes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBoxchambre
            // 
            this.comboBoxchambre.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBoxchambre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxchambre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxchambre.FormattingEnabled = true;
            this.comboBoxchambre.Location = new System.Drawing.Point(144, 345);
            this.comboBoxchambre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxchambre.Name = "comboBoxchambre";
            this.comboBoxchambre.Size = new System.Drawing.Size(299, 33);
            this.comboBoxchambre.TabIndex = 32;
            this.comboBoxchambre.SelectedIndexChanged += new System.EventHandler(this.comboBoxchambre_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label15.Location = new System.Drawing.Point(11, 353);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(98, 25);
            this.label15.TabIndex = 31;
            this.label15.Text = "Chambre";
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label16.Location = new System.Drawing.Point(289, 452);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(189, 25);
            this.label16.TabIndex = 33;
            this.label16.Text = "Prix Totale               :";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox1.Location = new System.Drawing.Point(430, 448);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(300, 36);
            this.textBox1.TabIndex = 34;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.comboBoxchambre);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.BoxArrhes);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dateDebut);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Valider);
            this.Controls.Add(this.BoxEmail);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BoxTel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BoxPays);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BoxCodePostale);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BoxVille);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BoxAdresse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BoxPrenom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BoxNom);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Reservation";
            this.Text = "Enregistrer le Client";
            this.Load += new System.EventHandler(this.Clients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postgresDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postgresDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BoxNom;
        private System.Windows.Forms.TextBox BoxPrenom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BoxVille;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox BoxAdresse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox BoxTel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox BoxPays;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox BoxCodePostale;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox BoxEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Valider;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateDebut;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox BoxArrhes;
        private System.Windows.Forms.ComboBox comboBoxchambre;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.BindingSource postgresDataSetBindingSource;
        private postgresDataSet postgresDataSet;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private postgresDataSetTableAdapters.categoriesTableAdapter categoriesTableAdapter;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox1;
    }
}