namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.lSI_TESTDataSet = new WindowsFormsApp1.LSI_TESTDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNazva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colData = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGodzina = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUzytkownik = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLokal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.raportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.raportTableAdapter = new WindowsFormsApp1.LSI_TESTDataSetTableAdapters.RaportTableAdapter();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.raportTableAdapter1 = new WindowsFormsApp1.LSI_TESTDataSetTableAdapters.RaportTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lSI_TESTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.AllowRestoreSelectionAndFocusedRow = DevExpress.Utils.DefaultBoolean.False;
            this.gridControl1.DataMember = "Raport";
            this.gridControl1.DataSource = this.lSI_TESTDataSet;
            this.gridControl1.EmbeddedNavigator.Buttons.Edit.Enabled = false;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(60);
            this.gridControl1.Location = new System.Drawing.Point(286, 21);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(60);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(774, 364);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // lSI_TESTDataSet
            // 
            this.lSI_TESTDataSet.DataSetName = "LSI_TESTDataSet";
            this.lSI_TESTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colNazva,
            this.colData,
            this.colGodzina,
            this.colUzytkownik,
            this.colLokal});
            this.gridView1.DetailHeight = 5077;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.MinWidth = 100;
            this.colID.Name = "colID";
            this.colID.OptionsFilter.AllowFilter = false;
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            this.colID.Width = 362;
            // 
            // colNazva
            // 
            this.colNazva.FieldName = "Nazva";
            this.colNazva.MinWidth = 100;
            this.colNazva.Name = "colNazva";
            this.colNazva.OptionsEditForm.Caption = "false";
            this.colNazva.OptionsFilter.AllowFilter = false;
            this.colNazva.Visible = true;
            this.colNazva.VisibleIndex = 1;
            this.colNazva.Width = 511;
            // 
            // colData
            // 
            this.colData.FieldName = "Data";
            this.colData.MinWidth = 100;
            this.colData.Name = "colData";
            this.colData.OptionsFilter.AllowFilter = false;
            this.colData.Visible = true;
            this.colData.VisibleIndex = 2;
            this.colData.Width = 362;
            // 
            // colGodzina
            // 
            this.colGodzina.FieldName = "Godzina";
            this.colGodzina.MinWidth = 100;
            this.colGodzina.Name = "colGodzina";
            this.colGodzina.OptionsFilter.AllowFilter = false;
            this.colGodzina.Visible = true;
            this.colGodzina.VisibleIndex = 3;
            this.colGodzina.Width = 362;
            // 
            // colUzytkownik
            // 
            this.colUzytkownik.FieldName = "Uzytkownik";
            this.colUzytkownik.MinWidth = 100;
            this.colUzytkownik.Name = "colUzytkownik";
            this.colUzytkownik.OptionsFilter.AllowFilter = false;
            this.colUzytkownik.Visible = true;
            this.colUzytkownik.VisibleIndex = 4;
            this.colUzytkownik.Width = 362;
            // 
            // colLokal
            // 
            this.colLokal.FieldName = "Lokal";
            this.colLokal.MinWidth = 100;
            this.colLokal.Name = "colLokal";
            this.colLokal.OptionsFilter.AllowFilter = false;
            this.colLokal.Visible = true;
            this.colLokal.VisibleIndex = 5;
            this.colLokal.Width = 362;
            // 
            // raportBindingSource
            // 
            this.raportBindingSource.DataMember = "Raport";
            this.raportBindingSource.DataSource = this.lSI_TESTDataSet;
            // 
            // raportTableAdapter
            // 
            this.raportTableAdapter.ClearBeforeFill = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(59, 60);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(59, 98);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "saddsad";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(59, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 24);
            this.comboBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Od:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Do:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Local:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(59, 385);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Zatwierdz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // raportTableAdapter1
            // 
            this.raportTableAdapter1.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 722);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.gridControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lSI_TESTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raportBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private LSI_TESTDataSet lSI_TESTDataSet;
        private System.Windows.Forms.BindingSource raportBindingSource;
        private LSI_TESTDataSetTableAdapters.RaportTableAdapter raportTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colNazva;
        private DevExpress.XtraGrid.Columns.GridColumn colData;
        private DevExpress.XtraGrid.Columns.GridColumn colGodzina;
        private DevExpress.XtraGrid.Columns.GridColumn colUzytkownik;
        private DevExpress.XtraGrid.Columns.GridColumn colLokal;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private LSI_TESTDataSetTableAdapters.RaportTableAdapter raportTableAdapter1;
    }
}

