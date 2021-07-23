namespace Bookstore_XML_Parser
{
    partial class frmXMLParser
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
            this.dlgSelectXML = new System.Windows.Forms.OpenFileDialog();
            this.btnSelectXMLFromFile = new System.Windows.Forms.Button();
            this.btnExportXMLToCSV = new System.Windows.Forms.Button();
            this.txtXML = new System.Windows.Forms.TextBox();
            this.txtInstructions = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dlgSelectXML
            // 
            this.dlgSelectXML.DefaultExt = "xml";
            this.dlgSelectXML.FileName = "xmlFile";
            this.dlgSelectXML.Filter = "xml file (*.xml)|*.xml";
            this.dlgSelectXML.RestoreDirectory = true;
            // 
            // btnSelectXMLFromFile
            // 
            this.btnSelectXMLFromFile.Location = new System.Drawing.Point(12, 12);
            this.btnSelectXMLFromFile.Name = "btnSelectXMLFromFile";
            this.btnSelectXMLFromFile.Size = new System.Drawing.Size(150, 30);
            this.btnSelectXMLFromFile.TabIndex = 0;
            this.btnSelectXMLFromFile.Text = "Select XML from File";
            this.btnSelectXMLFromFile.UseVisualStyleBackColor = true;
            this.btnSelectXMLFromFile.Click += new System.EventHandler(this.btnSelectXMLFromFile_Click);
            // 
            // btnExportXMLToCSV
            // 
            this.btnExportXMLToCSV.Enabled = false;
            this.btnExportXMLToCSV.Location = new System.Drawing.Point(13, 48);
            this.btnExportXMLToCSV.Name = "btnExportXMLToCSV";
            this.btnExportXMLToCSV.Size = new System.Drawing.Size(150, 30);
            this.btnExportXMLToCSV.TabIndex = 1;
            this.btnExportXMLToCSV.Text = "Export XML to CSV";
            this.btnExportXMLToCSV.UseVisualStyleBackColor = true;
            this.btnExportXMLToCSV.Click += new System.EventHandler(this.btnExportXMLToCSV_Click);
            // 
            // txtXML
            // 
            this.txtXML.Location = new System.Drawing.Point(169, 12);
            this.txtXML.Multiline = true;
            this.txtXML.Name = "txtXML";
            this.txtXML.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtXML.Size = new System.Drawing.Size(619, 426);
            this.txtXML.TabIndex = 2;
            this.txtXML.Leave += new System.EventHandler(this.txtXML_Leave);
            // 
            // txtInstructions
            // 
            this.txtInstructions.BackColor = System.Drawing.SystemColors.Info;
            this.txtInstructions.Location = new System.Drawing.Point(13, 94);
            this.txtInstructions.Multiline = true;
            this.txtInstructions.Name = "txtInstructions";
            this.txtInstructions.ReadOnly = true;
            this.txtInstructions.Size = new System.Drawing.Size(151, 344);
            this.txtInstructions.TabIndex = 3;
            this.txtInstructions.Text = "Select XML from a file or add it to the text box manually. If the XML is properly" +
    " formed and contains valid records, the export button will be enabled. Export to" +
    " save the valid records to a CSV file.";
            // 
            // frmXMLParser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtInstructions);
            this.Controls.Add(this.txtXML);
            this.Controls.Add(this.btnExportXMLToCSV);
            this.Controls.Add(this.btnSelectXMLFromFile);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmXMLParser";
            this.Text = "XML Parser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog dlgSelectXML;
        private System.Windows.Forms.Button btnSelectXMLFromFile;
        private System.Windows.Forms.Button btnExportXMLToCSV;
        private System.Windows.Forms.TextBox txtXML;
        private System.Windows.Forms.TextBox txtInstructions;
    }
}

