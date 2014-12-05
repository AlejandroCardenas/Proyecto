namespace ProctoSaludOcupacional.Formularios
{
    partial class IngresoExamen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IngresoExamen));
            this.txtTrabajador = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
            this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
            this.DataTipo = new System.Data.DataSet();
            this.DataEstado = new System.Data.DataSet();
            this.DataPerfil = new System.Data.DataSet();
            this.DataClinia = new System.Data.DataSet();
            this.cbbTipo = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbbEstado = new System.Windows.Forms.ComboBox();
            this.cbbPerfil = new System.Windows.Forms.ComboBox();
            this.cbbClinica = new System.Windows.Forms.ComboBox();
            this.txtExamen = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataSet1 = new System.Data.DataSet();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.alertasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.irToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.examenesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.audiometricoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fisicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laboratorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DataTipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataEstado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataPerfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataClinia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTrabajador
            // 
            this.txtTrabajador.Enabled = false;
            this.txtTrabajador.Location = new System.Drawing.Point(121, 53);
            this.txtTrabajador.Name = "txtTrabajador";
            this.txtTrabajador.Size = new System.Drawing.Size(100, 20);
            this.txtTrabajador.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(227, 51);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(134, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Buscar Trabajador";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Trabajador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tipo Examen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Estado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Perfil";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Clinica";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(401, 248);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(269, 20);
            this.textBox7.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(398, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Observaciones";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(40, 248);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(277, 20);
            this.textBox8.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 223);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Restricciones";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(541, 304);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Ingresar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // oleDbSelectCommand1
            // 
            this.oleDbSelectCommand1.CommandText = "SELECT * FROM Examen";
            this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
            // 
            // oleDbConnection1
            // 
            this.oleDbConnection1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\Database11.mdb;Persi" +
    "st Security Info=True";
            // 
            // oleDbInsertCommand1
            // 
            this.oleDbInsertCommand1.CommandText = resources.GetString("oleDbInsertCommand1.CommandText");
            this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
            this.oleDbInsertCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("IdTrabajador", System.Data.OleDb.OleDbType.VarWChar, 0, "IdTrabajador"),
            new System.Data.OleDb.OleDbParameter("TipoExamen", System.Data.OleDb.OleDbType.Integer, 0, "TipoExamen"),
            new System.Data.OleDb.OleDbParameter("Fecha", System.Data.OleDb.OleDbType.Date, 0, "Fecha"),
            new System.Data.OleDb.OleDbParameter("Estado", System.Data.OleDb.OleDbType.Integer, 0, "Estado"),
            new System.Data.OleDb.OleDbParameter("Odontologia", System.Data.OleDb.OleDbType.VarWChar, 0, "Odontologia"),
            new System.Data.OleDb.OleDbParameter("Presion_Arterial", System.Data.OleDb.OleDbType.VarWChar, 0, "Presion Arterial"),
            new System.Data.OleDb.OleDbParameter("EKG", System.Data.OleDb.OleDbType.VarWChar, 0, "EKG"),
            new System.Data.OleDb.OleDbParameter("Psicologico", System.Data.OleDb.OleDbType.VarWChar, 0, "Psicologico"),
            new System.Data.OleDb.OleDbParameter("Esfuerzo", System.Data.OleDb.OleDbType.VarWChar, 0, "Esfuerzo"),
            new System.Data.OleDb.OleDbParameter("PSA", System.Data.OleDb.OleDbType.Integer, 0, "PSA"),
            new System.Data.OleDb.OleDbParameter("Orina", System.Data.OleDb.OleDbType.VarWChar, 0, "Orina"),
            new System.Data.OleDb.OleDbParameter("HIV", System.Data.OleDb.OleDbType.Boolean, 0, "HIV"),
            new System.Data.OleDb.OleDbParameter("Cocaina", System.Data.OleDb.OleDbType.Boolean, 0, "Cocaina"),
            new System.Data.OleDb.OleDbParameter("Marihuana", System.Data.OleDb.OleDbType.Boolean, 0, "Marihuana"),
            new System.Data.OleDb.OleDbParameter("Psicosensometrico", System.Data.OleDb.OleDbType.Integer, 0, "Psicosensometrico"),
            new System.Data.OleDb.OleDbParameter("Ergonometria", System.Data.OleDb.OleDbType.Integer, 0, "Ergonometria"),
            new System.Data.OleDb.OleDbParameter("Asceenso_a_grandes_altitudes", System.Data.OleDb.OleDbType.Integer, 0, "Asceenso a grandes altitudes"),
            new System.Data.OleDb.OleDbParameter("Trabajos_de_Riesgo", System.Data.OleDb.OleDbType.Integer, 0, "Trabajos de Riesgo"),
            new System.Data.OleDb.OleDbParameter("PERFIL", System.Data.OleDb.OleDbType.Integer, 0, "PERFIL"),
            new System.Data.OleDb.OleDbParameter("RESTRICCIONES", System.Data.OleDb.OleDbType.LongVarWChar, 0, "RESTRICCIONES"),
            new System.Data.OleDb.OleDbParameter("OBSERVACIONES", System.Data.OleDb.OleDbType.LongVarWChar, 0, "OBSERVACIONES"),
            new System.Data.OleDb.OleDbParameter("CLINICA", System.Data.OleDb.OleDbType.Integer, 0, "CLINICA")});
            // 
            // oleDbUpdateCommand1
            // 
            this.oleDbUpdateCommand1.CommandText = resources.GetString("oleDbUpdateCommand1.CommandText");
            this.oleDbUpdateCommand1.Connection = this.oleDbConnection1;
            this.oleDbUpdateCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("IdTrabajador", System.Data.OleDb.OleDbType.VarWChar, 0, "IdTrabajador"),
            new System.Data.OleDb.OleDbParameter("TipoExamen", System.Data.OleDb.OleDbType.Integer, 0, "TipoExamen"),
            new System.Data.OleDb.OleDbParameter("Fecha", System.Data.OleDb.OleDbType.Date, 0, "Fecha"),
            new System.Data.OleDb.OleDbParameter("Estado", System.Data.OleDb.OleDbType.Integer, 0, "Estado"),
            new System.Data.OleDb.OleDbParameter("Odontologia", System.Data.OleDb.OleDbType.VarWChar, 0, "Odontologia"),
            new System.Data.OleDb.OleDbParameter("Presion_Arterial", System.Data.OleDb.OleDbType.VarWChar, 0, "Presion Arterial"),
            new System.Data.OleDb.OleDbParameter("EKG", System.Data.OleDb.OleDbType.VarWChar, 0, "EKG"),
            new System.Data.OleDb.OleDbParameter("Psicologico", System.Data.OleDb.OleDbType.VarWChar, 0, "Psicologico"),
            new System.Data.OleDb.OleDbParameter("Esfuerzo", System.Data.OleDb.OleDbType.VarWChar, 0, "Esfuerzo"),
            new System.Data.OleDb.OleDbParameter("PSA", System.Data.OleDb.OleDbType.Integer, 0, "PSA"),
            new System.Data.OleDb.OleDbParameter("Orina", System.Data.OleDb.OleDbType.VarWChar, 0, "Orina"),
            new System.Data.OleDb.OleDbParameter("HIV", System.Data.OleDb.OleDbType.Boolean, 0, "HIV"),
            new System.Data.OleDb.OleDbParameter("Cocaina", System.Data.OleDb.OleDbType.Boolean, 0, "Cocaina"),
            new System.Data.OleDb.OleDbParameter("Marihuana", System.Data.OleDb.OleDbType.Boolean, 0, "Marihuana"),
            new System.Data.OleDb.OleDbParameter("Psicosensometrico", System.Data.OleDb.OleDbType.Integer, 0, "Psicosensometrico"),
            new System.Data.OleDb.OleDbParameter("Ergonometria", System.Data.OleDb.OleDbType.Integer, 0, "Ergonometria"),
            new System.Data.OleDb.OleDbParameter("Asceenso_a_grandes_altitudes", System.Data.OleDb.OleDbType.Integer, 0, "Asceenso a grandes altitudes"),
            new System.Data.OleDb.OleDbParameter("Trabajos_de_Riesgo", System.Data.OleDb.OleDbType.Integer, 0, "Trabajos de Riesgo"),
            new System.Data.OleDb.OleDbParameter("PERFIL", System.Data.OleDb.OleDbType.Integer, 0, "PERFIL"),
            new System.Data.OleDb.OleDbParameter("RESTRICCIONES", System.Data.OleDb.OleDbType.LongVarWChar, 0, "RESTRICCIONES"),
            new System.Data.OleDb.OleDbParameter("OBSERVACIONES", System.Data.OleDb.OleDbType.LongVarWChar, 0, "OBSERVACIONES"),
            new System.Data.OleDb.OleDbParameter("CLINICA", System.Data.OleDb.OleDbType.Integer, 0, "CLINICA"),
            new System.Data.OleDb.OleDbParameter("Original_IdExamen", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdExamen", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_IdTrabajador", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "IdTrabajador", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_IdTrabajador", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdTrabajador", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_TipoExamen", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "TipoExamen", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_TipoExamen", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "TipoExamen", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Fecha", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fecha", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Fecha", System.Data.OleDb.OleDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fecha", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Estado", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Estado", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Estado", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Estado", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Odontologia", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Odontologia", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Odontologia", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Odontologia", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Presion_Arterial", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Presion Arterial", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Presion_Arterial", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Presion Arterial", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_EKG", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EKG", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_EKG", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EKG", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Psicologico", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Psicologico", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Psicologico", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Psicologico", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Esfuerzo", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Esfuerzo", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Esfuerzo", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Esfuerzo", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_PSA", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PSA", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_PSA", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PSA", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Orina", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Orina", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Orina", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Orina", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_HIV", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "HIV", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_HIV", System.Data.OleDb.OleDbType.Boolean, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "HIV", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Cocaina", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Cocaina", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Cocaina", System.Data.OleDb.OleDbType.Boolean, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Cocaina", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Marihuana", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Marihuana", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Marihuana", System.Data.OleDb.OleDbType.Boolean, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Marihuana", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Psicosensometrico", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Psicosensometrico", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Psicosensometrico", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Psicosensometrico", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Ergonometria", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Ergonometria", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Ergonometria", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Ergonometria", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Asceenso_a_grandes_altitudes", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Asceenso a grandes altitudes", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Asceenso_a_grandes_altitudes", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Asceenso a grandes altitudes", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Trabajos_de_Riesgo", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Trabajos de Riesgo", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Trabajos_de_Riesgo", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Trabajos de Riesgo", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_PERFIL", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PERFIL", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_PERFIL", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PERFIL", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_CLINICA", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "CLINICA", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_CLINICA", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CLINICA", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDeleteCommand1
            // 
            this.oleDbDeleteCommand1.CommandText = resources.GetString("oleDbDeleteCommand1.CommandText");
            this.oleDbDeleteCommand1.Connection = this.oleDbConnection1;
            this.oleDbDeleteCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_IdExamen", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdExamen", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_IdTrabajador", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "IdTrabajador", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_IdTrabajador", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "IdTrabajador", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_TipoExamen", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "TipoExamen", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_TipoExamen", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "TipoExamen", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Fecha", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Fecha", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Fecha", System.Data.OleDb.OleDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Fecha", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Estado", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Estado", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Estado", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Estado", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Odontologia", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Odontologia", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Odontologia", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Odontologia", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Presion_Arterial", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Presion Arterial", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Presion_Arterial", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Presion Arterial", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_EKG", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EKG", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_EKG", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EKG", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Psicologico", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Psicologico", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Psicologico", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Psicologico", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Esfuerzo", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Esfuerzo", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Esfuerzo", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Esfuerzo", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_PSA", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PSA", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_PSA", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PSA", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Orina", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Orina", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Orina", System.Data.OleDb.OleDbType.VarWChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Orina", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_HIV", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "HIV", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_HIV", System.Data.OleDb.OleDbType.Boolean, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "HIV", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Cocaina", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Cocaina", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Cocaina", System.Data.OleDb.OleDbType.Boolean, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Cocaina", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Marihuana", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Marihuana", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Marihuana", System.Data.OleDb.OleDbType.Boolean, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Marihuana", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Psicosensometrico", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Psicosensometrico", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Psicosensometrico", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Psicosensometrico", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Ergonometria", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Ergonometria", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Ergonometria", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Ergonometria", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Asceenso_a_grandes_altitudes", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Asceenso a grandes altitudes", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Asceenso_a_grandes_altitudes", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Asceenso a grandes altitudes", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_Trabajos_de_Riesgo", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "Trabajos de Riesgo", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_Trabajos_de_Riesgo", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Trabajos de Riesgo", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_PERFIL", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "PERFIL", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_PERFIL", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PERFIL", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("IsNull_CLINICA", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "CLINICA", System.Data.DataRowVersion.Original, true, null),
            new System.Data.OleDb.OleDbParameter("Original_CLINICA", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CLINICA", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbDataAdapter1
            // 
            this.oleDbDataAdapter1.DeleteCommand = this.oleDbDeleteCommand1;
            this.oleDbDataAdapter1.InsertCommand = this.oleDbInsertCommand1;
            this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
            this.oleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Examen", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("IdExamen", "IdExamen"),
                        new System.Data.Common.DataColumnMapping("IdTrabajador", "IdTrabajador"),
                        new System.Data.Common.DataColumnMapping("TipoExamen", "TipoExamen"),
                        new System.Data.Common.DataColumnMapping("Fecha", "Fecha"),
                        new System.Data.Common.DataColumnMapping("Estado", "Estado"),
                        new System.Data.Common.DataColumnMapping("Odontologia", "Odontologia"),
                        new System.Data.Common.DataColumnMapping("Presion Arterial", "Presion Arterial"),
                        new System.Data.Common.DataColumnMapping("EKG", "EKG"),
                        new System.Data.Common.DataColumnMapping("Psicologico", "Psicologico"),
                        new System.Data.Common.DataColumnMapping("Esfuerzo", "Esfuerzo"),
                        new System.Data.Common.DataColumnMapping("PSA", "PSA"),
                        new System.Data.Common.DataColumnMapping("Orina", "Orina"),
                        new System.Data.Common.DataColumnMapping("HIV", "HIV"),
                        new System.Data.Common.DataColumnMapping("Cocaina", "Cocaina"),
                        new System.Data.Common.DataColumnMapping("Marihuana", "Marihuana"),
                        new System.Data.Common.DataColumnMapping("Psicosensometrico", "Psicosensometrico"),
                        new System.Data.Common.DataColumnMapping("Ergonometria", "Ergonometria"),
                        new System.Data.Common.DataColumnMapping("Asceenso a grandes altitudes", "Asceenso a grandes altitudes"),
                        new System.Data.Common.DataColumnMapping("Trabajos de Riesgo", "Trabajos de Riesgo"),
                        new System.Data.Common.DataColumnMapping("PERFIL", "PERFIL"),
                        new System.Data.Common.DataColumnMapping("RESTRICCIONES", "RESTRICCIONES"),
                        new System.Data.Common.DataColumnMapping("OBSERVACIONES", "OBSERVACIONES"),
                        new System.Data.Common.DataColumnMapping("CLINICA", "CLINICA")})});
            this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand1;
            // 
            // DataTipo
            // 
            this.DataTipo.DataSetName = "NewDataSet";
            // 
            // DataEstado
            // 
            this.DataEstado.DataSetName = "NewDataSet";
            // 
            // DataPerfil
            // 
            this.DataPerfil.DataSetName = "NewDataSet";
            // 
            // DataClinia
            // 
            this.DataClinia.DataSetName = "NewDataSet";
            // 
            // cbbTipo
            // 
            this.cbbTipo.FormattingEnabled = true;
            this.cbbTipo.Location = new System.Drawing.Point(121, 90);
            this.cbbTipo.Name = "cbbTipo";
            this.cbbTipo.Size = new System.Drawing.Size(121, 21);
            this.cbbTipo.TabIndex = 17;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(121, 116);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 20);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // cbbEstado
            // 
            this.cbbEstado.FormattingEnabled = true;
            this.cbbEstado.Location = new System.Drawing.Point(121, 143);
            this.cbbEstado.Name = "cbbEstado";
            this.cbbEstado.Size = new System.Drawing.Size(121, 21);
            this.cbbEstado.TabIndex = 19;
            // 
            // cbbPerfil
            // 
            this.cbbPerfil.FormattingEnabled = true;
            this.cbbPerfil.Location = new System.Drawing.Point(121, 171);
            this.cbbPerfil.Name = "cbbPerfil";
            this.cbbPerfil.Size = new System.Drawing.Size(121, 21);
            this.cbbPerfil.TabIndex = 20;
            // 
            // cbbClinica
            // 
            this.cbbClinica.FormattingEnabled = true;
            this.cbbClinica.Location = new System.Drawing.Point(121, 199);
            this.cbbClinica.Name = "cbbClinica";
            this.cbbClinica.Size = new System.Drawing.Size(121, 21);
            this.cbbClinica.TabIndex = 21;
            // 
            // txtExamen
            // 
            this.txtExamen.Enabled = false;
            this.txtExamen.Location = new System.Drawing.Point(597, 56);
            this.txtExamen.Name = "txtExamen";
            this.txtExamen.Size = new System.Drawing.Size(100, 20);
            this.txtExamen.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(507, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "IdExamen";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alertasToolStripMenuItem,
            this.examenesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(915, 24);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // alertasToolStripMenuItem
            // 
            this.alertasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.irToolStripMenuItem});
            this.alertasToolStripMenuItem.Name = "alertasToolStripMenuItem";
            this.alertasToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.alertasToolStripMenuItem.Text = "Alertas";
            // 
            // irToolStripMenuItem
            // 
            this.irToolStripMenuItem.Name = "irToolStripMenuItem";
            this.irToolStripMenuItem.Size = new System.Drawing.Size(90, 22);
            this.irToolStripMenuItem.Text = "Ir...";
            this.irToolStripMenuItem.Click += new System.EventHandler(this.irToolStripMenuItem_Click);
            // 
            // examenesToolStripMenuItem
            // 
            this.examenesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.audiometricoToolStripMenuItem,
            this.fisicoToolStripMenuItem,
            this.laboratorioToolStripMenuItem});
            this.examenesToolStripMenuItem.Name = "examenesToolStripMenuItem";
            this.examenesToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.examenesToolStripMenuItem.Text = "Examenes";
            // 
            // audiometricoToolStripMenuItem
            // 
            this.audiometricoToolStripMenuItem.Name = "audiometricoToolStripMenuItem";
            this.audiometricoToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.audiometricoToolStripMenuItem.Text = "Audiometrico";
            // 
            // fisicoToolStripMenuItem
            // 
            this.fisicoToolStripMenuItem.Name = "fisicoToolStripMenuItem";
            this.fisicoToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.fisicoToolStripMenuItem.Text = "Fisico";
            // 
            // laboratorioToolStripMenuItem
            // 
            this.laboratorioToolStripMenuItem.Name = "laboratorioToolStripMenuItem";
            this.laboratorioToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.laboratorioToolStripMenuItem.Text = "Laboratorio";
            // 
            // IngresoExamen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 472);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtExamen);
            this.Controls.Add(this.cbbClinica);
            this.Controls.Add(this.cbbPerfil);
            this.Controls.Add(this.cbbEstado);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cbbTipo);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtTrabajador);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "IngresoExamen";
            this.Text = "IngresoExamen";
            ((System.ComponentModel.ISupportInitialize)(this.DataTipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataEstado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataPerfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataClinia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTrabajador;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAdd;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
        private System.Data.OleDb.OleDbConnection oleDbConnection1;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
        private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
        private System.Data.DataSet DataTipo;
        private System.Data.DataSet DataEstado;
        private System.Data.DataSet DataPerfil;
        private System.Data.DataSet DataClinia;
        private System.Windows.Forms.ComboBox cbbTipo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cbbEstado;
        private System.Windows.Forms.ComboBox cbbPerfil;
        private System.Windows.Forms.ComboBox cbbClinica;
        private System.Windows.Forms.TextBox txtExamen;
        private System.Windows.Forms.Label label6;
        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem alertasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem irToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem examenesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem audiometricoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fisicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laboratorioToolStripMenuItem;
    }
}