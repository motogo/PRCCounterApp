namespace GuideTech
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Data.DataTable dataTable1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.colID = new System.Data.DataColumn();
            this.colSTAMP = new System.Data.DataColumn();
            this.colDATASTAMP = new System.Data.DataColumn();
            this.colVALUE = new System.Data.DataColumn();
            this.colINFO = new System.Data.DataColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.txtResultIsMaster = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtResultBoardModel = new System.Windows.Forms.TextBox();
            this.txtResultSerial = new System.Windows.Forms.TextBox();
            this.btnSerialNumber = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtResultInitialize = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.txtBoard = new System.Windows.Forms.TextBox();
            this.txtSleep = new System.Windows.Forms.TextBox();
            this.gbSleep = new System.Windows.Forms.GroupBox();
            this.gbNumTags0 = new System.Windows.Forms.GroupBox();
            this.txtNumTags0 = new System.Windows.Forms.TextBox();
            this.gbLoops = new System.Windows.Forms.GroupBox();
            this.txtLoops = new System.Windows.Forms.TextBox();
            this.hsAssignLoops = new SeControlsLib.HotSpot();
            this.button8 = new System.Windows.Forms.Button();
            this.txtMeasInput = new System.Windows.Forms.TextBox();
            this.txtDriver = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtErrorBoardRevision = new System.Windows.Forms.TextBox();
            this.btnBoardRevision = new System.Windows.Forms.Button();
            this.txtResultBoardRevision = new System.Windows.Forms.TextBox();
            this.btnSystemCLose = new System.Windows.Forms.Button();
            this.btnRecreateAPI = new System.Windows.Forms.Button();
            this.btnCloseDevice = new System.Windows.Forms.Button();
            this.txtResultCloseDevice = new System.Windows.Forms.TextBox();
            this.lblBoardIsInit = new System.Windows.Forms.Label();
            this.txtIsInitDev = new System.Windows.Forms.TextBox();
            this.btnIsInit = new System.Windows.Forms.Button();
            this.txtResultIsInitDev = new System.Windows.Forms.TextBox();
            this.lblDevMaskSystemInit = new System.Windows.Forms.Label();
            this.txtSystemInitDevMask = new System.Windows.Forms.TextBox();
            this.lblDevSystemInit = new System.Windows.Forms.Label();
            this.txtSystemInitDev = new System.Windows.Forms.TextBox();
            this.btnSystemInit = new System.Windows.Forms.Button();
            this.txtResultSystemInit = new System.Windows.Forms.TextBox();
            this.lblVDeviceAssign = new System.Windows.Forms.Label();
            this.txtVirtDev = new System.Windows.Forms.TextBox();
            this.lblPhysBoardAssign = new System.Windows.Forms.Label();
            this.txtPhysBd = new System.Windows.Forms.TextBox();
            this.btnAssign = new System.Windows.Forms.Button();
            this.txtAssignResult = new System.Windows.Forms.TextBox();
            this.lblBoardInit = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblChannelInputBPos = new System.Windows.Forms.Label();
            this.lblChannelInputAPos = new System.Windows.Forms.Label();
            this.txtInputB = new System.Windows.Forms.TextBox();
            this.btnSetInputB = new System.Windows.Forms.Button();
            this.btnSetInputA = new System.Windows.Forms.Button();
            this.txtInputA = new System.Windows.Forms.TextBox();
            this.ckShowResults = new System.Windows.Forms.CheckBox();
            this.txtCh2 = new System.Windows.Forms.TextBox();
            this.ckNewMeas = new System.Windows.Forms.CheckBox();
            this.ckChannel0 = new System.Windows.Forms.CheckBox();
            this.ckChannel1 = new System.Windows.Forms.CheckBox();
            this.gbMeasSkip = new System.Windows.Forms.GroupBox();
            this.txtMeasSkipCh0 = new System.Windows.Forms.TextBox();
            this.txtMeasSkipCh1 = new System.Windows.Forms.TextBox();
            this.ckMemoryWrap = new System.Windows.Forms.CheckBox();
            this.button12 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.txtCalibrate = new System.Windows.Forms.TextBox();
            this.button10 = new System.Windows.Forms.Button();
            this.ckCal = new System.Windows.Forms.CheckBox();
            this.txtSetRealtime = new System.Windows.Forms.TextBox();
            this.btnSetRealtime = new System.Windows.Forms.Button();
            this.txtGetRealtime1 = new System.Windows.Forms.TextBox();
            this.txtGetRealtime2 = new System.Windows.Forms.TextBox();
            this.ckReadRAW = new System.Windows.Forms.CheckBox();
            this.ckTagsSucceded = new System.Windows.Forms.CheckBox();
            this.ckReadAllErrors = new System.Windows.Forms.CheckBox();
            this.lblChanneMeasinoutl = new System.Windows.Forms.Label();
            this.lblInpMeasinout = new System.Windows.Forms.Label();
            this.tabControlMeasurements = new System.Windows.Forms.TabControl();
            this.tabPageMeasurement = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.hsStop = new SeControlsLib.HotSpot();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.hs_SetFrequency_A_B = new SeControlsLib.HotSpot();
            this.hsSetFrequencyMeasurment_A = new SeControlsLib.HotSpot();
            this.hsSetPhase_A_B = new SeControlsLib.HotSpot();
            this.hsRun = new SeControlsLib.HotSpot();
            this.tabControlResultConfiguration = new System.Windows.Forms.TabControl();
            this.tabPageResults = new System.Windows.Forms.TabPage();
            this.gbMeasResults = new System.Windows.Forms.GroupBox();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.bsResults = new System.Windows.Forms.BindingSource(this.components);
            this.dsResults = new System.Data.DataSet();
            this.tabPageMeasResultsLog = new System.Windows.Forms.TabPage();
            this.rtResultLogs = new System.Windows.Forms.RichTextBox();
            this.pnlLogUpper = new System.Windows.Forms.Panel();
            this.hsSaveMeasResultsLogs = new SeControlsLib.HotSpot();
            this.cbResultLogActive = new System.Windows.Forms.CheckBox();
            this.tabPageMeasResultsErrorlog = new System.Windows.Forms.TabPage();
            this.rtResultsErrorLog = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.hsSaveMeasResultErrorLogs = new SeControlsLib.HotSpot();
            this.cbUpdateErrorLogEveryNewEntry = new System.Windows.Forms.CheckBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabPageCounterTesting = new System.Windows.Forms.TabPage();
            this.hsTestFrequency = new SeControlsLib.HotSpot();
            this.txtResultBoard = new System.Windows.Forms.TextBox();
            this.ckFirst = new System.Windows.Forms.CheckBox();
            this.txtResuldBoardError = new System.Windows.Forms.TextBox();
            this.btnGetBoard = new System.Windows.Forms.Button();
            this.ckSetClock = new System.Windows.Forms.CheckBox();
            this.txtSelectDeviceResult = new System.Windows.Forms.TextBox();
            this.txtSelectDev = new System.Windows.Forms.TextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.txtInitDefault = new System.Windows.Forms.TextBox();
            this.tabPageMeasurementConfiguration = new System.Windows.Forms.TabPage();
            this.pnlMeasconfigCenter = new System.Windows.Forms.Panel();
            this.gbUserDefinedAttributes = new System.Windows.Forms.GroupBox();
            this.gbYOffset = new System.Windows.Forms.GroupBox();
            this.txtYOffset = new System.Windows.Forms.TextBox();
            this.gbMeasinfo = new System.Windows.Forms.GroupBox();
            this.gbScaleYAxis = new System.Windows.Forms.GroupBox();
            this.txtScaleYAxis = new System.Windows.Forms.TextBox();
            this.gbGraphLegend = new System.Windows.Forms.GroupBox();
            this.txtGraphLegend = new System.Windows.Forms.TextBox();
            this.gbXLegend = new System.Windows.Forms.GroupBox();
            this.txtXLegend = new System.Windows.Forms.TextBox();
            this.gbYLegend = new System.Windows.Forms.GroupBox();
            this.txtYLegend = new System.Windows.Forms.TextBox();
            this.gbMeasinfos = new System.Windows.Forms.GroupBox();
            this.txtMeasinfo = new System.Windows.Forms.TextBox();
            this.gbMeasname = new System.Windows.Forms.GroupBox();
            this.txtMeasname = new System.Windows.Forms.TextBox();
            this.cbActualMeasConfiguration = new System.Windows.Forms.GroupBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.gbMeasconfigDevice = new System.Windows.Forms.GroupBox();
            this.cbMeasconfigDevice = new System.Windows.Forms.ComboBox();
            this.gbSleepAfterSingleRead = new System.Windows.Forms.GroupBox();
            this.txtSleepEverySingleRead = new System.Windows.Forms.TextBox();
            this.gbMeasType = new System.Windows.Forms.GroupBox();
            this.rbFrequency_A_B = new System.Windows.Forms.RadioButton();
            this.rbFrequencyA = new System.Windows.Forms.RadioButton();
            this.rbPhaseAB = new System.Windows.Forms.RadioButton();
            this.gbMeasOptions = new System.Windows.Forms.GroupBox();
            this.gbMeasGate1 = new System.Windows.Forms.GroupBox();
            this.txtMeasGate1 = new System.Windows.Forms.TextBox();
            this.gbMeasGate0 = new System.Windows.Forms.GroupBox();
            this.txtMeasGate0 = new System.Windows.Forms.TextBox();
            this.gbNumTags1 = new System.Windows.Forms.GroupBox();
            this.txtNumTags1 = new System.Windows.Forms.TextBox();
            this.gbMeasSkip1 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbClockExternFreq = new System.Windows.Forms.GroupBox();
            this.rbClock10MHZ = new System.Windows.Forms.RadioButton();
            this.rbClock5MHZ = new System.Windows.Forms.RadioButton();
            this.gbSelectClock = new System.Windows.Forms.GroupBox();
            this.rbUseInternClock = new System.Windows.Forms.RadioButton();
            this.rbClockUseExtern = new System.Windows.Forms.RadioButton();
            this.gbThresholdClock = new System.Windows.Forms.GroupBox();
            this.txtThresholdClock = new System.Windows.Forms.TextBox();
            this.gbInputs = new System.Windows.Forms.GroupBox();
            this.gbTresholdB = new System.Windows.Forms.GroupBox();
            this.txtThresholdB = new System.Windows.Forms.TextBox();
            this.gbTresholdA = new System.Windows.Forms.GroupBox();
            this.txtThresholdA = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cbPrescaleB = new System.Windows.Forms.ComboBox();
            this.gbPrescaleA = new System.Windows.Forms.GroupBox();
            this.cbPrescaleA = new System.Windows.Forms.ComboBox();
            this.gbChannelAImpedance = new System.Windows.Forms.GroupBox();
            this.rbChannelAImpedanceHIGH = new System.Windows.Forms.RadioButton();
            this.rbChannelAImpedanceLO = new System.Windows.Forms.RadioButton();
            this.gbChannelAVoltage = new System.Windows.Forms.GroupBox();
            this.rbChannelANegativeVoltage = new System.Windows.Forms.RadioButton();
            this.rbChannelAPositiveVoltage = new System.Windows.Forms.RadioButton();
            this.gbChannelBImpedance = new System.Windows.Forms.GroupBox();
            this.rbChannelBImpedanceHIGH = new System.Windows.Forms.RadioButton();
            this.rbChannelBImpedanceLO = new System.Windows.Forms.RadioButton();
            this.gbChannelBVoltage = new System.Windows.Forms.GroupBox();
            this.rbChannelBNegativeVoltage = new System.Windows.Forms.RadioButton();
            this.rbChannelBPositiveVoltage = new System.Windows.Forms.RadioButton();
            this.gbChannelBCoupling = new System.Windows.Forms.GroupBox();
            this.rbChannelBCouplingAC = new System.Windows.Forms.RadioButton();
            this.rbChannelBCouplingDC = new System.Windows.Forms.RadioButton();
            this.gbChannelACoupling = new System.Windows.Forms.GroupBox();
            this.rbChannelACouplingAC = new System.Windows.Forms.RadioButton();
            this.rbChannelACouplingDC = new System.Windows.Forms.RadioButton();
            this.pnlMeasconfigUpper = new System.Windows.Forms.Panel();
            this.gbConfigurationFile = new System.Windows.Forms.GroupBox();
            this.txtConfigurationFile = new System.Windows.Forms.TextBox();
            this.hsLoadConfigurationFile = new SeControlsLib.HotSpot();
            this.hsSaveMeasconfiguration = new SeControlsLib.HotSpot();
            this.gbMeasPathAndFormats = new System.Windows.Forms.GroupBox();
            this.gbDatasource = new System.Windows.Forms.GroupBox();
            this.rbTimeAnalyzerFile = new System.Windows.Forms.RadioButton();
            this.rbAVARFile = new System.Windows.Forms.RadioButton();
            this.rbResultLiteDB = new System.Windows.Forms.RadioButton();
            this.rbResultFile = new System.Windows.Forms.RadioButton();
            this.ckMeasResultDefinitionActive = new System.Windows.Forms.CheckBox();
            this.gbResultName = new System.Windows.Forms.GroupBox();
            this.txtMeasResultDefinitionFilePattern = new System.Windows.Forms.TextBox();
            this.hsRemoveMeasResultDefinition = new SeControlsLib.HotSpot();
            this.hsUpdateMeasResultDefinition = new SeControlsLib.HotSpot();
            this.hsAddMeasResultDefinition = new SeControlsLib.HotSpot();
            this.gbMeasResultFormat = new System.Windows.Forms.GroupBox();
            this.txtMeasResultDefinitionFormat = new System.Windows.Forms.TextBox();
            this.gbMeasresultPath = new System.Windows.Forms.GroupBox();
            this.txtMeasResultDefinitionPath = new System.Windows.Forms.TextBox();
            this.hsMeasPath = new SeControlsLib.HotSpot();
            this.dgvMeasResultConfiguration = new System.Windows.Forms.DataGridView();
            this.outdefID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outdefFILEPATTERN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outdefPATH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outdefFORMAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outdefACTIVE = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.outdefDATASOURCE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsOutputDefinition = new System.Windows.Forms.BindingSource(this.components);
            this.dsOutputDefintion = new System.Data.DataSet();
            this.dataTable2 = new System.Data.DataTable();
            this.col_outdefID = new System.Data.DataColumn();
            this.col_outdefPATH = new System.Data.DataColumn();
            this.col_outdefFORMAT = new System.Data.DataColumn();
            this.col_outdefACTIVE = new System.Data.DataColumn();
            this.col_outdefFILEPATTERN = new System.Data.DataColumn();
            this.dataColumn1 = new System.Data.DataColumn();
            this.tabPageMeasFiles = new System.Windows.Forms.TabPage();
            this.pnlMeasResultsCenter = new System.Windows.Forms.Panel();
            this.gbFileInfos = new System.Windows.Forms.GroupBox();
            this.spcResultFiles = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFileCreate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFileSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbDatafile = new System.Windows.Forms.GroupBox();
            this.rtbDataFile = new System.Windows.Forms.RichTextBox();
            this.gbHeaderfile = new System.Windows.Forms.GroupBox();
            this.rtbHeaderfile = new System.Windows.Forms.RichTextBox();
            this.pnlResultfilesLeft = new System.Windows.Forms.Panel();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.gbMeasAttMeasOffset = new System.Windows.Forms.GroupBox();
            this.txtMeasAttMeasOffset = new System.Windows.Forms.TextBox();
            this.gbMeasAttEndtime = new System.Windows.Forms.GroupBox();
            this.txtMeasAttEndtime = new System.Windows.Forms.TextBox();
            this.gbMeasAttStarttime = new System.Windows.Forms.GroupBox();
            this.txtMeasAttStarttime = new System.Windows.Forms.TextBox();
            this.gbMeasAttStartdate = new System.Windows.Forms.GroupBox();
            this.txtMeasAttStartdate = new System.Windows.Forms.TextBox();
            this.gbMeasAttMeasDevice = new System.Windows.Forms.GroupBox();
            this.txtMeasAttMeasDevice = new System.Windows.Forms.TextBox();
            this.gbMeasAttScaleYAxis = new System.Windows.Forms.GroupBox();
            this.txtMeasAttScaleYAxis = new System.Windows.Forms.TextBox();
            this.gbMeasAttGraph = new System.Windows.Forms.GroupBox();
            this.txtMeasAttGraphLegend = new System.Windows.Forms.TextBox();
            this.gbMeasAttXLegend = new System.Windows.Forms.GroupBox();
            this.txtMeasAttXLegend = new System.Windows.Forms.TextBox();
            this.gbMeasAttYLegend = new System.Windows.Forms.GroupBox();
            this.txtMeasAttYLegend = new System.Windows.Forms.TextBox();
            this.gbMeasAttMeasName = new System.Windows.Forms.GroupBox();
            this.txtMeasAttMeasName = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.hsMakeHeader = new SeControlsLib.HotSpot();
            this.hsRunGraph = new SeControlsLib.HotSpot();
            this.cbUseHeaderfile = new System.Windows.Forms.CheckBox();
            this.gbStatistikType = new System.Windows.Forms.GroupBox();
            this.ckMDEV = new System.Windows.Forms.CheckBox();
            this.hsShowGraphStatistik = new SeControlsLib.HotSpot();
            this.ckOADEV = new System.Windows.Forms.CheckBox();
            this.ckADEV = new System.Windows.Forms.CheckBox();
            this.ckTDEV = new System.Windows.Forms.CheckBox();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.gbOutliers = new System.Windows.Forms.GroupBox();
            this.hotSpot1 = new SeControlsLib.HotSpot();
            this.hsOutliers3 = new SeControlsLib.HotSpot();
            this.hsOutliers6 = new SeControlsLib.HotSpot();
            this.hsOutlier9 = new SeControlsLib.HotSpot();
            this.txtOutliers = new System.Windows.Forms.TextBox();
            this.flpResults = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.hotSpot2 = new SeControlsLib.HotSpot();
            this.txtFilesPath = new System.Windows.Forms.TextBox();
            this.hsRefreshFiles = new SeControlsLib.HotSpot();
            this.tabPageAppConfiguration = new System.Windows.Forms.TabPage();
            this.xmlEditSimpleUserControl1 = new XMLSimlpeEdit.XMLEditSimpleUserControl();
            this.tabPageAppLog = new System.Windows.Forms.TabPage();
            this.rtbAppLog = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.hotSpot3 = new SeControlsLib.HotSpot();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.ckDebugmode = new System.Windows.Forms.CheckBox();
            this.pnlUpper = new System.Windows.Forms.Panel();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtActConfigurationFile = new System.Windows.Forms.TextBox();
            this.hsCloseApp = new SeControlsLib.HotSpot();
            this.gbActCommand = new System.Windows.Forms.GroupBox();
            this.txtActInfo = new System.Windows.Forms.TextBox();
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.ofdLoadConfiguration = new System.Windows.Forms.OpenFileDialog();
            this.sfdMeasconfiguration = new System.Windows.Forms.SaveFileDialog();
            this.sfdLogs = new System.Windows.Forms.SaveFileDialog();
            this.fbdResultFiles = new System.Windows.Forms.FolderBrowserDialog();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STAMP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATASTAMP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALUE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INFO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataTable1 = new System.Data.DataTable();
            ((System.ComponentModel.ISupportInitialize)(dataTable1)).BeginInit();
            this.gbSleep.SuspendLayout();
            this.gbNumTags0.SuspendLayout();
            this.gbLoops.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbMeasSkip.SuspendLayout();
            this.tabControlMeasurements.SuspendLayout();
            this.tabPageMeasurement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabControlResultConfiguration.SuspendLayout();
            this.tabPageResults.SuspendLayout();
            this.gbMeasResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsResults)).BeginInit();
            this.tabPageMeasResultsLog.SuspendLayout();
            this.pnlLogUpper.SuspendLayout();
            this.tabPageMeasResultsErrorlog.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPageCounterTesting.SuspendLayout();
            this.tabPageMeasurementConfiguration.SuspendLayout();
            this.pnlMeasconfigCenter.SuspendLayout();
            this.gbUserDefinedAttributes.SuspendLayout();
            this.gbYOffset.SuspendLayout();
            this.gbMeasinfo.SuspendLayout();
            this.gbScaleYAxis.SuspendLayout();
            this.gbGraphLegend.SuspendLayout();
            this.gbXLegend.SuspendLayout();
            this.gbYLegend.SuspendLayout();
            this.gbMeasinfos.SuspendLayout();
            this.gbMeasname.SuspendLayout();
            this.cbActualMeasConfiguration.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.gbMeasconfigDevice.SuspendLayout();
            this.gbSleepAfterSingleRead.SuspendLayout();
            this.gbMeasType.SuspendLayout();
            this.gbMeasOptions.SuspendLayout();
            this.gbMeasGate1.SuspendLayout();
            this.gbMeasGate0.SuspendLayout();
            this.gbNumTags1.SuspendLayout();
            this.gbMeasSkip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbClockExternFreq.SuspendLayout();
            this.gbSelectClock.SuspendLayout();
            this.gbThresholdClock.SuspendLayout();
            this.gbInputs.SuspendLayout();
            this.gbTresholdB.SuspendLayout();
            this.gbTresholdA.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.gbPrescaleA.SuspendLayout();
            this.gbChannelAImpedance.SuspendLayout();
            this.gbChannelAVoltage.SuspendLayout();
            this.gbChannelBImpedance.SuspendLayout();
            this.gbChannelBVoltage.SuspendLayout();
            this.gbChannelBCoupling.SuspendLayout();
            this.gbChannelACoupling.SuspendLayout();
            this.pnlMeasconfigUpper.SuspendLayout();
            this.gbConfigurationFile.SuspendLayout();
            this.gbMeasPathAndFormats.SuspendLayout();
            this.gbDatasource.SuspendLayout();
            this.gbResultName.SuspendLayout();
            this.gbMeasResultFormat.SuspendLayout();
            this.gbMeasresultPath.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeasResultConfiguration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOutputDefinition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOutputDefintion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2)).BeginInit();
            this.tabPageMeasFiles.SuspendLayout();
            this.pnlMeasResultsCenter.SuspendLayout();
            this.gbFileInfos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcResultFiles)).BeginInit();
            this.spcResultFiles.Panel1.SuspendLayout();
            this.spcResultFiles.Panel2.SuspendLayout();
            this.spcResultFiles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbDatafile.SuspendLayout();
            this.gbHeaderfile.SuspendLayout();
            this.pnlResultfilesLeft.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.gbMeasAttMeasOffset.SuspendLayout();
            this.gbMeasAttEndtime.SuspendLayout();
            this.gbMeasAttStarttime.SuspendLayout();
            this.gbMeasAttStartdate.SuspendLayout();
            this.gbMeasAttMeasDevice.SuspendLayout();
            this.gbMeasAttScaleYAxis.SuspendLayout();
            this.gbMeasAttGraph.SuspendLayout();
            this.gbMeasAttXLegend.SuspendLayout();
            this.gbMeasAttYLegend.SuspendLayout();
            this.gbMeasAttMeasName.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.gbStatistikType.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.gbOutliers.SuspendLayout();
            this.flpResults.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tabPageAppConfiguration.SuspendLayout();
            this.tabPageAppLog.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlUpper.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.gbActCommand.SuspendLayout();
            this.pnlCenter.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataTable1
            // 
            dataTable1.Columns.AddRange(new System.Data.DataColumn[] {
            this.colID,
            this.colSTAMP,
            this.colDATASTAMP,
            this.colVALUE,
            this.colINFO});
            dataTable1.TableName = "Table1";
            // 
            // colID
            // 
            this.colID.Caption = "ID";
            this.colID.ColumnName = "ID";
            this.colID.DataType = typeof(System.Guid);
            // 
            // colSTAMP
            // 
            this.colSTAMP.ColumnName = "STAMP";
            this.colSTAMP.DataType = typeof(System.DateTime);
            // 
            // colDATASTAMP
            // 
            this.colDATASTAMP.ColumnName = "DATASTAMP";
            this.colDATASTAMP.DataType = typeof(double);
            // 
            // colVALUE
            // 
            this.colVALUE.ColumnName = "VALUE";
            this.colVALUE.DataType = typeof(double);
            // 
            // colINFO
            // 
            this.colINFO.ColumnName = "INFO";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 429);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "IsMaster";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnIsMaster_Click);
            // 
            // txtResultIsMaster
            // 
            this.txtResultIsMaster.Location = new System.Drawing.Point(113, 431);
            this.txtResultIsMaster.Name = "txtResultIsMaster";
            this.txtResultIsMaster.Size = new System.Drawing.Size(295, 20);
            this.txtResultIsMaster.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(32, 455);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Model";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnGetBoardModel_Click);
            // 
            // txtResultBoardModel
            // 
            this.txtResultBoardModel.Location = new System.Drawing.Point(113, 457);
            this.txtResultBoardModel.Name = "txtResultBoardModel";
            this.txtResultBoardModel.Size = new System.Drawing.Size(295, 20);
            this.txtResultBoardModel.TabIndex = 3;
            // 
            // txtResultSerial
            // 
            this.txtResultSerial.Location = new System.Drawing.Point(113, 544);
            this.txtResultSerial.Name = "txtResultSerial";
            this.txtResultSerial.Size = new System.Drawing.Size(295, 20);
            this.txtResultSerial.TabIndex = 5;
            // 
            // btnSerialNumber
            // 
            this.btnSerialNumber.Location = new System.Drawing.Point(32, 542);
            this.btnSerialNumber.Name = "btnSerialNumber";
            this.btnSerialNumber.Size = new System.Drawing.Size(75, 23);
            this.btnSerialNumber.TabIndex = 4;
            this.btnSerialNumber.Text = "Serial";
            this.btnSerialNumber.UseVisualStyleBackColor = true;
            this.btnSerialNumber.Click += new System.EventHandler(this.btnGetSerial_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 119);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Init";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btnInitialize_Click);
            // 
            // txtResultInitialize
            // 
            this.txtResultInitialize.Location = new System.Drawing.Point(163, 121);
            this.txtResultInitialize.Name = "txtResultInitialize";
            this.txtResultInitialize.Size = new System.Drawing.Size(328, 20);
            this.txtResultInitialize.TabIndex = 7;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(21, 18);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 8;
            this.button5.Text = "Init Default";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.btnInitDefault_Click);
            // 
            // txtBoard
            // 
            this.txtBoard.Location = new System.Drawing.Point(127, 121);
            this.txtBoard.Name = "txtBoard";
            this.txtBoard.Size = new System.Drawing.Size(18, 20);
            this.txtBoard.TabIndex = 10;
            this.txtBoard.Text = "0";
            // 
            // txtSleep
            // 
            this.txtSleep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSleep.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSleep.Location = new System.Drawing.Point(3, 16);
            this.txtSleep.Name = "txtSleep";
            this.txtSleep.Size = new System.Drawing.Size(126, 22);
            this.txtSleep.TabIndex = 13;
            this.txtSleep.Text = "880";
            this.txtSleep.TextChanged += new System.EventHandler(this.txtSleep_TextChanged);
            // 
            // gbSleep
            // 
            this.gbSleep.Controls.Add(this.txtSleep);
            this.gbSleep.Location = new System.Drawing.Point(401, 98);
            this.gbSleep.Name = "gbSleep";
            this.gbSleep.Size = new System.Drawing.Size(132, 38);
            this.gbSleep.TabIndex = 14;
            this.gbSleep.TabStop = false;
            this.gbSleep.Text = "Sleep every loop (ms)";
            // 
            // gbNumTags0
            // 
            this.gbNumTags0.Controls.Add(this.txtNumTags0);
            this.gbNumTags0.Location = new System.Drawing.Point(9, 19);
            this.gbNumTags0.Name = "gbNumTags0";
            this.gbNumTags0.Size = new System.Drawing.Size(76, 38);
            this.gbNumTags0.TabIndex = 15;
            this.gbNumTags0.TabStop = false;
            this.gbNumTags0.Text = "NumTags 0";
            // 
            // txtNumTags0
            // 
            this.txtNumTags0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNumTags0.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumTags0.Location = new System.Drawing.Point(3, 16);
            this.txtNumTags0.Name = "txtNumTags0";
            this.txtNumTags0.Size = new System.Drawing.Size(70, 22);
            this.txtNumTags0.TabIndex = 13;
            this.txtNumTags0.Text = "1";
            // 
            // gbLoops
            // 
            this.gbLoops.Controls.Add(this.txtLoops);
            this.gbLoops.Controls.Add(this.hsAssignLoops);
            this.gbLoops.Location = new System.Drawing.Point(192, 22);
            this.gbLoops.Name = "gbLoops";
            this.gbLoops.Size = new System.Drawing.Size(95, 37);
            this.gbLoops.TabIndex = 16;
            this.gbLoops.TabStop = false;
            this.gbLoops.Text = "Loops";
            // 
            // txtLoops
            // 
            this.txtLoops.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLoops.Location = new System.Drawing.Point(3, 16);
            this.txtLoops.Name = "txtLoops";
            this.txtLoops.Size = new System.Drawing.Size(58, 20);
            this.txtLoops.TabIndex = 13;
            this.txtLoops.Text = "0";
            // 
            // hsAssignLoops
            // 
            this.hsAssignLoops.BackColor = System.Drawing.Color.Transparent;
            this.hsAssignLoops.BackColorHover = System.Drawing.Color.Transparent;
            this.hsAssignLoops.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsAssignLoops.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsAssignLoops.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsAssignLoops.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsAssignLoops.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsAssignLoops.Dock = System.Windows.Forms.DockStyle.Right;
            this.hsAssignLoops.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.hsAssignLoops.FlatAppearance.BorderSize = 0;
            this.hsAssignLoops.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsAssignLoops.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsAssignLoops.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsAssignLoops.Image = global::PRCCounterApp.Properties.Resources.media_playlist_repeat_blue_x22;
            this.hsAssignLoops.ImageHover = global::PRCCounterApp.Properties.Resources.media_playlist_repeat_x22;
            this.hsAssignLoops.ImageToggleOnSelect = true;
            this.hsAssignLoops.Location = new System.Drawing.Point(61, 16);
            this.hsAssignLoops.Marked = false;
            this.hsAssignLoops.MarkedColor = System.Drawing.Color.Teal;
            this.hsAssignLoops.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsAssignLoops.MarkedText = "";
            this.hsAssignLoops.MarkMode = false;
            this.hsAssignLoops.Name = "hsAssignLoops";
            this.hsAssignLoops.NonMarkedText = "";
            this.hsAssignLoops.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsAssignLoops.ShowShortcut = false;
            this.hsAssignLoops.Size = new System.Drawing.Size(31, 18);
            this.hsAssignLoops.TabIndex = 46;
            this.hsAssignLoops.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsAssignLoops.ToolTipActive = false;
            this.hsAssignLoops.ToolTipAutomaticDelay = 500;
            this.hsAssignLoops.ToolTipAutoPopDelay = 5000;
            this.hsAssignLoops.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsAssignLoops.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsAssignLoops.ToolTipFor4ContextMenu = true;
            this.hsAssignLoops.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsAssignLoops.ToolTipInitialDelay = 500;
            this.hsAssignLoops.ToolTipIsBallon = false;
            this.hsAssignLoops.ToolTipOwnerDraw = false;
            this.hsAssignLoops.ToolTipReshowDelay = 100;
            this.hsAssignLoops.ToolTipShowAlways = false;
            this.hsAssignLoops.ToolTipText = "";
            this.hsAssignLoops.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsAssignLoops.ToolTipTitle = "";
            this.hsAssignLoops.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsAssignLoops.UseVisualStyleBackColor = false;
            this.hsAssignLoops.Click += new System.EventHandler(this.hsAssignLoops_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(32, 603);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(105, 23);
            this.button8.TabIndex = 17;
            this.button8.Text = "Get Meas Input";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.BetGetMeasInput_Click);
            // 
            // txtMeasInput
            // 
            this.txtMeasInput.Location = new System.Drawing.Point(244, 605);
            this.txtMeasInput.Name = "txtMeasInput";
            this.txtMeasInput.Size = new System.Drawing.Size(78, 20);
            this.txtMeasInput.TabIndex = 18;
            // 
            // txtDriver
            // 
            this.txtDriver.Location = new System.Drawing.Point(113, 485);
            this.txtDriver.Name = "txtDriver";
            this.txtDriver.Size = new System.Drawing.Size(295, 20);
            this.txtDriver.TabIndex = 20;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(32, 484);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 19;
            this.button9.Text = "Driver";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.btnGetDriverVersion_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtErrorBoardRevision);
            this.groupBox2.Controls.Add(this.btnBoardRevision);
            this.groupBox2.Controls.Add(this.txtResultBoardRevision);
            this.groupBox2.Controls.Add(this.btnSystemCLose);
            this.groupBox2.Controls.Add(this.btnRecreateAPI);
            this.groupBox2.Controls.Add(this.btnCloseDevice);
            this.groupBox2.Controls.Add(this.txtResultCloseDevice);
            this.groupBox2.Controls.Add(this.lblBoardIsInit);
            this.groupBox2.Controls.Add(this.txtIsInitDev);
            this.groupBox2.Controls.Add(this.btnIsInit);
            this.groupBox2.Controls.Add(this.txtResultIsInitDev);
            this.groupBox2.Controls.Add(this.lblDevMaskSystemInit);
            this.groupBox2.Controls.Add(this.txtSystemInitDevMask);
            this.groupBox2.Controls.Add(this.lblDevSystemInit);
            this.groupBox2.Controls.Add(this.txtSystemInitDev);
            this.groupBox2.Controls.Add(this.btnSystemInit);
            this.groupBox2.Controls.Add(this.txtResultSystemInit);
            this.groupBox2.Controls.Add(this.lblVDeviceAssign);
            this.groupBox2.Controls.Add(this.txtVirtDev);
            this.groupBox2.Controls.Add(this.lblPhysBoardAssign);
            this.groupBox2.Controls.Add(this.txtPhysBd);
            this.groupBox2.Controls.Add(this.btnAssign);
            this.groupBox2.Controls.Add(this.txtAssignResult);
            this.groupBox2.Controls.Add(this.lblBoardInit);
            this.groupBox2.Controls.Add(this.txtBoard);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.txtResultInitialize);
            this.groupBox2.Location = new System.Drawing.Point(21, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(498, 213);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Board";
            // 
            // txtErrorBoardRevision
            // 
            this.txtErrorBoardRevision.Location = new System.Drawing.Point(352, 22);
            this.txtErrorBoardRevision.Name = "txtErrorBoardRevision";
            this.txtErrorBoardRevision.Size = new System.Drawing.Size(102, 20);
            this.txtErrorBoardRevision.TabIndex = 34;
            // 
            // btnBoardRevision
            // 
            this.btnBoardRevision.Location = new System.Drawing.Point(127, 19);
            this.btnBoardRevision.Name = "btnBoardRevision";
            this.btnBoardRevision.Size = new System.Drawing.Size(111, 23);
            this.btnBoardRevision.TabIndex = 33;
            this.btnBoardRevision.Text = "Board Revision";
            this.btnBoardRevision.UseVisualStyleBackColor = true;
            this.btnBoardRevision.Click += new System.EventHandler(this.btnBoardRevision_Click);
            // 
            // txtResultBoardRevision
            // 
            this.txtResultBoardRevision.Location = new System.Drawing.Point(244, 21);
            this.txtResultBoardRevision.Name = "txtResultBoardRevision";
            this.txtResultBoardRevision.Size = new System.Drawing.Size(102, 20);
            this.txtResultBoardRevision.TabIndex = 32;
            // 
            // btnSystemCLose
            // 
            this.btnSystemCLose.Location = new System.Drawing.Point(82, 177);
            this.btnSystemCLose.Name = "btnSystemCLose";
            this.btnSystemCLose.Size = new System.Drawing.Size(75, 23);
            this.btnSystemCLose.TabIndex = 31;
            this.btnSystemCLose.Text = "Sys Close";
            this.btnSystemCLose.UseVisualStyleBackColor = true;
            this.btnSystemCLose.Click += new System.EventHandler(this.btnSystemCLose_Click);
            // 
            // btnRecreateAPI
            // 
            this.btnRecreateAPI.Location = new System.Drawing.Point(6, 19);
            this.btnRecreateAPI.Name = "btnRecreateAPI";
            this.btnRecreateAPI.Size = new System.Drawing.Size(75, 23);
            this.btnRecreateAPI.TabIndex = 30;
            this.btnRecreateAPI.Text = "Recreate API";
            this.btnRecreateAPI.UseVisualStyleBackColor = true;
            this.btnRecreateAPI.Click += new System.EventHandler(this.btnRecreateAPI_Click);
            // 
            // btnCloseDevice
            // 
            this.btnCloseDevice.Location = new System.Drawing.Point(6, 177);
            this.btnCloseDevice.Name = "btnCloseDevice";
            this.btnCloseDevice.Size = new System.Drawing.Size(75, 23);
            this.btnCloseDevice.TabIndex = 28;
            this.btnCloseDevice.Text = "Close";
            this.btnCloseDevice.UseVisualStyleBackColor = true;
            this.btnCloseDevice.Click += new System.EventHandler(this.btnCloseDevice_Click);
            // 
            // txtResultCloseDevice
            // 
            this.txtResultCloseDevice.Location = new System.Drawing.Point(163, 179);
            this.txtResultCloseDevice.Name = "txtResultCloseDevice";
            this.txtResultCloseDevice.Size = new System.Drawing.Size(328, 20);
            this.txtResultCloseDevice.TabIndex = 29;
            // 
            // lblBoardIsInit
            // 
            this.lblBoardIsInit.AutoSize = true;
            this.lblBoardIsInit.Location = new System.Drawing.Point(87, 153);
            this.lblBoardIsInit.Name = "lblBoardIsInit";
            this.lblBoardIsInit.Size = new System.Drawing.Size(35, 13);
            this.lblBoardIsInit.TabIndex = 27;
            this.lblBoardIsInit.Text = "Board";
            // 
            // txtIsInitDev
            // 
            this.txtIsInitDev.Location = new System.Drawing.Point(127, 150);
            this.txtIsInitDev.Name = "txtIsInitDev";
            this.txtIsInitDev.Size = new System.Drawing.Size(18, 20);
            this.txtIsInitDev.TabIndex = 26;
            this.txtIsInitDev.Text = "0";
            // 
            // btnIsInit
            // 
            this.btnIsInit.Location = new System.Drawing.Point(6, 148);
            this.btnIsInit.Name = "btnIsInit";
            this.btnIsInit.Size = new System.Drawing.Size(75, 23);
            this.btnIsInit.TabIndex = 24;
            this.btnIsInit.Text = "Is Init";
            this.btnIsInit.UseVisualStyleBackColor = true;
            this.btnIsInit.Click += new System.EventHandler(this.btnIsInit_Click);
            // 
            // txtResultIsInitDev
            // 
            this.txtResultIsInitDev.Location = new System.Drawing.Point(163, 150);
            this.txtResultIsInitDev.Name = "txtResultIsInitDev";
            this.txtResultIsInitDev.Size = new System.Drawing.Size(328, 20);
            this.txtResultIsInitDev.TabIndex = 25;
            // 
            // lblDevMaskSystemInit
            // 
            this.lblDevMaskSystemInit.AutoSize = true;
            this.lblDevMaskSystemInit.Location = new System.Drawing.Point(154, 69);
            this.lblDevMaskSystemInit.Name = "lblDevMaskSystemInit";
            this.lblDevMaskSystemInit.Size = new System.Drawing.Size(53, 13);
            this.lblDevMaskSystemInit.TabIndex = 23;
            this.lblDevMaskSystemInit.Text = "DevMask";
            // 
            // txtSystemInitDevMask
            // 
            this.txtSystemInitDevMask.Location = new System.Drawing.Point(212, 66);
            this.txtSystemInitDevMask.Name = "txtSystemInitDevMask";
            this.txtSystemInitDevMask.Size = new System.Drawing.Size(18, 20);
            this.txtSystemInitDevMask.TabIndex = 22;
            this.txtSystemInitDevMask.Text = "0";
            // 
            // lblDevSystemInit
            // 
            this.lblDevSystemInit.AutoSize = true;
            this.lblDevSystemInit.Location = new System.Drawing.Point(87, 68);
            this.lblDevSystemInit.Name = "lblDevSystemInit";
            this.lblDevSystemInit.Size = new System.Drawing.Size(27, 13);
            this.lblDevSystemInit.TabIndex = 21;
            this.lblDevSystemInit.Text = "Dev";
            // 
            // txtSystemInitDev
            // 
            this.txtSystemInitDev.Location = new System.Drawing.Point(135, 66);
            this.txtSystemInitDev.Name = "txtSystemInitDev";
            this.txtSystemInitDev.Size = new System.Drawing.Size(18, 20);
            this.txtSystemInitDev.TabIndex = 20;
            this.txtSystemInitDev.Text = "0";
            // 
            // btnSystemInit
            // 
            this.btnSystemInit.Location = new System.Drawing.Point(6, 63);
            this.btnSystemInit.Name = "btnSystemInit";
            this.btnSystemInit.Size = new System.Drawing.Size(75, 23);
            this.btnSystemInit.TabIndex = 18;
            this.btnSystemInit.Text = "System Init";
            this.btnSystemInit.UseVisualStyleBackColor = true;
            this.btnSystemInit.Click += new System.EventHandler(this.btnSystemInit_Click);
            // 
            // txtResultSystemInit
            // 
            this.txtResultSystemInit.Location = new System.Drawing.Point(251, 65);
            this.txtResultSystemInit.Name = "txtResultSystemInit";
            this.txtResultSystemInit.Size = new System.Drawing.Size(240, 20);
            this.txtResultSystemInit.TabIndex = 19;
            // 
            // lblVDeviceAssign
            // 
            this.lblVDeviceAssign.AutoSize = true;
            this.lblVDeviceAssign.Location = new System.Drawing.Point(154, 98);
            this.lblVDeviceAssign.Name = "lblVDeviceAssign";
            this.lblVDeviceAssign.Size = new System.Drawing.Size(48, 13);
            this.lblVDeviceAssign.TabIndex = 17;
            this.lblVDeviceAssign.Text = "VDevice";
            // 
            // txtVirtDev
            // 
            this.txtVirtDev.Location = new System.Drawing.Point(212, 95);
            this.txtVirtDev.Name = "txtVirtDev";
            this.txtVirtDev.Size = new System.Drawing.Size(18, 20);
            this.txtVirtDev.TabIndex = 16;
            this.txtVirtDev.Text = "0";
            // 
            // lblPhysBoardAssign
            // 
            this.lblPhysBoardAssign.AutoSize = true;
            this.lblPhysBoardAssign.Location = new System.Drawing.Point(87, 97);
            this.lblPhysBoardAssign.Name = "lblPhysBoardAssign";
            this.lblPhysBoardAssign.Size = new System.Drawing.Size(42, 13);
            this.lblPhysBoardAssign.TabIndex = 15;
            this.lblPhysBoardAssign.Text = "PBoard";
            // 
            // txtPhysBd
            // 
            this.txtPhysBd.Location = new System.Drawing.Point(135, 95);
            this.txtPhysBd.Name = "txtPhysBd";
            this.txtPhysBd.Size = new System.Drawing.Size(18, 20);
            this.txtPhysBd.TabIndex = 14;
            this.txtPhysBd.Text = "0";
            // 
            // btnAssign
            // 
            this.btnAssign.Location = new System.Drawing.Point(6, 92);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(75, 23);
            this.btnAssign.TabIndex = 12;
            this.btnAssign.Text = "Assign";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // txtAssignResult
            // 
            this.txtAssignResult.Location = new System.Drawing.Point(251, 94);
            this.txtAssignResult.Name = "txtAssignResult";
            this.txtAssignResult.Size = new System.Drawing.Size(240, 20);
            this.txtAssignResult.TabIndex = 13;
            // 
            // lblBoardInit
            // 
            this.lblBoardInit.AutoSize = true;
            this.lblBoardInit.Location = new System.Drawing.Point(87, 124);
            this.lblBoardInit.Name = "lblBoardInit";
            this.lblBoardInit.Size = new System.Drawing.Size(35, 13);
            this.lblBoardInit.TabIndex = 11;
            this.lblBoardInit.Text = "Board";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblChannelInputBPos);
            this.groupBox3.Controls.Add(this.lblChannelInputAPos);
            this.groupBox3.Controls.Add(this.txtInputB);
            this.groupBox3.Controls.Add(this.btnSetInputB);
            this.groupBox3.Controls.Add(this.btnSetInputA);
            this.groupBox3.Controls.Add(this.txtInputA);
            this.groupBox3.Location = new System.Drawing.Point(25, 300);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(265, 68);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Measurement Channel assingment";
            // 
            // lblChannelInputBPos
            // 
            this.lblChannelInputBPos.AutoSize = true;
            this.lblChannelInputBPos.Location = new System.Drawing.Point(187, 44);
            this.lblChannelInputBPos.Name = "lblChannelInputBPos";
            this.lblChannelInputBPos.Size = new System.Drawing.Size(20, 13);
            this.lblChannelInputBPos.TabIndex = 46;
            this.lblChannelInputBPos.Text = "Ch";
            // 
            // lblChannelInputAPos
            // 
            this.lblChannelInputAPos.AutoSize = true;
            this.lblChannelInputAPos.Location = new System.Drawing.Point(187, 18);
            this.lblChannelInputAPos.Name = "lblChannelInputAPos";
            this.lblChannelInputAPos.Size = new System.Drawing.Size(20, 13);
            this.lblChannelInputAPos.TabIndex = 46;
            this.lblChannelInputAPos.Text = "Ch";
            // 
            // txtInputB
            // 
            this.txtInputB.Location = new System.Drawing.Point(212, 41);
            this.txtInputB.Name = "txtInputB";
            this.txtInputB.Size = new System.Drawing.Size(27, 20);
            this.txtInputB.TabIndex = 11;
            this.txtInputB.Text = "1";
            // 
            // btnSetInputB
            // 
            this.btnSetInputB.Location = new System.Drawing.Point(6, 39);
            this.btnSetInputB.Name = "btnSetInputB";
            this.btnSetInputB.Size = new System.Drawing.Size(175, 23);
            this.btnSetInputB.TabIndex = 10;
            this.btnSetInputB.Text = "Set Channel to Input B-Pos";
            this.btnSetInputB.UseVisualStyleBackColor = true;
            this.btnSetInputB.Click += new System.EventHandler(this.btnSetInputB_Click);
            // 
            // btnSetInputA
            // 
            this.btnSetInputA.Location = new System.Drawing.Point(6, 12);
            this.btnSetInputA.Name = "btnSetInputA";
            this.btnSetInputA.Size = new System.Drawing.Size(175, 23);
            this.btnSetInputA.TabIndex = 9;
            this.btnSetInputA.Text = "Set Channel to Input A-Pos";
            this.btnSetInputA.UseVisualStyleBackColor = true;
            this.btnSetInputA.Click += new System.EventHandler(this.SetMeasInputA_Click);
            // 
            // txtInputA
            // 
            this.txtInputA.Location = new System.Drawing.Point(212, 14);
            this.txtInputA.Name = "txtInputA";
            this.txtInputA.Size = new System.Drawing.Size(27, 20);
            this.txtInputA.TabIndex = 8;
            this.txtInputA.Text = "0";
            // 
            // ckShowResults
            // 
            this.ckShowResults.AutoSize = true;
            this.ckShowResults.Checked = true;
            this.ckShowResults.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckShowResults.Location = new System.Drawing.Point(208, 98);
            this.ckShowResults.Name = "ckShowResults";
            this.ckShowResults.Size = new System.Drawing.Size(116, 17);
            this.ckShowResults.TabIndex = 23;
            this.ckShowResults.Text = "Show/Write results";
            this.ckShowResults.UseVisualStyleBackColor = true;
            // 
            // txtCh2
            // 
            this.txtCh2.Location = new System.Drawing.Point(173, 606);
            this.txtCh2.Name = "txtCh2";
            this.txtCh2.Size = new System.Drawing.Size(24, 20);
            this.txtCh2.TabIndex = 25;
            this.txtCh2.Text = "0";
            // 
            // ckNewMeas
            // 
            this.ckNewMeas.AutoSize = true;
            this.ckNewMeas.Location = new System.Drawing.Point(208, 144);
            this.ckNewMeas.Name = "ckNewMeas";
            this.ckNewMeas.Size = new System.Drawing.Size(166, 17);
            this.ckNewMeas.TabIndex = 26;
            this.ckNewMeas.Text = "New measurement every loop";
            this.ckNewMeas.UseVisualStyleBackColor = true;
            // 
            // ckChannel0
            // 
            this.ckChannel0.AutoSize = true;
            this.ckChannel0.Checked = true;
            this.ckChannel0.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckChannel0.Location = new System.Drawing.Point(8, 19);
            this.ckChannel0.Name = "ckChannel0";
            this.ckChannel0.Size = new System.Drawing.Size(115, 17);
            this.ckChannel0.TabIndex = 27;
            this.ckChannel0.Text = "Channel 0 enabled";
            this.ckChannel0.UseVisualStyleBackColor = true;
            this.ckChannel0.CheckedChanged += new System.EventHandler(this.ckChannel0_CheckedChanged);
            // 
            // ckChannel1
            // 
            this.ckChannel1.AutoSize = true;
            this.ckChannel1.Checked = true;
            this.ckChannel1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckChannel1.Location = new System.Drawing.Point(8, 42);
            this.ckChannel1.Name = "ckChannel1";
            this.ckChannel1.Size = new System.Drawing.Size(115, 17);
            this.ckChannel1.TabIndex = 28;
            this.ckChannel1.Text = "Channel 1 enabled";
            this.ckChannel1.UseVisualStyleBackColor = true;
            this.ckChannel1.CheckedChanged += new System.EventHandler(this.ckChannel1_CheckedChanged);
            // 
            // gbMeasSkip
            // 
            this.gbMeasSkip.Controls.Add(this.txtMeasSkipCh0);
            this.gbMeasSkip.Location = new System.Drawing.Point(7, 120);
            this.gbMeasSkip.Name = "gbMeasSkip";
            this.gbMeasSkip.Size = new System.Drawing.Size(84, 42);
            this.gbMeasSkip.TabIndex = 29;
            this.gbMeasSkip.TabStop = false;
            this.gbMeasSkip.Text = "Meas Skip 0";
            // 
            // txtMeasSkipCh0
            // 
            this.txtMeasSkipCh0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMeasSkipCh0.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMeasSkipCh0.Location = new System.Drawing.Point(3, 16);
            this.txtMeasSkipCh0.Name = "txtMeasSkipCh0";
            this.txtMeasSkipCh0.Size = new System.Drawing.Size(78, 22);
            this.txtMeasSkipCh0.TabIndex = 13;
            this.txtMeasSkipCh0.Text = "0";
            // 
            // txtMeasSkipCh1
            // 
            this.txtMeasSkipCh1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMeasSkipCh1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMeasSkipCh1.Location = new System.Drawing.Point(3, 16);
            this.txtMeasSkipCh1.Name = "txtMeasSkipCh1";
            this.txtMeasSkipCh1.Size = new System.Drawing.Size(81, 22);
            this.txtMeasSkipCh1.TabIndex = 14;
            this.txtMeasSkipCh1.Text = "0";
            // 
            // ckMemoryWrap
            // 
            this.ckMemoryWrap.AutoSize = true;
            this.ckMemoryWrap.Location = new System.Drawing.Point(403, 24);
            this.ckMemoryWrap.Name = "ckMemoryWrap";
            this.ckMemoryWrap.Size = new System.Drawing.Size(89, 17);
            this.ckMemoryWrap.TabIndex = 30;
            this.ckMemoryWrap.Text = "Memory warp";
            this.ckMemoryWrap.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(32, 632);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 23);
            this.button12.TabIndex = 31;
            this.button12.Text = "ReadRaw";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(32, 374);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 32;
            this.button6.Text = "DebugForm";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // txtCalibrate
            // 
            this.txtCalibrate.Location = new System.Drawing.Point(113, 514);
            this.txtCalibrate.Name = "txtCalibrate";
            this.txtCalibrate.Size = new System.Drawing.Size(295, 20);
            this.txtCalibrate.TabIndex = 34;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(32, 513);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 33;
            this.button10.Text = "Calibrate";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.btnCalibrate_Click_1);
            // 
            // ckCal
            // 
            this.ckCal.AutoSize = true;
            this.ckCal.Location = new System.Drawing.Point(208, 121);
            this.ckCal.Name = "ckCal";
            this.ckCal.Size = new System.Drawing.Size(166, 17);
            this.ckCal.TabIndex = 35;
            this.ckCal.Text = "Calibrate before measurement";
            this.ckCal.UseVisualStyleBackColor = true;
            // 
            // txtSetRealtime
            // 
            this.txtSetRealtime.Location = new System.Drawing.Point(113, 574);
            this.txtSetRealtime.Name = "txtSetRealtime";
            this.txtSetRealtime.Size = new System.Drawing.Size(84, 20);
            this.txtSetRealtime.TabIndex = 37;
            this.txtSetRealtime.Text = "1";
            // 
            // btnSetRealtime
            // 
            this.btnSetRealtime.Location = new System.Drawing.Point(32, 573);
            this.btnSetRealtime.Name = "btnSetRealtime";
            this.btnSetRealtime.Size = new System.Drawing.Size(75, 23);
            this.btnSetRealtime.TabIndex = 36;
            this.btnSetRealtime.Text = "Get/Set Realtime";
            this.btnSetRealtime.UseVisualStyleBackColor = true;
            this.btnSetRealtime.Click += new System.EventHandler(this.btnSetRealtime_Click);
            // 
            // txtGetRealtime1
            // 
            this.txtGetRealtime1.Location = new System.Drawing.Point(206, 574);
            this.txtGetRealtime1.Name = "txtGetRealtime1";
            this.txtGetRealtime1.Size = new System.Drawing.Size(84, 20);
            this.txtGetRealtime1.TabIndex = 38;
            // 
            // txtGetRealtime2
            // 
            this.txtGetRealtime2.Location = new System.Drawing.Point(296, 574);
            this.txtGetRealtime2.Name = "txtGetRealtime2";
            this.txtGetRealtime2.Size = new System.Drawing.Size(84, 20);
            this.txtGetRealtime2.TabIndex = 39;
            // 
            // ckReadRAW
            // 
            this.ckReadRAW.AutoSize = true;
            this.ckReadRAW.Location = new System.Drawing.Point(403, 47);
            this.ckReadRAW.Name = "ckReadRAW";
            this.ckReadRAW.Size = new System.Drawing.Size(81, 17);
            this.ckReadRAW.TabIndex = 40;
            this.ckReadRAW.Text = "Read RAW";
            this.ckReadRAW.UseVisualStyleBackColor = true;
            // 
            // ckTagsSucceded
            // 
            this.ckTagsSucceded.AutoSize = true;
            this.ckTagsSucceded.Checked = true;
            this.ckTagsSucceded.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckTagsSucceded.Location = new System.Drawing.Point(208, 167);
            this.ckTagsSucceded.Name = "ckTagsSucceded";
            this.ckTagsSucceded.Size = new System.Drawing.Size(184, 17);
            this.ckTagsSucceded.TabIndex = 41;
            this.ckTagsSucceded.Text = "Show only valid results (Tags > 0)";
            this.ckTagsSucceded.UseVisualStyleBackColor = true;
            // 
            // ckReadAllErrors
            // 
            this.ckReadAllErrors.AutoSize = true;
            this.ckReadAllErrors.Location = new System.Drawing.Point(403, 70);
            this.ckReadAllErrors.Name = "ckReadAllErrors";
            this.ckReadAllErrors.Size = new System.Drawing.Size(160, 17);
            this.ckReadAllErrors.TabIndex = 42;
            this.ckReadAllErrors.Text = "Read Errors every command";
            this.ckReadAllErrors.UseVisualStyleBackColor = true;
            // 
            // lblChanneMeasinoutl
            // 
            this.lblChanneMeasinoutl.AutoSize = true;
            this.lblChanneMeasinoutl.Location = new System.Drawing.Point(147, 609);
            this.lblChanneMeasinoutl.Name = "lblChanneMeasinoutl";
            this.lblChanneMeasinoutl.Size = new System.Drawing.Size(20, 13);
            this.lblChanneMeasinoutl.TabIndex = 43;
            this.lblChanneMeasinoutl.Text = "Ch";
            // 
            // lblInpMeasinout
            // 
            this.lblInpMeasinout.AutoSize = true;
            this.lblInpMeasinout.Location = new System.Drawing.Point(216, 609);
            this.lblInpMeasinout.Name = "lblInpMeasinout";
            this.lblInpMeasinout.Size = new System.Drawing.Size(22, 13);
            this.lblInpMeasinout.TabIndex = 45;
            this.lblInpMeasinout.Text = "Inp";
            // 
            // tabControlMeasurements
            // 
            this.tabControlMeasurements.Controls.Add(this.tabPageMeasurement);
            this.tabControlMeasurements.Controls.Add(this.tabPageCounterTesting);
            this.tabControlMeasurements.Controls.Add(this.tabPageMeasurementConfiguration);
            this.tabControlMeasurements.Controls.Add(this.tabPageMeasFiles);
            this.tabControlMeasurements.Controls.Add(this.tabPageAppConfiguration);
            this.tabControlMeasurements.Controls.Add(this.tabPageAppLog);
            this.tabControlMeasurements.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMeasurements.ImageList = this.imageList1;
            this.tabControlMeasurements.Location = new System.Drawing.Point(0, 0);
            this.tabControlMeasurements.Name = "tabControlMeasurements";
            this.tabControlMeasurements.SelectedIndex = 0;
            this.tabControlMeasurements.Size = new System.Drawing.Size(1777, 717);
            this.tabControlMeasurements.TabIndex = 46;
            this.tabControlMeasurements.SelectedIndexChanged += new System.EventHandler(this.tabControlMeasurements_SelectedIndexChanged);
            // 
            // tabPageMeasurement
            // 
            this.tabPageMeasurement.Controls.Add(this.splitContainer1);
            this.tabPageMeasurement.ImageKey = "bin_x24.png";
            this.tabPageMeasurement.Location = new System.Drawing.Point(4, 23);
            this.tabPageMeasurement.Name = "tabPageMeasurement";
            this.tabPageMeasurement.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMeasurement.Size = new System.Drawing.Size(1769, 690);
            this.tabPageMeasurement.TabIndex = 0;
            this.tabPageMeasurement.Text = "Measurement";
            this.tabPageMeasurement.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.hsStop);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox4);
            this.splitContainer1.Panel1.Controls.Add(this.hsRun);
            this.splitContainer1.Panel1.Controls.Add(this.gbLoops);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControlResultConfiguration);
            this.splitContainer1.Size = new System.Drawing.Size(1763, 684);
            this.splitContainer1.SplitterDistance = 450;
            this.splitContainer1.TabIndex = 53;
            // 
            // hsStop
            // 
            this.hsStop.BackColor = System.Drawing.Color.Transparent;
            this.hsStop.BackColorHover = System.Drawing.Color.Transparent;
            this.hsStop.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsStop.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsStop.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsStop.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsStop.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsStop.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.hsStop.FlatAppearance.BorderSize = 0;
            this.hsStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsStop.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsStop.Image = global::PRCCounterApp.Properties.Resources.cross_red_x32;
            this.hsStop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hsStop.ImageHover = global::PRCCounterApp.Properties.Resources.cross_blue_x32;
            this.hsStop.ImageToggleOnSelect = false;
            this.hsStop.Location = new System.Drawing.Point(18, 75);
            this.hsStop.Marked = false;
            this.hsStop.MarkedColor = System.Drawing.Color.Teal;
            this.hsStop.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsStop.MarkedText = "";
            this.hsStop.MarkMode = false;
            this.hsStop.Name = "hsStop";
            this.hsStop.NonMarkedText = "";
            this.hsStop.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsStop.ShowShortcut = false;
            this.hsStop.Size = new System.Drawing.Size(168, 47);
            this.hsStop.TabIndex = 56;
            this.hsStop.Text = "Stop act measurement";
            this.hsStop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hsStop.ToolTipActive = false;
            this.hsStop.ToolTipAutomaticDelay = 500;
            this.hsStop.ToolTipAutoPopDelay = 5000;
            this.hsStop.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsStop.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsStop.ToolTipFor4ContextMenu = true;
            this.hsStop.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsStop.ToolTipInitialDelay = 500;
            this.hsStop.ToolTipIsBallon = false;
            this.hsStop.ToolTipOwnerDraw = false;
            this.hsStop.ToolTipReshowDelay = 100;
            this.hsStop.ToolTipShowAlways = false;
            this.hsStop.ToolTipText = "";
            this.hsStop.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsStop.ToolTipTitle = "";
            this.hsStop.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsStop.UseVisualStyleBackColor = false;
            this.hsStop.Click += new System.EventHandler(this.hsStop_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.hs_SetFrequency_A_B);
            this.groupBox4.Controls.Add(this.hsSetFrequencyMeasurment_A);
            this.groupBox4.Controls.Add(this.hsSetPhase_A_B);
            this.groupBox4.Location = new System.Drawing.Point(28, 155);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(256, 200);
            this.groupBox4.TabIndex = 65;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Set default measurements";
            // 
            // hs_SetFrequency_A_B
            // 
            this.hs_SetFrequency_A_B.BackColor = System.Drawing.Color.Transparent;
            this.hs_SetFrequency_A_B.BackColorHover = System.Drawing.Color.Transparent;
            this.hs_SetFrequency_A_B.BorderColorHover = System.Drawing.Color.Transparent;
            this.hs_SetFrequency_A_B.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hs_SetFrequency_A_B.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hs_SetFrequency_A_B.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hs_SetFrequency_A_B.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hs_SetFrequency_A_B.Dock = System.Windows.Forms.DockStyle.Top;
            this.hs_SetFrequency_A_B.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.hs_SetFrequency_A_B.FlatAppearance.BorderSize = 0;
            this.hs_SetFrequency_A_B.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hs_SetFrequency_A_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hs_SetFrequency_A_B.HoverStyle = SeControlsLib.frameStyle.none;
            this.hs_SetFrequency_A_B.Image = global::PRCCounterApp.Properties.Resources.ok_gn22x;
            this.hs_SetFrequency_A_B.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hs_SetFrequency_A_B.ImageHover = global::PRCCounterApp.Properties.Resources.ok_blue22x;
            this.hs_SetFrequency_A_B.ImageToggleOnSelect = false;
            this.hs_SetFrequency_A_B.Location = new System.Drawing.Point(3, 93);
            this.hs_SetFrequency_A_B.Marked = false;
            this.hs_SetFrequency_A_B.MarkedColor = System.Drawing.Color.Teal;
            this.hs_SetFrequency_A_B.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hs_SetFrequency_A_B.MarkedText = "";
            this.hs_SetFrequency_A_B.MarkMode = false;
            this.hs_SetFrequency_A_B.Name = "hs_SetFrequency_A_B";
            this.hs_SetFrequency_A_B.NonMarkedText = "";
            this.hs_SetFrequency_A_B.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hs_SetFrequency_A_B.ShowShortcut = false;
            this.hs_SetFrequency_A_B.Size = new System.Drawing.Size(250, 37);
            this.hs_SetFrequency_A_B.TabIndex = 66;
            this.hs_SetFrequency_A_B.Text = "Set Frequency Measurement A-B";
            this.hs_SetFrequency_A_B.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hs_SetFrequency_A_B.ToolTipActive = false;
            this.hs_SetFrequency_A_B.ToolTipAutomaticDelay = 500;
            this.hs_SetFrequency_A_B.ToolTipAutoPopDelay = 5000;
            this.hs_SetFrequency_A_B.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hs_SetFrequency_A_B.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hs_SetFrequency_A_B.ToolTipFor4ContextMenu = true;
            this.hs_SetFrequency_A_B.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hs_SetFrequency_A_B.ToolTipInitialDelay = 500;
            this.hs_SetFrequency_A_B.ToolTipIsBallon = false;
            this.hs_SetFrequency_A_B.ToolTipOwnerDraw = false;
            this.hs_SetFrequency_A_B.ToolTipReshowDelay = 100;
            this.hs_SetFrequency_A_B.ToolTipShowAlways = false;
            this.hs_SetFrequency_A_B.ToolTipText = "";
            this.hs_SetFrequency_A_B.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hs_SetFrequency_A_B.ToolTipTitle = "";
            this.hs_SetFrequency_A_B.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hs_SetFrequency_A_B.UseVisualStyleBackColor = false;
            this.hs_SetFrequency_A_B.Click += new System.EventHandler(this.hs_SetFrequency_A_B_Click);
            // 
            // hsSetFrequencyMeasurment_A
            // 
            this.hsSetFrequencyMeasurment_A.BackColor = System.Drawing.Color.Transparent;
            this.hsSetFrequencyMeasurment_A.BackColorHover = System.Drawing.Color.Transparent;
            this.hsSetFrequencyMeasurment_A.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsSetFrequencyMeasurment_A.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsSetFrequencyMeasurment_A.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsSetFrequencyMeasurment_A.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsSetFrequencyMeasurment_A.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsSetFrequencyMeasurment_A.Dock = System.Windows.Forms.DockStyle.Top;
            this.hsSetFrequencyMeasurment_A.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.hsSetFrequencyMeasurment_A.FlatAppearance.BorderSize = 0;
            this.hsSetFrequencyMeasurment_A.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsSetFrequencyMeasurment_A.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsSetFrequencyMeasurment_A.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsSetFrequencyMeasurment_A.Image = global::PRCCounterApp.Properties.Resources.ok_gn22x;
            this.hsSetFrequencyMeasurment_A.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hsSetFrequencyMeasurment_A.ImageHover = global::PRCCounterApp.Properties.Resources.ok_blue22x;
            this.hsSetFrequencyMeasurment_A.ImageToggleOnSelect = false;
            this.hsSetFrequencyMeasurment_A.Location = new System.Drawing.Point(3, 53);
            this.hsSetFrequencyMeasurment_A.Marked = false;
            this.hsSetFrequencyMeasurment_A.MarkedColor = System.Drawing.Color.Teal;
            this.hsSetFrequencyMeasurment_A.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsSetFrequencyMeasurment_A.MarkedText = "";
            this.hsSetFrequencyMeasurment_A.MarkMode = false;
            this.hsSetFrequencyMeasurment_A.Name = "hsSetFrequencyMeasurment_A";
            this.hsSetFrequencyMeasurment_A.NonMarkedText = "";
            this.hsSetFrequencyMeasurment_A.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsSetFrequencyMeasurment_A.ShowShortcut = false;
            this.hsSetFrequencyMeasurment_A.Size = new System.Drawing.Size(250, 40);
            this.hsSetFrequencyMeasurment_A.TabIndex = 65;
            this.hsSetFrequencyMeasurment_A.Text = "Set Frequency Measurement A";
            this.hsSetFrequencyMeasurment_A.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsSetFrequencyMeasurment_A.ToolTipActive = false;
            this.hsSetFrequencyMeasurment_A.ToolTipAutomaticDelay = 500;
            this.hsSetFrequencyMeasurment_A.ToolTipAutoPopDelay = 5000;
            this.hsSetFrequencyMeasurment_A.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsSetFrequencyMeasurment_A.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsSetFrequencyMeasurment_A.ToolTipFor4ContextMenu = true;
            this.hsSetFrequencyMeasurment_A.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsSetFrequencyMeasurment_A.ToolTipInitialDelay = 500;
            this.hsSetFrequencyMeasurment_A.ToolTipIsBallon = false;
            this.hsSetFrequencyMeasurment_A.ToolTipOwnerDraw = false;
            this.hsSetFrequencyMeasurment_A.ToolTipReshowDelay = 100;
            this.hsSetFrequencyMeasurment_A.ToolTipShowAlways = false;
            this.hsSetFrequencyMeasurment_A.ToolTipText = "";
            this.hsSetFrequencyMeasurment_A.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsSetFrequencyMeasurment_A.ToolTipTitle = "";
            this.hsSetFrequencyMeasurment_A.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsSetFrequencyMeasurment_A.UseVisualStyleBackColor = false;
            this.hsSetFrequencyMeasurment_A.Click += new System.EventHandler(this.hsSetFrequencyMeasurment_A_Click);
            // 
            // hsSetPhase_A_B
            // 
            this.hsSetPhase_A_B.BackColor = System.Drawing.Color.Transparent;
            this.hsSetPhase_A_B.BackColorHover = System.Drawing.Color.Transparent;
            this.hsSetPhase_A_B.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsSetPhase_A_B.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsSetPhase_A_B.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsSetPhase_A_B.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsSetPhase_A_B.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsSetPhase_A_B.Dock = System.Windows.Forms.DockStyle.Top;
            this.hsSetPhase_A_B.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.hsSetPhase_A_B.FlatAppearance.BorderSize = 0;
            this.hsSetPhase_A_B.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsSetPhase_A_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsSetPhase_A_B.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsSetPhase_A_B.Image = global::PRCCounterApp.Properties.Resources.ok_gn22x;
            this.hsSetPhase_A_B.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hsSetPhase_A_B.ImageHover = global::PRCCounterApp.Properties.Resources.ok_blue22x;
            this.hsSetPhase_A_B.ImageToggleOnSelect = false;
            this.hsSetPhase_A_B.Location = new System.Drawing.Point(3, 16);
            this.hsSetPhase_A_B.Marked = false;
            this.hsSetPhase_A_B.MarkedColor = System.Drawing.Color.Teal;
            this.hsSetPhase_A_B.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsSetPhase_A_B.MarkedText = "";
            this.hsSetPhase_A_B.MarkMode = false;
            this.hsSetPhase_A_B.Name = "hsSetPhase_A_B";
            this.hsSetPhase_A_B.NonMarkedText = "";
            this.hsSetPhase_A_B.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsSetPhase_A_B.ShowShortcut = false;
            this.hsSetPhase_A_B.Size = new System.Drawing.Size(250, 37);
            this.hsSetPhase_A_B.TabIndex = 64;
            this.hsSetPhase_A_B.Text = "Set Phase Measurement A-B";
            this.hsSetPhase_A_B.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsSetPhase_A_B.ToolTipActive = false;
            this.hsSetPhase_A_B.ToolTipAutomaticDelay = 500;
            this.hsSetPhase_A_B.ToolTipAutoPopDelay = 5000;
            this.hsSetPhase_A_B.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsSetPhase_A_B.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsSetPhase_A_B.ToolTipFor4ContextMenu = true;
            this.hsSetPhase_A_B.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsSetPhase_A_B.ToolTipInitialDelay = 500;
            this.hsSetPhase_A_B.ToolTipIsBallon = false;
            this.hsSetPhase_A_B.ToolTipOwnerDraw = false;
            this.hsSetPhase_A_B.ToolTipReshowDelay = 100;
            this.hsSetPhase_A_B.ToolTipShowAlways = false;
            this.hsSetPhase_A_B.ToolTipText = "";
            this.hsSetPhase_A_B.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsSetPhase_A_B.ToolTipTitle = "";
            this.hsSetPhase_A_B.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsSetPhase_A_B.UseVisualStyleBackColor = false;
            this.hsSetPhase_A_B.Click += new System.EventHandler(this.hsSetPhase_A_B_Click);
            // 
            // hsRun
            // 
            this.hsRun.BackColor = System.Drawing.Color.Transparent;
            this.hsRun.BackColorHover = System.Drawing.Color.Transparent;
            this.hsRun.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsRun.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsRun.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsRun.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsRun.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsRun.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.hsRun.FlatAppearance.BorderSize = 0;
            this.hsRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsRun.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsRun.Image = global::PRCCounterApp.Properties.Resources.papierflieger_bl_x32;
            this.hsRun.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hsRun.ImageHover = global::PRCCounterApp.Properties.Resources.papierflieger_gr_x32;
            this.hsRun.ImageToggleOnSelect = false;
            this.hsRun.Location = new System.Drawing.Point(18, 22);
            this.hsRun.Marked = false;
            this.hsRun.MarkedColor = System.Drawing.Color.Teal;
            this.hsRun.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsRun.MarkedText = "";
            this.hsRun.MarkMode = false;
            this.hsRun.Name = "hsRun";
            this.hsRun.NonMarkedText = "";
            this.hsRun.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsRun.ShowShortcut = false;
            this.hsRun.Size = new System.Drawing.Size(168, 47);
            this.hsRun.TabIndex = 55;
            this.hsRun.Text = "Run act measurement";
            this.hsRun.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hsRun.ToolTipActive = false;
            this.hsRun.ToolTipAutomaticDelay = 500;
            this.hsRun.ToolTipAutoPopDelay = 5000;
            this.hsRun.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsRun.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsRun.ToolTipFor4ContextMenu = true;
            this.hsRun.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsRun.ToolTipInitialDelay = 500;
            this.hsRun.ToolTipIsBallon = false;
            this.hsRun.ToolTipOwnerDraw = false;
            this.hsRun.ToolTipReshowDelay = 100;
            this.hsRun.ToolTipShowAlways = false;
            this.hsRun.ToolTipText = "";
            this.hsRun.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsRun.ToolTipTitle = "";
            this.hsRun.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsRun.UseVisualStyleBackColor = false;
            this.hsRun.Click += new System.EventHandler(this.hsRun_Click_1);
            // 
            // tabControlResultConfiguration
            // 
            this.tabControlResultConfiguration.Controls.Add(this.tabPageResults);
            this.tabControlResultConfiguration.Controls.Add(this.tabPageMeasResultsLog);
            this.tabControlResultConfiguration.Controls.Add(this.tabPageMeasResultsErrorlog);
            this.tabControlResultConfiguration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlResultConfiguration.ImageList = this.imageList1;
            this.tabControlResultConfiguration.Location = new System.Drawing.Point(0, 0);
            this.tabControlResultConfiguration.Name = "tabControlResultConfiguration";
            this.tabControlResultConfiguration.SelectedIndex = 0;
            this.tabControlResultConfiguration.Size = new System.Drawing.Size(1309, 684);
            this.tabControlResultConfiguration.TabIndex = 47;
            this.tabControlResultConfiguration.SelectedIndexChanged += new System.EventHandler(this.tabControl2_SelectedIndexChanged);
            // 
            // tabPageResults
            // 
            this.tabPageResults.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPageResults.Controls.Add(this.gbMeasResults);
            this.tabPageResults.ImageKey = "graph_24x.png";
            this.tabPageResults.Location = new System.Drawing.Point(4, 23);
            this.tabPageResults.Name = "tabPageResults";
            this.tabPageResults.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageResults.Size = new System.Drawing.Size(1301, 657);
            this.tabPageResults.TabIndex = 0;
            this.tabPageResults.Text = "Results";
            // 
            // gbMeasResults
            // 
            this.gbMeasResults.Controls.Add(this.dgvResults);
            this.gbMeasResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbMeasResults.Location = new System.Drawing.Point(3, 3);
            this.gbMeasResults.Name = "gbMeasResults";
            this.gbMeasResults.Size = new System.Drawing.Size(1295, 651);
            this.gbMeasResults.TabIndex = 0;
            this.gbMeasResults.TabStop = false;
            // 
            // dgvResults
            // 
            this.dgvResults.AutoGenerateColumns = false;
            this.dgvResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.STAMP,
            this.DATASTAMP,
            this.VALUE,
            this.INFO});
            this.dgvResults.DataSource = this.bsResults;
            this.dgvResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResults.Location = new System.Drawing.Point(3, 16);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.ReadOnly = true;
            this.dgvResults.RowHeadersVisible = false;
            this.dgvResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResults.Size = new System.Drawing.Size(1289, 632);
            this.dgvResults.TabIndex = 13;
            // 
            // bsResults
            // 
            this.bsResults.DataMember = "Table1";
            this.bsResults.DataSource = this.dsResults;
            // 
            // dsResults
            // 
            this.dsResults.DataSetName = "NewDataSet";
            this.dsResults.EnforceConstraints = false;
            this.dsResults.Tables.AddRange(new System.Data.DataTable[] {
            dataTable1});
            // 
            // tabPageMeasResultsLog
            // 
            this.tabPageMeasResultsLog.Controls.Add(this.rtResultLogs);
            this.tabPageMeasResultsLog.Controls.Add(this.pnlLogUpper);
            this.tabPageMeasResultsLog.ImageKey = "dictionary_blue_24X.png";
            this.tabPageMeasResultsLog.Location = new System.Drawing.Point(4, 23);
            this.tabPageMeasResultsLog.Name = "tabPageMeasResultsLog";
            this.tabPageMeasResultsLog.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMeasResultsLog.Size = new System.Drawing.Size(1301, 657);
            this.tabPageMeasResultsLog.TabIndex = 2;
            this.tabPageMeasResultsLog.Text = "Results log";
            this.tabPageMeasResultsLog.UseVisualStyleBackColor = true;
            // 
            // rtResultLogs
            // 
            this.rtResultLogs.BackColor = System.Drawing.SystemColors.Info;
            this.rtResultLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtResultLogs.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtResultLogs.Location = new System.Drawing.Point(3, 45);
            this.rtResultLogs.Name = "rtResultLogs";
            this.rtResultLogs.Size = new System.Drawing.Size(1295, 609);
            this.rtResultLogs.TabIndex = 12;
            this.rtResultLogs.Text = "";
            // 
            // pnlLogUpper
            // 
            this.pnlLogUpper.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlLogUpper.Controls.Add(this.hsSaveMeasResultsLogs);
            this.pnlLogUpper.Controls.Add(this.cbResultLogActive);
            this.pnlLogUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogUpper.Location = new System.Drawing.Point(3, 3);
            this.pnlLogUpper.Name = "pnlLogUpper";
            this.pnlLogUpper.Size = new System.Drawing.Size(1295, 42);
            this.pnlLogUpper.TabIndex = 14;
            // 
            // hsSaveMeasResultsLogs
            // 
            this.hsSaveMeasResultsLogs.BackColor = System.Drawing.Color.Transparent;
            this.hsSaveMeasResultsLogs.BackColorHover = System.Drawing.Color.Transparent;
            this.hsSaveMeasResultsLogs.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsSaveMeasResultsLogs.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsSaveMeasResultsLogs.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsSaveMeasResultsLogs.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsSaveMeasResultsLogs.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsSaveMeasResultsLogs.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.hsSaveMeasResultsLogs.FlatAppearance.BorderSize = 0;
            this.hsSaveMeasResultsLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsSaveMeasResultsLogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsSaveMeasResultsLogs.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsSaveMeasResultsLogs.Image = global::PRCCounterApp.Properties.Resources.floppy_x24;
            this.hsSaveMeasResultsLogs.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsSaveMeasResultsLogs.ImageHover = global::PRCCounterApp.Properties.Resources.floppy2_x24;
            this.hsSaveMeasResultsLogs.ImageToggleOnSelect = false;
            this.hsSaveMeasResultsLogs.Location = new System.Drawing.Point(222, 0);
            this.hsSaveMeasResultsLogs.Marked = false;
            this.hsSaveMeasResultsLogs.MarkedColor = System.Drawing.Color.Teal;
            this.hsSaveMeasResultsLogs.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsSaveMeasResultsLogs.MarkedText = "";
            this.hsSaveMeasResultsLogs.MarkMode = false;
            this.hsSaveMeasResultsLogs.Name = "hsSaveMeasResultsLogs";
            this.hsSaveMeasResultsLogs.NonMarkedText = "";
            this.hsSaveMeasResultsLogs.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsSaveMeasResultsLogs.ShowShortcut = false;
            this.hsSaveMeasResultsLogs.Size = new System.Drawing.Size(131, 42);
            this.hsSaveMeasResultsLogs.TabIndex = 65;
            this.hsSaveMeasResultsLogs.Text = "Save results log\'s";
            this.hsSaveMeasResultsLogs.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsSaveMeasResultsLogs.ToolTipActive = false;
            this.hsSaveMeasResultsLogs.ToolTipAutomaticDelay = 500;
            this.hsSaveMeasResultsLogs.ToolTipAutoPopDelay = 5000;
            this.hsSaveMeasResultsLogs.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsSaveMeasResultsLogs.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsSaveMeasResultsLogs.ToolTipFor4ContextMenu = true;
            this.hsSaveMeasResultsLogs.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsSaveMeasResultsLogs.ToolTipInitialDelay = 500;
            this.hsSaveMeasResultsLogs.ToolTipIsBallon = false;
            this.hsSaveMeasResultsLogs.ToolTipOwnerDraw = false;
            this.hsSaveMeasResultsLogs.ToolTipReshowDelay = 100;
            this.hsSaveMeasResultsLogs.ToolTipShowAlways = false;
            this.hsSaveMeasResultsLogs.ToolTipText = "";
            this.hsSaveMeasResultsLogs.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsSaveMeasResultsLogs.ToolTipTitle = "";
            this.hsSaveMeasResultsLogs.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsSaveMeasResultsLogs.UseVisualStyleBackColor = false;
            this.hsSaveMeasResultsLogs.Click += new System.EventHandler(this.hsSaveLogs_Click);
            // 
            // cbResultLogActive
            // 
            this.cbResultLogActive.AutoSize = true;
            this.cbResultLogActive.Checked = true;
            this.cbResultLogActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbResultLogActive.Location = new System.Drawing.Point(28, 14);
            this.cbResultLogActive.Name = "cbResultLogActive";
            this.cbResultLogActive.Size = new System.Drawing.Size(76, 17);
            this.cbResultLogActive.TabIndex = 0;
            this.cbResultLogActive.Text = "Log active";
            this.cbResultLogActive.UseVisualStyleBackColor = true;
            // 
            // tabPageMeasResultsErrorlog
            // 
            this.tabPageMeasResultsErrorlog.Controls.Add(this.rtResultsErrorLog);
            this.tabPageMeasResultsErrorlog.Controls.Add(this.panel1);
            this.tabPageMeasResultsErrorlog.ImageKey = "dictionary_blue_24X.png";
            this.tabPageMeasResultsErrorlog.Location = new System.Drawing.Point(4, 23);
            this.tabPageMeasResultsErrorlog.Name = "tabPageMeasResultsErrorlog";
            this.tabPageMeasResultsErrorlog.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMeasResultsErrorlog.Size = new System.Drawing.Size(1301, 657);
            this.tabPageMeasResultsErrorlog.TabIndex = 3;
            this.tabPageMeasResultsErrorlog.Text = "Results error log";
            this.tabPageMeasResultsErrorlog.UseVisualStyleBackColor = true;
            // 
            // rtResultsErrorLog
            // 
            this.rtResultsErrorLog.BackColor = System.Drawing.SystemColors.Info;
            this.rtResultsErrorLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtResultsErrorLog.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtResultsErrorLog.Location = new System.Drawing.Point(3, 45);
            this.rtResultsErrorLog.Name = "rtResultsErrorLog";
            this.rtResultsErrorLog.Size = new System.Drawing.Size(1295, 609);
            this.rtResultsErrorLog.TabIndex = 16;
            this.rtResultsErrorLog.Text = "";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.hsSaveMeasResultErrorLogs);
            this.panel1.Controls.Add(this.cbUpdateErrorLogEveryNewEntry);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1295, 42);
            this.panel1.TabIndex = 15;
            // 
            // hsSaveMeasResultErrorLogs
            // 
            this.hsSaveMeasResultErrorLogs.BackColor = System.Drawing.Color.Transparent;
            this.hsSaveMeasResultErrorLogs.BackColorHover = System.Drawing.Color.Transparent;
            this.hsSaveMeasResultErrorLogs.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsSaveMeasResultErrorLogs.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsSaveMeasResultErrorLogs.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsSaveMeasResultErrorLogs.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsSaveMeasResultErrorLogs.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsSaveMeasResultErrorLogs.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.hsSaveMeasResultErrorLogs.FlatAppearance.BorderSize = 0;
            this.hsSaveMeasResultErrorLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsSaveMeasResultErrorLogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsSaveMeasResultErrorLogs.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsSaveMeasResultErrorLogs.Image = global::PRCCounterApp.Properties.Resources.floppy_x24;
            this.hsSaveMeasResultErrorLogs.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsSaveMeasResultErrorLogs.ImageHover = global::PRCCounterApp.Properties.Resources.floppy2_x24;
            this.hsSaveMeasResultErrorLogs.ImageToggleOnSelect = false;
            this.hsSaveMeasResultErrorLogs.Location = new System.Drawing.Point(222, 0);
            this.hsSaveMeasResultErrorLogs.Marked = false;
            this.hsSaveMeasResultErrorLogs.MarkedColor = System.Drawing.Color.Teal;
            this.hsSaveMeasResultErrorLogs.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsSaveMeasResultErrorLogs.MarkedText = "";
            this.hsSaveMeasResultErrorLogs.MarkMode = false;
            this.hsSaveMeasResultErrorLogs.Name = "hsSaveMeasResultErrorLogs";
            this.hsSaveMeasResultErrorLogs.NonMarkedText = "";
            this.hsSaveMeasResultErrorLogs.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsSaveMeasResultErrorLogs.ShowShortcut = false;
            this.hsSaveMeasResultErrorLogs.Size = new System.Drawing.Size(131, 42);
            this.hsSaveMeasResultErrorLogs.TabIndex = 65;
            this.hsSaveMeasResultErrorLogs.Text = "Save result error log\'s";
            this.hsSaveMeasResultErrorLogs.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsSaveMeasResultErrorLogs.ToolTipActive = false;
            this.hsSaveMeasResultErrorLogs.ToolTipAutomaticDelay = 500;
            this.hsSaveMeasResultErrorLogs.ToolTipAutoPopDelay = 5000;
            this.hsSaveMeasResultErrorLogs.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsSaveMeasResultErrorLogs.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsSaveMeasResultErrorLogs.ToolTipFor4ContextMenu = true;
            this.hsSaveMeasResultErrorLogs.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsSaveMeasResultErrorLogs.ToolTipInitialDelay = 500;
            this.hsSaveMeasResultErrorLogs.ToolTipIsBallon = false;
            this.hsSaveMeasResultErrorLogs.ToolTipOwnerDraw = false;
            this.hsSaveMeasResultErrorLogs.ToolTipReshowDelay = 100;
            this.hsSaveMeasResultErrorLogs.ToolTipShowAlways = false;
            this.hsSaveMeasResultErrorLogs.ToolTipText = "";
            this.hsSaveMeasResultErrorLogs.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsSaveMeasResultErrorLogs.ToolTipTitle = "";
            this.hsSaveMeasResultErrorLogs.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsSaveMeasResultErrorLogs.UseVisualStyleBackColor = false;
            this.hsSaveMeasResultErrorLogs.Click += new System.EventHandler(this.hsSaveErrorLogs_Click);
            // 
            // cbUpdateErrorLogEveryNewEntry
            // 
            this.cbUpdateErrorLogEveryNewEntry.AutoSize = true;
            this.cbUpdateErrorLogEveryNewEntry.Location = new System.Drawing.Point(28, 14);
            this.cbUpdateErrorLogEveryNewEntry.Name = "cbUpdateErrorLogEveryNewEntry";
            this.cbUpdateErrorLogEveryNewEntry.Size = new System.Drawing.Size(156, 17);
            this.cbUpdateErrorLogEveryNewEntry.TabIndex = 0;
            this.cbUpdateErrorLogEveryNewEntry.Text = "Update log every new entry";
            this.cbUpdateErrorLogEveryNewEntry.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "graph_24x.png");
            this.imageList1.Images.SetKeyName(1, "dictionary_blue_24X.png");
            this.imageList1.Images.SetKeyName(2, "bin_x24.png");
            this.imageList1.Images.SetKeyName(3, "preferences_system_x24.png");
            this.imageList1.Images.SetKeyName(4, "applications_system_22x.png");
            // 
            // tabPageCounterTesting
            // 
            this.tabPageCounterTesting.Controls.Add(this.hsTestFrequency);
            this.tabPageCounterTesting.Controls.Add(this.txtResultBoard);
            this.tabPageCounterTesting.Controls.Add(this.ckFirst);
            this.tabPageCounterTesting.Controls.Add(this.txtResuldBoardError);
            this.tabPageCounterTesting.Controls.Add(this.btnGetBoard);
            this.tabPageCounterTesting.Controls.Add(this.ckSetClock);
            this.tabPageCounterTesting.Controls.Add(this.txtSelectDeviceResult);
            this.tabPageCounterTesting.Controls.Add(this.txtSelectDev);
            this.tabPageCounterTesting.Controls.Add(this.btnSelect);
            this.tabPageCounterTesting.Controls.Add(this.txtInitDefault);
            this.tabPageCounterTesting.Controls.Add(this.txtMeasInput);
            this.tabPageCounterTesting.Controls.Add(this.button6);
            this.tabPageCounterTesting.Controls.Add(this.groupBox3);
            this.tabPageCounterTesting.Controls.Add(this.lblInpMeasinout);
            this.tabPageCounterTesting.Controls.Add(this.groupBox2);
            this.tabPageCounterTesting.Controls.Add(this.button1);
            this.tabPageCounterTesting.Controls.Add(this.lblChanneMeasinoutl);
            this.tabPageCounterTesting.Controls.Add(this.button5);
            this.tabPageCounterTesting.Controls.Add(this.txtResultIsMaster);
            this.tabPageCounterTesting.Controls.Add(this.txtGetRealtime2);
            this.tabPageCounterTesting.Controls.Add(this.button2);
            this.tabPageCounterTesting.Controls.Add(this.txtGetRealtime1);
            this.tabPageCounterTesting.Controls.Add(this.txtResultBoardModel);
            this.tabPageCounterTesting.Controls.Add(this.txtSetRealtime);
            this.tabPageCounterTesting.Controls.Add(this.btnSerialNumber);
            this.tabPageCounterTesting.Controls.Add(this.btnSetRealtime);
            this.tabPageCounterTesting.Controls.Add(this.txtResultSerial);
            this.tabPageCounterTesting.Controls.Add(this.txtCalibrate);
            this.tabPageCounterTesting.Controls.Add(this.button8);
            this.tabPageCounterTesting.Controls.Add(this.button10);
            this.tabPageCounterTesting.Controls.Add(this.button9);
            this.tabPageCounterTesting.Controls.Add(this.txtDriver);
            this.tabPageCounterTesting.Controls.Add(this.button12);
            this.tabPageCounterTesting.Controls.Add(this.txtCh2);
            this.tabPageCounterTesting.ImageKey = "applications_system_22x.png";
            this.tabPageCounterTesting.Location = new System.Drawing.Point(4, 23);
            this.tabPageCounterTesting.Name = "tabPageCounterTesting";
            this.tabPageCounterTesting.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCounterTesting.Size = new System.Drawing.Size(1769, 690);
            this.tabPageCounterTesting.TabIndex = 1;
            this.tabPageCounterTesting.Text = "Counter Tests";
            this.tabPageCounterTesting.UseVisualStyleBackColor = true;
            // 
            // hsTestFrequency
            // 
            this.hsTestFrequency.BackColor = System.Drawing.Color.Transparent;
            this.hsTestFrequency.BackColorHover = System.Drawing.Color.Transparent;
            this.hsTestFrequency.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsTestFrequency.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsTestFrequency.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsTestFrequency.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsTestFrequency.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsTestFrequency.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.hsTestFrequency.FlatAppearance.BorderSize = 0;
            this.hsTestFrequency.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsTestFrequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsTestFrequency.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsTestFrequency.Image = global::PRCCounterApp.Properties.Resources.cross_red_x32;
            this.hsTestFrequency.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hsTestFrequency.ImageHover = global::PRCCounterApp.Properties.Resources.cross_blue_x32;
            this.hsTestFrequency.ImageToggleOnSelect = false;
            this.hsTestFrequency.Location = new System.Drawing.Point(613, 35);
            this.hsTestFrequency.Marked = false;
            this.hsTestFrequency.MarkedColor = System.Drawing.Color.Teal;
            this.hsTestFrequency.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsTestFrequency.MarkedText = "";
            this.hsTestFrequency.MarkMode = false;
            this.hsTestFrequency.Name = "hsTestFrequency";
            this.hsTestFrequency.NonMarkedText = "";
            this.hsTestFrequency.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsTestFrequency.ShowShortcut = false;
            this.hsTestFrequency.Size = new System.Drawing.Size(168, 47);
            this.hsTestFrequency.TabIndex = 58;
            this.hsTestFrequency.Text = "Test Frequency 10 Mhz";
            this.hsTestFrequency.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hsTestFrequency.ToolTipActive = false;
            this.hsTestFrequency.ToolTipAutomaticDelay = 500;
            this.hsTestFrequency.ToolTipAutoPopDelay = 5000;
            this.hsTestFrequency.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsTestFrequency.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsTestFrequency.ToolTipFor4ContextMenu = true;
            this.hsTestFrequency.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsTestFrequency.ToolTipInitialDelay = 500;
            this.hsTestFrequency.ToolTipIsBallon = false;
            this.hsTestFrequency.ToolTipOwnerDraw = false;
            this.hsTestFrequency.ToolTipReshowDelay = 100;
            this.hsTestFrequency.ToolTipShowAlways = false;
            this.hsTestFrequency.ToolTipText = "";
            this.hsTestFrequency.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsTestFrequency.ToolTipTitle = "";
            this.hsTestFrequency.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsTestFrequency.UseVisualStyleBackColor = false;
            this.hsTestFrequency.Click += new System.EventHandler(this.hsTestFrequency_Click);
            // 
            // txtResultBoard
            // 
            this.txtResultBoard.Location = new System.Drawing.Point(168, 50);
            this.txtResultBoard.Name = "txtResultBoard";
            this.txtResultBoard.Size = new System.Drawing.Size(55, 20);
            this.txtResultBoard.TabIndex = 54;
            // 
            // ckFirst
            // 
            this.ckFirst.AutoSize = true;
            this.ckFirst.Checked = true;
            this.ckFirst.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckFirst.Location = new System.Drawing.Point(102, 50);
            this.ckFirst.Name = "ckFirst";
            this.ckFirst.Size = new System.Drawing.Size(45, 17);
            this.ckFirst.TabIndex = 53;
            this.ckFirst.Text = "First";
            this.ckFirst.UseVisualStyleBackColor = true;
            // 
            // txtResuldBoardError
            // 
            this.txtResuldBoardError.Location = new System.Drawing.Point(236, 50);
            this.txtResuldBoardError.Name = "txtResuldBoardError";
            this.txtResuldBoardError.Size = new System.Drawing.Size(249, 20);
            this.txtResuldBoardError.TabIndex = 52;
            // 
            // btnGetBoard
            // 
            this.btnGetBoard.Location = new System.Drawing.Point(21, 47);
            this.btnGetBoard.Name = "btnGetBoard";
            this.btnGetBoard.Size = new System.Drawing.Size(75, 23);
            this.btnGetBoard.TabIndex = 51;
            this.btnGetBoard.Text = "Get Board";
            this.btnGetBoard.UseVisualStyleBackColor = true;
            this.btnGetBoard.Click += new System.EventHandler(this.btnGetBoard_Click);
            // 
            // ckSetClock
            // 
            this.ckSetClock.AutoSize = true;
            this.ckSetClock.Checked = true;
            this.ckSetClock.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckSetClock.Location = new System.Drawing.Point(102, 21);
            this.ckSetClock.Name = "ckSetClock";
            this.ckSetClock.Size = new System.Drawing.Size(128, 17);
            this.ckSetClock.TabIndex = 50;
            this.ckSetClock.Text = "Set clock unchanged";
            this.ckSetClock.UseVisualStyleBackColor = true;
            // 
            // txtSelectDeviceResult
            // 
            this.txtSelectDeviceResult.Location = new System.Drawing.Point(168, 405);
            this.txtSelectDeviceResult.Name = "txtSelectDeviceResult";
            this.txtSelectDeviceResult.Size = new System.Drawing.Size(240, 20);
            this.txtSelectDeviceResult.TabIndex = 49;
            // 
            // txtSelectDev
            // 
            this.txtSelectDev.Location = new System.Drawing.Point(111, 405);
            this.txtSelectDev.Name = "txtSelectDev";
            this.txtSelectDev.Size = new System.Drawing.Size(51, 20);
            this.txtSelectDev.TabIndex = 48;
            this.txtSelectDev.Text = "0";
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(32, 400);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 47;
            this.btnSelect.Text = "Select Device";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // txtInitDefault
            // 
            this.txtInitDefault.Location = new System.Drawing.Point(236, 21);
            this.txtInitDefault.Name = "txtInitDefault";
            this.txtInitDefault.Size = new System.Drawing.Size(249, 20);
            this.txtInitDefault.TabIndex = 46;
            // 
            // tabPageMeasurementConfiguration
            // 
            this.tabPageMeasurementConfiguration.Controls.Add(this.pnlMeasconfigCenter);
            this.tabPageMeasurementConfiguration.Controls.Add(this.pnlMeasconfigUpper);
            this.tabPageMeasurementConfiguration.Controls.Add(this.gbMeasPathAndFormats);
            this.tabPageMeasurementConfiguration.ImageKey = "preferences_system_x24.png";
            this.tabPageMeasurementConfiguration.Location = new System.Drawing.Point(4, 23);
            this.tabPageMeasurementConfiguration.Name = "tabPageMeasurementConfiguration";
            this.tabPageMeasurementConfiguration.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMeasurementConfiguration.Size = new System.Drawing.Size(1769, 690);
            this.tabPageMeasurementConfiguration.TabIndex = 2;
            this.tabPageMeasurementConfiguration.Text = "Measurement Configuration";
            this.tabPageMeasurementConfiguration.UseVisualStyleBackColor = true;
            // 
            // pnlMeasconfigCenter
            // 
            this.pnlMeasconfigCenter.Controls.Add(this.gbUserDefinedAttributes);
            this.pnlMeasconfigCenter.Controls.Add(this.gbMeasinfo);
            this.pnlMeasconfigCenter.Controls.Add(this.cbActualMeasConfiguration);
            this.pnlMeasconfigCenter.Controls.Add(this.gbMeasOptions);
            this.pnlMeasconfigCenter.Controls.Add(this.groupBox1);
            this.pnlMeasconfigCenter.Controls.Add(this.gbInputs);
            this.pnlMeasconfigCenter.Controls.Add(this.gbChannelAImpedance);
            this.pnlMeasconfigCenter.Controls.Add(this.gbChannelAVoltage);
            this.pnlMeasconfigCenter.Controls.Add(this.gbChannelBImpedance);
            this.pnlMeasconfigCenter.Controls.Add(this.gbChannelBVoltage);
            this.pnlMeasconfigCenter.Controls.Add(this.gbChannelBCoupling);
            this.pnlMeasconfigCenter.Controls.Add(this.gbChannelACoupling);
            this.pnlMeasconfigCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMeasconfigCenter.Location = new System.Drawing.Point(3, 58);
            this.pnlMeasconfigCenter.Name = "pnlMeasconfigCenter";
            this.pnlMeasconfigCenter.Size = new System.Drawing.Size(813, 629);
            this.pnlMeasconfigCenter.TabIndex = 66;
            // 
            // gbUserDefinedAttributes
            // 
            this.gbUserDefinedAttributes.Controls.Add(this.gbYOffset);
            this.gbUserDefinedAttributes.Location = new System.Drawing.Point(571, 195);
            this.gbUserDefinedAttributes.Name = "gbUserDefinedAttributes";
            this.gbUserDefinedAttributes.Size = new System.Drawing.Size(222, 194);
            this.gbUserDefinedAttributes.TabIndex = 66;
            this.gbUserDefinedAttributes.TabStop = false;
            this.gbUserDefinedAttributes.Text = "User defined attributes";
            // 
            // gbYOffset
            // 
            this.gbYOffset.Controls.Add(this.txtYOffset);
            this.gbYOffset.Location = new System.Drawing.Point(7, 29);
            this.gbYOffset.Name = "gbYOffset";
            this.gbYOffset.Size = new System.Drawing.Size(87, 38);
            this.gbYOffset.TabIndex = 46;
            this.gbYOffset.TabStop = false;
            this.gbYOffset.Text = "Y-Offset";
            // 
            // txtYOffset
            // 
            this.txtYOffset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtYOffset.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYOffset.Location = new System.Drawing.Point(3, 16);
            this.txtYOffset.Name = "txtYOffset";
            this.txtYOffset.Size = new System.Drawing.Size(81, 22);
            this.txtYOffset.TabIndex = 14;
            this.txtYOffset.Text = "0";
            // 
            // gbMeasinfo
            // 
            this.gbMeasinfo.Controls.Add(this.gbScaleYAxis);
            this.gbMeasinfo.Controls.Add(this.gbGraphLegend);
            this.gbMeasinfo.Controls.Add(this.gbXLegend);
            this.gbMeasinfo.Controls.Add(this.gbYLegend);
            this.gbMeasinfo.Controls.Add(this.gbMeasinfos);
            this.gbMeasinfo.Controls.Add(this.gbMeasname);
            this.gbMeasinfo.Location = new System.Drawing.Point(7, 6);
            this.gbMeasinfo.Name = "gbMeasinfo";
            this.gbMeasinfo.Size = new System.Drawing.Size(786, 184);
            this.gbMeasinfo.TabIndex = 52;
            this.gbMeasinfo.TabStop = false;
            this.gbMeasinfo.Text = "Measinfo";
            // 
            // gbScaleYAxis
            // 
            this.gbScaleYAxis.Controls.Add(this.txtScaleYAxis);
            this.gbScaleYAxis.Location = new System.Drawing.Point(513, 141);
            this.gbScaleYAxis.Name = "gbScaleYAxis";
            this.gbScaleYAxis.Size = new System.Drawing.Size(100, 40);
            this.gbScaleYAxis.TabIndex = 5;
            this.gbScaleYAxis.TabStop = false;
            this.gbScaleYAxis.Text = "Scale Y-Axis";
            // 
            // txtScaleYAxis
            // 
            this.txtScaleYAxis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtScaleYAxis.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScaleYAxis.Location = new System.Drawing.Point(3, 16);
            this.txtScaleYAxis.Name = "txtScaleYAxis";
            this.txtScaleYAxis.Size = new System.Drawing.Size(94, 22);
            this.txtScaleYAxis.TabIndex = 0;
            this.txtScaleYAxis.Text = "9";
            // 
            // gbGraphLegend
            // 
            this.gbGraphLegend.Controls.Add(this.txtGraphLegend);
            this.gbGraphLegend.Location = new System.Drawing.Point(510, 99);
            this.gbGraphLegend.Name = "gbGraphLegend";
            this.gbGraphLegend.Size = new System.Drawing.Size(238, 40);
            this.gbGraphLegend.TabIndex = 4;
            this.gbGraphLegend.TabStop = false;
            this.gbGraphLegend.Text = "Graph-Legend";
            // 
            // txtGraphLegend
            // 
            this.txtGraphLegend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGraphLegend.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGraphLegend.Location = new System.Drawing.Point(3, 16);
            this.txtGraphLegend.Name = "txtGraphLegend";
            this.txtGraphLegend.Size = new System.Drawing.Size(232, 22);
            this.txtGraphLegend.TabIndex = 0;
            this.txtGraphLegend.Text = "Phase A-B";
            // 
            // gbXLegend
            // 
            this.gbXLegend.Controls.Add(this.txtXLegend);
            this.gbXLegend.Location = new System.Drawing.Point(510, 53);
            this.gbXLegend.Name = "gbXLegend";
            this.gbXLegend.Size = new System.Drawing.Size(238, 40);
            this.gbXLegend.TabIndex = 3;
            this.gbXLegend.TabStop = false;
            this.gbXLegend.Text = "X-Legend";
            // 
            // txtXLegend
            // 
            this.txtXLegend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtXLegend.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXLegend.Location = new System.Drawing.Point(3, 16);
            this.txtXLegend.Name = "txtXLegend";
            this.txtXLegend.Size = new System.Drawing.Size(232, 22);
            this.txtXLegend.TabIndex = 0;
            this.txtXLegend.Text = "timestamp (s)";
            // 
            // gbYLegend
            // 
            this.gbYLegend.Controls.Add(this.txtYLegend);
            this.gbYLegend.Location = new System.Drawing.Point(510, 11);
            this.gbYLegend.Name = "gbYLegend";
            this.gbYLegend.Size = new System.Drawing.Size(238, 40);
            this.gbYLegend.TabIndex = 2;
            this.gbYLegend.TabStop = false;
            this.gbYLegend.Text = "Y-Legend";
            // 
            // txtYLegend
            // 
            this.txtYLegend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtYLegend.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYLegend.Location = new System.Drawing.Point(3, 16);
            this.txtYLegend.Name = "txtYLegend";
            this.txtYLegend.Size = new System.Drawing.Size(232, 22);
            this.txtYLegend.TabIndex = 0;
            this.txtYLegend.Text = "offset (ns)";
            // 
            // gbMeasinfos
            // 
            this.gbMeasinfos.Controls.Add(this.txtMeasinfo);
            this.gbMeasinfos.Location = new System.Drawing.Point(6, 65);
            this.gbMeasinfos.Name = "gbMeasinfos";
            this.gbMeasinfos.Size = new System.Drawing.Size(468, 112);
            this.gbMeasinfos.TabIndex = 1;
            this.gbMeasinfos.TabStop = false;
            this.gbMeasinfos.Text = "Measurementinfo";
            // 
            // txtMeasinfo
            // 
            this.txtMeasinfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMeasinfo.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMeasinfo.Location = new System.Drawing.Point(3, 16);
            this.txtMeasinfo.Multiline = true;
            this.txtMeasinfo.Name = "txtMeasinfo";
            this.txtMeasinfo.Size = new System.Drawing.Size(462, 93);
            this.txtMeasinfo.TabIndex = 0;
            // 
            // gbMeasname
            // 
            this.gbMeasname.Controls.Add(this.txtMeasname);
            this.gbMeasname.Location = new System.Drawing.Point(6, 19);
            this.gbMeasname.Name = "gbMeasname";
            this.gbMeasname.Size = new System.Drawing.Size(468, 40);
            this.gbMeasname.TabIndex = 0;
            this.gbMeasname.TabStop = false;
            this.gbMeasname.Text = "Measurementname";
            // 
            // txtMeasname
            // 
            this.txtMeasname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMeasname.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMeasname.Location = new System.Drawing.Point(3, 16);
            this.txtMeasname.Name = "txtMeasname";
            this.txtMeasname.Size = new System.Drawing.Size(462, 22);
            this.txtMeasname.TabIndex = 0;
            this.txtMeasname.TextChanged += new System.EventHandler(this.txtMeasname_TextChanged);
            // 
            // cbActualMeasConfiguration
            // 
            this.cbActualMeasConfiguration.Controls.Add(this.groupBox10);
            this.cbActualMeasConfiguration.Controls.Add(this.gbMeasconfigDevice);
            this.cbActualMeasConfiguration.Controls.Add(this.gbSleepAfterSingleRead);
            this.cbActualMeasConfiguration.Controls.Add(this.ckReadAllErrors);
            this.cbActualMeasConfiguration.Controls.Add(this.ckMemoryWrap);
            this.cbActualMeasConfiguration.Controls.Add(this.gbSleep);
            this.cbActualMeasConfiguration.Controls.Add(this.ckCal);
            this.cbActualMeasConfiguration.Controls.Add(this.gbMeasType);
            this.cbActualMeasConfiguration.Controls.Add(this.ckNewMeas);
            this.cbActualMeasConfiguration.Controls.Add(this.ckShowResults);
            this.cbActualMeasConfiguration.Controls.Add(this.ckReadRAW);
            this.cbActualMeasConfiguration.Controls.Add(this.ckTagsSucceded);
            this.cbActualMeasConfiguration.Location = new System.Drawing.Point(7, 194);
            this.cbActualMeasConfiguration.Name = "cbActualMeasConfiguration";
            this.cbActualMeasConfiguration.Size = new System.Drawing.Size(558, 195);
            this.cbActualMeasConfiguration.TabIndex = 0;
            this.cbActualMeasConfiguration.TabStop = false;
            this.cbActualMeasConfiguration.Text = "Measconfiguration";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.ckChannel0);
            this.groupBox10.Controls.Add(this.ckChannel1);
            this.groupBox10.Location = new System.Drawing.Point(200, 17);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(132, 64);
            this.groupBox10.TabIndex = 56;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Channels";
            // 
            // gbMeasconfigDevice
            // 
            this.gbMeasconfigDevice.Controls.Add(this.cbMeasconfigDevice);
            this.gbMeasconfigDevice.Location = new System.Drawing.Point(6, 17);
            this.gbMeasconfigDevice.Name = "gbMeasconfigDevice";
            this.gbMeasconfigDevice.Size = new System.Drawing.Size(184, 37);
            this.gbMeasconfigDevice.TabIndex = 55;
            this.gbMeasconfigDevice.TabStop = false;
            this.gbMeasconfigDevice.Text = "Device";
            // 
            // cbMeasconfigDevice
            // 
            this.cbMeasconfigDevice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbMeasconfigDevice.FormattingEnabled = true;
            this.cbMeasconfigDevice.Location = new System.Drawing.Point(3, 16);
            this.cbMeasconfigDevice.Name = "cbMeasconfigDevice";
            this.cbMeasconfigDevice.Size = new System.Drawing.Size(178, 21);
            this.cbMeasconfigDevice.TabIndex = 51;
            // 
            // gbSleepAfterSingleRead
            // 
            this.gbSleepAfterSingleRead.Controls.Add(this.txtSleepEverySingleRead);
            this.gbSleepAfterSingleRead.Location = new System.Drawing.Point(401, 150);
            this.gbSleepAfterSingleRead.Name = "gbSleepAfterSingleRead";
            this.gbSleepAfterSingleRead.Size = new System.Drawing.Size(132, 38);
            this.gbSleepAfterSingleRead.TabIndex = 54;
            this.gbSleepAfterSingleRead.TabStop = false;
            this.gbSleepAfterSingleRead.Text = "Sleep single read (ms)";
            // 
            // txtSleepEverySingleRead
            // 
            this.txtSleepEverySingleRead.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSleepEverySingleRead.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSleepEverySingleRead.Location = new System.Drawing.Point(3, 16);
            this.txtSleepEverySingleRead.Name = "txtSleepEverySingleRead";
            this.txtSleepEverySingleRead.Size = new System.Drawing.Size(126, 22);
            this.txtSleepEverySingleRead.TabIndex = 13;
            this.txtSleepEverySingleRead.Text = "5";
            // 
            // gbMeasType
            // 
            this.gbMeasType.Controls.Add(this.rbFrequency_A_B);
            this.gbMeasType.Controls.Add(this.rbFrequencyA);
            this.gbMeasType.Controls.Add(this.rbPhaseAB);
            this.gbMeasType.Location = new System.Drawing.Point(5, 67);
            this.gbMeasType.Name = "gbMeasType";
            this.gbMeasType.Size = new System.Drawing.Size(148, 84);
            this.gbMeasType.TabIndex = 48;
            this.gbMeasType.TabStop = false;
            this.gbMeasType.Text = "Meastype";
            // 
            // rbFrequency_A_B
            // 
            this.rbFrequency_A_B.AutoSize = true;
            this.rbFrequency_A_B.Location = new System.Drawing.Point(6, 65);
            this.rbFrequency_A_B.Name = "rbFrequency_A_B";
            this.rbFrequency_A_B.Size = new System.Drawing.Size(95, 17);
            this.rbFrequency_A_B.TabIndex = 2;
            this.rbFrequency_A_B.Text = "Frequency A-B";
            this.rbFrequency_A_B.UseVisualStyleBackColor = true;
            // 
            // rbFrequencyA
            // 
            this.rbFrequencyA.AutoSize = true;
            this.rbFrequencyA.Location = new System.Drawing.Point(6, 42);
            this.rbFrequencyA.Name = "rbFrequencyA";
            this.rbFrequencyA.Size = new System.Drawing.Size(85, 17);
            this.rbFrequencyA.TabIndex = 1;
            this.rbFrequencyA.Text = "Frequency A";
            this.rbFrequencyA.UseVisualStyleBackColor = true;
            // 
            // rbPhaseAB
            // 
            this.rbPhaseAB.AutoSize = true;
            this.rbPhaseAB.Checked = true;
            this.rbPhaseAB.Location = new System.Drawing.Point(6, 19);
            this.rbPhaseAB.Name = "rbPhaseAB";
            this.rbPhaseAB.Size = new System.Drawing.Size(75, 17);
            this.rbPhaseAB.TabIndex = 0;
            this.rbPhaseAB.TabStop = true;
            this.rbPhaseAB.Text = "Phase A-B";
            this.rbPhaseAB.UseVisualStyleBackColor = true;
            this.rbPhaseAB.CheckedChanged += new System.EventHandler(this.pbMeastype_CheckedChanged);
            // 
            // gbMeasOptions
            // 
            this.gbMeasOptions.Controls.Add(this.gbMeasGate1);
            this.gbMeasOptions.Controls.Add(this.gbMeasGate0);
            this.gbMeasOptions.Controls.Add(this.gbNumTags1);
            this.gbMeasOptions.Controls.Add(this.gbMeasSkip1);
            this.gbMeasOptions.Controls.Add(this.gbMeasSkip);
            this.gbMeasOptions.Controls.Add(this.gbNumTags0);
            this.gbMeasOptions.Location = new System.Drawing.Point(249, 396);
            this.gbMeasOptions.Name = "gbMeasOptions";
            this.gbMeasOptions.Size = new System.Drawing.Size(180, 226);
            this.gbMeasOptions.TabIndex = 46;
            this.gbMeasOptions.TabStop = false;
            this.gbMeasOptions.Text = "Meas channel options";
            // 
            // gbMeasGate1
            // 
            this.gbMeasGate1.Controls.Add(this.txtMeasGate1);
            this.gbMeasGate1.Location = new System.Drawing.Point(87, 63);
            this.gbMeasGate1.Name = "gbMeasGate1";
            this.gbMeasGate1.Size = new System.Drawing.Size(86, 38);
            this.gbMeasGate1.TabIndex = 48;
            this.gbMeasGate1.TabStop = false;
            this.gbMeasGate1.Text = "MeasGate1";
            // 
            // txtMeasGate1
            // 
            this.txtMeasGate1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMeasGate1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMeasGate1.Location = new System.Drawing.Point(3, 16);
            this.txtMeasGate1.Name = "txtMeasGate1";
            this.txtMeasGate1.Size = new System.Drawing.Size(80, 22);
            this.txtMeasGate1.TabIndex = 13;
            this.txtMeasGate1.Text = "1";
            // 
            // gbMeasGate0
            // 
            this.gbMeasGate0.Controls.Add(this.txtMeasGate0);
            this.gbMeasGate0.Location = new System.Drawing.Point(91, 19);
            this.gbMeasGate0.Name = "gbMeasGate0";
            this.gbMeasGate0.Size = new System.Drawing.Size(83, 38);
            this.gbMeasGate0.TabIndex = 47;
            this.gbMeasGate0.TabStop = false;
            this.gbMeasGate0.Text = "MeasGate 0";
            // 
            // txtMeasGate0
            // 
            this.txtMeasGate0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMeasGate0.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMeasGate0.Location = new System.Drawing.Point(3, 16);
            this.txtMeasGate0.Name = "txtMeasGate0";
            this.txtMeasGate0.Size = new System.Drawing.Size(77, 22);
            this.txtMeasGate0.TabIndex = 13;
            this.txtMeasGate0.Text = "1";
            // 
            // gbNumTags1
            // 
            this.gbNumTags1.Controls.Add(this.txtNumTags1);
            this.gbNumTags1.Location = new System.Drawing.Point(7, 63);
            this.gbNumTags1.Name = "gbNumTags1";
            this.gbNumTags1.Size = new System.Drawing.Size(77, 38);
            this.gbNumTags1.TabIndex = 46;
            this.gbNumTags1.TabStop = false;
            this.gbNumTags1.Text = "NumTags 1";
            // 
            // txtNumTags1
            // 
            this.txtNumTags1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNumTags1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumTags1.Location = new System.Drawing.Point(3, 16);
            this.txtNumTags1.Name = "txtNumTags1";
            this.txtNumTags1.Size = new System.Drawing.Size(71, 22);
            this.txtNumTags1.TabIndex = 13;
            this.txtNumTags1.Text = "1";
            // 
            // gbMeasSkip1
            // 
            this.gbMeasSkip1.Controls.Add(this.txtMeasSkipCh1);
            this.gbMeasSkip1.Location = new System.Drawing.Point(6, 168);
            this.gbMeasSkip1.Name = "gbMeasSkip1";
            this.gbMeasSkip1.Size = new System.Drawing.Size(87, 46);
            this.gbMeasSkip1.TabIndex = 45;
            this.gbMeasSkip1.TabStop = false;
            this.gbMeasSkip1.Text = "Meas Skip 1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gbClockExternFreq);
            this.groupBox1.Controls.Add(this.gbSelectClock);
            this.groupBox1.Controls.Add(this.gbThresholdClock);
            this.groupBox1.Location = new System.Drawing.Point(136, 396);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(108, 226);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Clocks";
            // 
            // gbClockExternFreq
            // 
            this.gbClockExternFreq.Controls.Add(this.rbClock10MHZ);
            this.gbClockExternFreq.Controls.Add(this.rbClock5MHZ);
            this.gbClockExternFreq.Location = new System.Drawing.Point(6, 83);
            this.gbClockExternFreq.Name = "gbClockExternFreq";
            this.gbClockExternFreq.Size = new System.Drawing.Size(76, 57);
            this.gbClockExternFreq.TabIndex = 51;
            this.gbClockExternFreq.TabStop = false;
            this.gbClockExternFreq.Text = "Freq";
            // 
            // rbClock10MHZ
            // 
            this.rbClock10MHZ.AutoSize = true;
            this.rbClock10MHZ.Checked = true;
            this.rbClock10MHZ.Location = new System.Drawing.Point(6, 20);
            this.rbClock10MHZ.Name = "rbClock10MHZ";
            this.rbClock10MHZ.Size = new System.Drawing.Size(60, 17);
            this.rbClock10MHZ.TabIndex = 48;
            this.rbClock10MHZ.TabStop = true;
            this.rbClock10MHZ.Text = "10 Mhz";
            this.rbClock10MHZ.UseVisualStyleBackColor = true;
            // 
            // rbClock5MHZ
            // 
            this.rbClock5MHZ.AutoSize = true;
            this.rbClock5MHZ.Location = new System.Drawing.Point(6, 37);
            this.rbClock5MHZ.Name = "rbClock5MHZ";
            this.rbClock5MHZ.Size = new System.Drawing.Size(54, 17);
            this.rbClock5MHZ.TabIndex = 49;
            this.rbClock5MHZ.Text = "5 Mhz";
            this.rbClock5MHZ.UseVisualStyleBackColor = true;
            // 
            // gbSelectClock
            // 
            this.gbSelectClock.Controls.Add(this.rbUseInternClock);
            this.gbSelectClock.Controls.Add(this.rbClockUseExtern);
            this.gbSelectClock.Location = new System.Drawing.Point(6, 16);
            this.gbSelectClock.Name = "gbSelectClock";
            this.gbSelectClock.Size = new System.Drawing.Size(68, 57);
            this.gbSelectClock.TabIndex = 50;
            this.gbSelectClock.TabStop = false;
            this.gbSelectClock.Text = "Select";
            // 
            // rbUseInternClock
            // 
            this.rbUseInternClock.AutoSize = true;
            this.rbUseInternClock.Location = new System.Drawing.Point(6, 20);
            this.rbUseInternClock.Name = "rbUseInternClock";
            this.rbUseInternClock.Size = new System.Drawing.Size(52, 17);
            this.rbUseInternClock.TabIndex = 48;
            this.rbUseInternClock.Text = "Intern";
            this.rbUseInternClock.UseVisualStyleBackColor = true;
            this.rbUseInternClock.CheckedChanged += new System.EventHandler(this.rbUseClock_CheckedChanged);
            // 
            // rbClockUseExtern
            // 
            this.rbClockUseExtern.AutoSize = true;
            this.rbClockUseExtern.Checked = true;
            this.rbClockUseExtern.Location = new System.Drawing.Point(6, 37);
            this.rbClockUseExtern.Name = "rbClockUseExtern";
            this.rbClockUseExtern.Size = new System.Drawing.Size(55, 17);
            this.rbClockUseExtern.TabIndex = 49;
            this.rbClockUseExtern.TabStop = true;
            this.rbClockUseExtern.Text = "Extern";
            this.rbClockUseExtern.UseVisualStyleBackColor = true;
            this.rbClockUseExtern.CheckedChanged += new System.EventHandler(this.rbUseClock_CheckedChanged);
            // 
            // gbThresholdClock
            // 
            this.gbThresholdClock.Controls.Add(this.txtThresholdClock);
            this.gbThresholdClock.Location = new System.Drawing.Point(6, 151);
            this.gbThresholdClock.Name = "gbThresholdClock";
            this.gbThresholdClock.Size = new System.Drawing.Size(96, 38);
            this.gbThresholdClock.TabIndex = 47;
            this.gbThresholdClock.TabStop = false;
            this.gbThresholdClock.Text = "Treshold Clock";
            // 
            // txtThresholdClock
            // 
            this.txtThresholdClock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtThresholdClock.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThresholdClock.Location = new System.Drawing.Point(3, 16);
            this.txtThresholdClock.Name = "txtThresholdClock";
            this.txtThresholdClock.Size = new System.Drawing.Size(90, 22);
            this.txtThresholdClock.TabIndex = 13;
            this.txtThresholdClock.Text = "0.7";
            // 
            // gbInputs
            // 
            this.gbInputs.Controls.Add(this.gbTresholdB);
            this.gbInputs.Controls.Add(this.gbTresholdA);
            this.gbInputs.Controls.Add(this.groupBox5);
            this.gbInputs.Controls.Add(this.gbPrescaleA);
            this.gbInputs.Location = new System.Drawing.Point(7, 396);
            this.gbInputs.Name = "gbInputs";
            this.gbInputs.Size = new System.Drawing.Size(124, 226);
            this.gbInputs.TabIndex = 47;
            this.gbInputs.TabStop = false;
            this.gbInputs.Text = "Channel options";
            // 
            // gbTresholdB
            // 
            this.gbTresholdB.Controls.Add(this.txtThresholdB);
            this.gbTresholdB.Location = new System.Drawing.Point(6, 156);
            this.gbTresholdB.Name = "gbTresholdB";
            this.gbTresholdB.Size = new System.Drawing.Size(79, 38);
            this.gbTresholdB.TabIndex = 46;
            this.gbTresholdB.TabStop = false;
            this.gbTresholdB.Text = "TresholdB";
            // 
            // txtThresholdB
            // 
            this.txtThresholdB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtThresholdB.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThresholdB.Location = new System.Drawing.Point(3, 16);
            this.txtThresholdB.Name = "txtThresholdB";
            this.txtThresholdB.Size = new System.Drawing.Size(73, 22);
            this.txtThresholdB.TabIndex = 13;
            this.txtThresholdB.Text = "0.7";
            // 
            // gbTresholdA
            // 
            this.gbTresholdA.Controls.Add(this.txtThresholdA);
            this.gbTresholdA.Location = new System.Drawing.Point(6, 111);
            this.gbTresholdA.Name = "gbTresholdA";
            this.gbTresholdA.Size = new System.Drawing.Size(79, 38);
            this.gbTresholdA.TabIndex = 45;
            this.gbTresholdA.TabStop = false;
            this.gbTresholdA.Text = "ThresholdA";
            // 
            // txtThresholdA
            // 
            this.txtThresholdA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtThresholdA.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThresholdA.Location = new System.Drawing.Point(3, 16);
            this.txtThresholdA.Name = "txtThresholdA";
            this.txtThresholdA.Size = new System.Drawing.Size(73, 22);
            this.txtThresholdA.TabIndex = 13;
            this.txtThresholdA.Text = "0.7";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cbPrescaleB);
            this.groupBox5.Location = new System.Drawing.Point(6, 64);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(107, 37);
            this.groupBox5.TabIndex = 44;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "PrescaleB";
            // 
            // cbPrescaleB
            // 
            this.cbPrescaleB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbPrescaleB.FormattingEnabled = true;
            this.cbPrescaleB.Location = new System.Drawing.Point(3, 16);
            this.cbPrescaleB.Name = "cbPrescaleB";
            this.cbPrescaleB.Size = new System.Drawing.Size(101, 21);
            this.cbPrescaleB.TabIndex = 52;
            // 
            // gbPrescaleA
            // 
            this.gbPrescaleA.Controls.Add(this.cbPrescaleA);
            this.gbPrescaleA.Location = new System.Drawing.Point(6, 19);
            this.gbPrescaleA.Name = "gbPrescaleA";
            this.gbPrescaleA.Size = new System.Drawing.Size(107, 37);
            this.gbPrescaleA.TabIndex = 43;
            this.gbPrescaleA.TabStop = false;
            this.gbPrescaleA.Text = "PrescaleA";
            // 
            // cbPrescaleA
            // 
            this.cbPrescaleA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbPrescaleA.FormattingEnabled = true;
            this.cbPrescaleA.Location = new System.Drawing.Point(3, 16);
            this.cbPrescaleA.Name = "cbPrescaleA";
            this.cbPrescaleA.Size = new System.Drawing.Size(101, 21);
            this.cbPrescaleA.TabIndex = 51;
            // 
            // gbChannelAImpedance
            // 
            this.gbChannelAImpedance.Controls.Add(this.rbChannelAImpedanceHIGH);
            this.gbChannelAImpedance.Controls.Add(this.rbChannelAImpedanceLO);
            this.gbChannelAImpedance.Location = new System.Drawing.Point(549, 396);
            this.gbChannelAImpedance.Name = "gbChannelAImpedance";
            this.gbChannelAImpedance.Size = new System.Drawing.Size(125, 78);
            this.gbChannelAImpedance.TabIndex = 62;
            this.gbChannelAImpedance.TabStop = false;
            this.gbChannelAImpedance.Text = "Channel A impedance";
            // 
            // rbChannelAImpedanceHIGH
            // 
            this.rbChannelAImpedanceHIGH.AutoSize = true;
            this.rbChannelAImpedanceHIGH.Location = new System.Drawing.Point(11, 53);
            this.rbChannelAImpedanceHIGH.Name = "rbChannelAImpedanceHIGH";
            this.rbChannelAImpedanceHIGH.Size = new System.Drawing.Size(46, 17);
            this.rbChannelAImpedanceHIGH.TabIndex = 1;
            this.rbChannelAImpedanceHIGH.Text = "1KΩ";
            this.rbChannelAImpedanceHIGH.UseVisualStyleBackColor = true;
            // 
            // rbChannelAImpedanceLO
            // 
            this.rbChannelAImpedanceLO.AutoSize = true;
            this.rbChannelAImpedanceLO.Checked = true;
            this.rbChannelAImpedanceLO.Location = new System.Drawing.Point(11, 26);
            this.rbChannelAImpedanceLO.Name = "rbChannelAImpedanceLO";
            this.rbChannelAImpedanceLO.Size = new System.Drawing.Size(48, 17);
            this.rbChannelAImpedanceLO.TabIndex = 0;
            this.rbChannelAImpedanceLO.TabStop = true;
            this.rbChannelAImpedanceLO.Text = "50 Ω";
            this.rbChannelAImpedanceLO.UseVisualStyleBackColor = true;
            // 
            // gbChannelAVoltage
            // 
            this.gbChannelAVoltage.Controls.Add(this.rbChannelANegativeVoltage);
            this.gbChannelAVoltage.Controls.Add(this.rbChannelAPositiveVoltage);
            this.gbChannelAVoltage.Location = new System.Drawing.Point(435, 396);
            this.gbChannelAVoltage.Name = "gbChannelAVoltage";
            this.gbChannelAVoltage.Size = new System.Drawing.Size(110, 78);
            this.gbChannelAVoltage.TabIndex = 57;
            this.gbChannelAVoltage.TabStop = false;
            this.gbChannelAVoltage.Text = "Channel A voltage";
            // 
            // rbChannelANegativeVoltage
            // 
            this.rbChannelANegativeVoltage.AutoSize = true;
            this.rbChannelANegativeVoltage.Location = new System.Drawing.Point(11, 53);
            this.rbChannelANegativeVoltage.Name = "rbChannelANegativeVoltage";
            this.rbChannelANegativeVoltage.Size = new System.Drawing.Size(68, 17);
            this.rbChannelANegativeVoltage.TabIndex = 1;
            this.rbChannelANegativeVoltage.Text = "Negative";
            this.rbChannelANegativeVoltage.UseVisualStyleBackColor = true;
            // 
            // rbChannelAPositiveVoltage
            // 
            this.rbChannelAPositiveVoltage.AutoSize = true;
            this.rbChannelAPositiveVoltage.Checked = true;
            this.rbChannelAPositiveVoltage.Location = new System.Drawing.Point(11, 26);
            this.rbChannelAPositiveVoltage.Name = "rbChannelAPositiveVoltage";
            this.rbChannelAPositiveVoltage.Size = new System.Drawing.Size(62, 17);
            this.rbChannelAPositiveVoltage.TabIndex = 0;
            this.rbChannelAPositiveVoltage.TabStop = true;
            this.rbChannelAPositiveVoltage.Text = "Positive";
            this.rbChannelAPositiveVoltage.UseVisualStyleBackColor = true;
            // 
            // gbChannelBImpedance
            // 
            this.gbChannelBImpedance.Controls.Add(this.rbChannelBImpedanceHIGH);
            this.gbChannelBImpedance.Controls.Add(this.rbChannelBImpedanceLO);
            this.gbChannelBImpedance.Location = new System.Drawing.Point(549, 482);
            this.gbChannelBImpedance.Name = "gbChannelBImpedance";
            this.gbChannelBImpedance.Size = new System.Drawing.Size(125, 78);
            this.gbChannelBImpedance.TabIndex = 61;
            this.gbChannelBImpedance.TabStop = false;
            this.gbChannelBImpedance.Text = "Channel B impedance";
            // 
            // rbChannelBImpedanceHIGH
            // 
            this.rbChannelBImpedanceHIGH.AutoSize = true;
            this.rbChannelBImpedanceHIGH.Location = new System.Drawing.Point(11, 53);
            this.rbChannelBImpedanceHIGH.Name = "rbChannelBImpedanceHIGH";
            this.rbChannelBImpedanceHIGH.Size = new System.Drawing.Size(46, 17);
            this.rbChannelBImpedanceHIGH.TabIndex = 1;
            this.rbChannelBImpedanceHIGH.Text = "1KΩ";
            this.rbChannelBImpedanceHIGH.UseVisualStyleBackColor = true;
            // 
            // rbChannelBImpedanceLO
            // 
            this.rbChannelBImpedanceLO.AutoSize = true;
            this.rbChannelBImpedanceLO.Checked = true;
            this.rbChannelBImpedanceLO.Location = new System.Drawing.Point(11, 26);
            this.rbChannelBImpedanceLO.Name = "rbChannelBImpedanceLO";
            this.rbChannelBImpedanceLO.Size = new System.Drawing.Size(48, 17);
            this.rbChannelBImpedanceLO.TabIndex = 0;
            this.rbChannelBImpedanceLO.TabStop = true;
            this.rbChannelBImpedanceLO.Text = "50 Ω";
            this.rbChannelBImpedanceLO.UseVisualStyleBackColor = true;
            // 
            // gbChannelBVoltage
            // 
            this.gbChannelBVoltage.Controls.Add(this.rbChannelBNegativeVoltage);
            this.gbChannelBVoltage.Controls.Add(this.rbChannelBPositiveVoltage);
            this.gbChannelBVoltage.Location = new System.Drawing.Point(435, 481);
            this.gbChannelBVoltage.Name = "gbChannelBVoltage";
            this.gbChannelBVoltage.Size = new System.Drawing.Size(110, 79);
            this.gbChannelBVoltage.TabIndex = 58;
            this.gbChannelBVoltage.TabStop = false;
            this.gbChannelBVoltage.Text = "Channel B voltage";
            // 
            // rbChannelBNegativeVoltage
            // 
            this.rbChannelBNegativeVoltage.AutoSize = true;
            this.rbChannelBNegativeVoltage.Location = new System.Drawing.Point(11, 53);
            this.rbChannelBNegativeVoltage.Name = "rbChannelBNegativeVoltage";
            this.rbChannelBNegativeVoltage.Size = new System.Drawing.Size(68, 17);
            this.rbChannelBNegativeVoltage.TabIndex = 1;
            this.rbChannelBNegativeVoltage.Text = "Negative";
            this.rbChannelBNegativeVoltage.UseVisualStyleBackColor = true;
            // 
            // rbChannelBPositiveVoltage
            // 
            this.rbChannelBPositiveVoltage.AutoSize = true;
            this.rbChannelBPositiveVoltage.Checked = true;
            this.rbChannelBPositiveVoltage.Location = new System.Drawing.Point(11, 26);
            this.rbChannelBPositiveVoltage.Name = "rbChannelBPositiveVoltage";
            this.rbChannelBPositiveVoltage.Size = new System.Drawing.Size(62, 17);
            this.rbChannelBPositiveVoltage.TabIndex = 0;
            this.rbChannelBPositiveVoltage.TabStop = true;
            this.rbChannelBPositiveVoltage.Text = "Positive";
            this.rbChannelBPositiveVoltage.UseVisualStyleBackColor = true;
            // 
            // gbChannelBCoupling
            // 
            this.gbChannelBCoupling.Controls.Add(this.rbChannelBCouplingAC);
            this.gbChannelBCoupling.Controls.Add(this.rbChannelBCouplingDC);
            this.gbChannelBCoupling.Location = new System.Drawing.Point(678, 482);
            this.gbChannelBCoupling.Name = "gbChannelBCoupling";
            this.gbChannelBCoupling.Size = new System.Drawing.Size(116, 78);
            this.gbChannelBCoupling.TabIndex = 60;
            this.gbChannelBCoupling.TabStop = false;
            this.gbChannelBCoupling.Text = "Channel B coupling";
            // 
            // rbChannelBCouplingAC
            // 
            this.rbChannelBCouplingAC.AutoSize = true;
            this.rbChannelBCouplingAC.Location = new System.Drawing.Point(11, 53);
            this.rbChannelBCouplingAC.Name = "rbChannelBCouplingAC";
            this.rbChannelBCouplingAC.Size = new System.Drawing.Size(39, 17);
            this.rbChannelBCouplingAC.TabIndex = 1;
            this.rbChannelBCouplingAC.Text = "AC";
            this.rbChannelBCouplingAC.UseVisualStyleBackColor = true;
            // 
            // rbChannelBCouplingDC
            // 
            this.rbChannelBCouplingDC.AutoSize = true;
            this.rbChannelBCouplingDC.Checked = true;
            this.rbChannelBCouplingDC.Location = new System.Drawing.Point(11, 26);
            this.rbChannelBCouplingDC.Name = "rbChannelBCouplingDC";
            this.rbChannelBCouplingDC.Size = new System.Drawing.Size(40, 17);
            this.rbChannelBCouplingDC.TabIndex = 0;
            this.rbChannelBCouplingDC.TabStop = true;
            this.rbChannelBCouplingDC.Text = "DC";
            this.rbChannelBCouplingDC.UseVisualStyleBackColor = true;
            // 
            // gbChannelACoupling
            // 
            this.gbChannelACoupling.Controls.Add(this.rbChannelACouplingAC);
            this.gbChannelACoupling.Controls.Add(this.rbChannelACouplingDC);
            this.gbChannelACoupling.Location = new System.Drawing.Point(678, 396);
            this.gbChannelACoupling.Name = "gbChannelACoupling";
            this.gbChannelACoupling.Size = new System.Drawing.Size(116, 78);
            this.gbChannelACoupling.TabIndex = 59;
            this.gbChannelACoupling.TabStop = false;
            this.gbChannelACoupling.Text = "Channel A coupling";
            // 
            // rbChannelACouplingAC
            // 
            this.rbChannelACouplingAC.AutoSize = true;
            this.rbChannelACouplingAC.Location = new System.Drawing.Point(11, 53);
            this.rbChannelACouplingAC.Name = "rbChannelACouplingAC";
            this.rbChannelACouplingAC.Size = new System.Drawing.Size(39, 17);
            this.rbChannelACouplingAC.TabIndex = 1;
            this.rbChannelACouplingAC.Text = "AC";
            this.rbChannelACouplingAC.UseVisualStyleBackColor = true;
            // 
            // rbChannelACouplingDC
            // 
            this.rbChannelACouplingDC.AutoSize = true;
            this.rbChannelACouplingDC.Checked = true;
            this.rbChannelACouplingDC.Location = new System.Drawing.Point(11, 26);
            this.rbChannelACouplingDC.Name = "rbChannelACouplingDC";
            this.rbChannelACouplingDC.Size = new System.Drawing.Size(40, 17);
            this.rbChannelACouplingDC.TabIndex = 0;
            this.rbChannelACouplingDC.TabStop = true;
            this.rbChannelACouplingDC.Text = "DC";
            this.rbChannelACouplingDC.UseVisualStyleBackColor = true;
            // 
            // pnlMeasconfigUpper
            // 
            this.pnlMeasconfigUpper.BackColor = System.Drawing.Color.LightGray;
            this.pnlMeasconfigUpper.Controls.Add(this.gbConfigurationFile);
            this.pnlMeasconfigUpper.Controls.Add(this.hsSaveMeasconfiguration);
            this.pnlMeasconfigUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMeasconfigUpper.Location = new System.Drawing.Point(3, 3);
            this.pnlMeasconfigUpper.Name = "pnlMeasconfigUpper";
            this.pnlMeasconfigUpper.Size = new System.Drawing.Size(813, 55);
            this.pnlMeasconfigUpper.TabIndex = 67;
            // 
            // gbConfigurationFile
            // 
            this.gbConfigurationFile.Controls.Add(this.txtConfigurationFile);
            this.gbConfigurationFile.Controls.Add(this.hsLoadConfigurationFile);
            this.gbConfigurationFile.Location = new System.Drawing.Point(7, 9);
            this.gbConfigurationFile.Name = "gbConfigurationFile";
            this.gbConfigurationFile.Size = new System.Drawing.Size(765, 40);
            this.gbConfigurationFile.TabIndex = 2;
            this.gbConfigurationFile.TabStop = false;
            this.gbConfigurationFile.Text = "Configuration file";
            // 
            // txtConfigurationFile
            // 
            this.txtConfigurationFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtConfigurationFile.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfigurationFile.Location = new System.Drawing.Point(3, 16);
            this.txtConfigurationFile.Name = "txtConfigurationFile";
            this.txtConfigurationFile.Size = new System.Drawing.Size(714, 20);
            this.txtConfigurationFile.TabIndex = 0;
            this.txtConfigurationFile.TextChanged += new System.EventHandler(this.txtConfigurationFile_TextChanged);
            // 
            // hsLoadConfigurationFile
            // 
            this.hsLoadConfigurationFile.BackColor = System.Drawing.Color.Transparent;
            this.hsLoadConfigurationFile.BackColorHover = System.Drawing.Color.Transparent;
            this.hsLoadConfigurationFile.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsLoadConfigurationFile.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsLoadConfigurationFile.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsLoadConfigurationFile.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsLoadConfigurationFile.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsLoadConfigurationFile.Dock = System.Windows.Forms.DockStyle.Right;
            this.hsLoadConfigurationFile.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.hsLoadConfigurationFile.FlatAppearance.BorderSize = 0;
            this.hsLoadConfigurationFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsLoadConfigurationFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsLoadConfigurationFile.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsLoadConfigurationFile.Image = global::PRCCounterApp.Properties.Resources.folder_closed_22x;
            this.hsLoadConfigurationFile.ImageHover = global::PRCCounterApp.Properties.Resources.folder_open_22x;
            this.hsLoadConfigurationFile.ImageToggleOnSelect = false;
            this.hsLoadConfigurationFile.Location = new System.Drawing.Point(717, 16);
            this.hsLoadConfigurationFile.Marked = false;
            this.hsLoadConfigurationFile.MarkedColor = System.Drawing.Color.Teal;
            this.hsLoadConfigurationFile.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsLoadConfigurationFile.MarkedText = "";
            this.hsLoadConfigurationFile.MarkMode = false;
            this.hsLoadConfigurationFile.Name = "hsLoadConfigurationFile";
            this.hsLoadConfigurationFile.NonMarkedText = "";
            this.hsLoadConfigurationFile.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsLoadConfigurationFile.ShowShortcut = false;
            this.hsLoadConfigurationFile.Size = new System.Drawing.Size(45, 21);
            this.hsLoadConfigurationFile.TabIndex = 20;
            this.hsLoadConfigurationFile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsLoadConfigurationFile.ToolTipActive = false;
            this.hsLoadConfigurationFile.ToolTipAutomaticDelay = 500;
            this.hsLoadConfigurationFile.ToolTipAutoPopDelay = 5000;
            this.hsLoadConfigurationFile.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsLoadConfigurationFile.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsLoadConfigurationFile.ToolTipFor4ContextMenu = true;
            this.hsLoadConfigurationFile.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsLoadConfigurationFile.ToolTipInitialDelay = 500;
            this.hsLoadConfigurationFile.ToolTipIsBallon = false;
            this.hsLoadConfigurationFile.ToolTipOwnerDraw = false;
            this.hsLoadConfigurationFile.ToolTipReshowDelay = 100;
            this.hsLoadConfigurationFile.ToolTipShowAlways = false;
            this.hsLoadConfigurationFile.ToolTipText = "";
            this.hsLoadConfigurationFile.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsLoadConfigurationFile.ToolTipTitle = "";
            this.hsLoadConfigurationFile.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsLoadConfigurationFile.UseVisualStyleBackColor = false;
            this.hsLoadConfigurationFile.Click += new System.EventHandler(this.hsLoadConfigurationFile_Click);
            // 
            // hsSaveMeasconfiguration
            // 
            this.hsSaveMeasconfiguration.BackColor = System.Drawing.Color.Transparent;
            this.hsSaveMeasconfiguration.BackColorHover = System.Drawing.Color.Transparent;
            this.hsSaveMeasconfiguration.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsSaveMeasconfiguration.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsSaveMeasconfiguration.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsSaveMeasconfiguration.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsSaveMeasconfiguration.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsSaveMeasconfiguration.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.hsSaveMeasconfiguration.FlatAppearance.BorderSize = 0;
            this.hsSaveMeasconfiguration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsSaveMeasconfiguration.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsSaveMeasconfiguration.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsSaveMeasconfiguration.Image = global::PRCCounterApp.Properties.Resources.floppy_x24;
            this.hsSaveMeasconfiguration.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hsSaveMeasconfiguration.ImageHover = global::PRCCounterApp.Properties.Resources.floppy2_x24;
            this.hsSaveMeasconfiguration.ImageToggleOnSelect = false;
            this.hsSaveMeasconfiguration.Location = new System.Drawing.Point(772, 16);
            this.hsSaveMeasconfiguration.Marked = false;
            this.hsSaveMeasconfiguration.MarkedColor = System.Drawing.Color.Teal;
            this.hsSaveMeasconfiguration.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsSaveMeasconfiguration.MarkedText = "";
            this.hsSaveMeasconfiguration.MarkMode = false;
            this.hsSaveMeasconfiguration.Name = "hsSaveMeasconfiguration";
            this.hsSaveMeasconfiguration.NonMarkedText = "";
            this.hsSaveMeasconfiguration.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsSaveMeasconfiguration.ShowShortcut = false;
            this.hsSaveMeasconfiguration.Size = new System.Drawing.Size(35, 36);
            this.hsSaveMeasconfiguration.TabIndex = 64;
            this.hsSaveMeasconfiguration.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hsSaveMeasconfiguration.ToolTipActive = false;
            this.hsSaveMeasconfiguration.ToolTipAutomaticDelay = 500;
            this.hsSaveMeasconfiguration.ToolTipAutoPopDelay = 5000;
            this.hsSaveMeasconfiguration.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsSaveMeasconfiguration.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsSaveMeasconfiguration.ToolTipFor4ContextMenu = true;
            this.hsSaveMeasconfiguration.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsSaveMeasconfiguration.ToolTipInitialDelay = 500;
            this.hsSaveMeasconfiguration.ToolTipIsBallon = false;
            this.hsSaveMeasconfiguration.ToolTipOwnerDraw = false;
            this.hsSaveMeasconfiguration.ToolTipReshowDelay = 100;
            this.hsSaveMeasconfiguration.ToolTipShowAlways = false;
            this.hsSaveMeasconfiguration.ToolTipText = "";
            this.hsSaveMeasconfiguration.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsSaveMeasconfiguration.ToolTipTitle = "";
            this.hsSaveMeasconfiguration.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsSaveMeasconfiguration.UseVisualStyleBackColor = false;
            this.hsSaveMeasconfiguration.Click += new System.EventHandler(this.hsSaveMeasconfiguration_Click);
            // 
            // gbMeasPathAndFormats
            // 
            this.gbMeasPathAndFormats.Controls.Add(this.gbDatasource);
            this.gbMeasPathAndFormats.Controls.Add(this.ckMeasResultDefinitionActive);
            this.gbMeasPathAndFormats.Controls.Add(this.gbResultName);
            this.gbMeasPathAndFormats.Controls.Add(this.hsRemoveMeasResultDefinition);
            this.gbMeasPathAndFormats.Controls.Add(this.hsUpdateMeasResultDefinition);
            this.gbMeasPathAndFormats.Controls.Add(this.hsAddMeasResultDefinition);
            this.gbMeasPathAndFormats.Controls.Add(this.gbMeasResultFormat);
            this.gbMeasPathAndFormats.Controls.Add(this.gbMeasresultPath);
            this.gbMeasPathAndFormats.Controls.Add(this.dgvMeasResultConfiguration);
            this.gbMeasPathAndFormats.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbMeasPathAndFormats.Location = new System.Drawing.Point(816, 3);
            this.gbMeasPathAndFormats.Name = "gbMeasPathAndFormats";
            this.gbMeasPathAndFormats.Size = new System.Drawing.Size(950, 684);
            this.gbMeasPathAndFormats.TabIndex = 55;
            this.gbMeasPathAndFormats.TabStop = false;
            this.gbMeasPathAndFormats.Text = "Measurement result options";
            // 
            // gbDatasource
            // 
            this.gbDatasource.Controls.Add(this.rbTimeAnalyzerFile);
            this.gbDatasource.Controls.Add(this.rbAVARFile);
            this.gbDatasource.Controls.Add(this.rbResultLiteDB);
            this.gbDatasource.Controls.Add(this.rbResultFile);
            this.gbDatasource.Location = new System.Drawing.Point(6, 435);
            this.gbDatasource.Name = "gbDatasource";
            this.gbDatasource.Size = new System.Drawing.Size(156, 136);
            this.gbDatasource.TabIndex = 63;
            this.gbDatasource.TabStop = false;
            this.gbDatasource.Text = "Datasouce";
            // 
            // rbTimeAnalyzerFile
            // 
            this.rbTimeAnalyzerFile.AutoSize = true;
            this.rbTimeAnalyzerFile.Location = new System.Drawing.Point(16, 97);
            this.rbTimeAnalyzerFile.Name = "rbTimeAnalyzerFile";
            this.rbTimeAnalyzerFile.Size = new System.Drawing.Size(110, 17);
            this.rbTimeAnalyzerFile.TabIndex = 3;
            this.rbTimeAnalyzerFile.Text = "Time Analyzer File";
            this.rbTimeAnalyzerFile.UseVisualStyleBackColor = true;
            // 
            // rbAVARFile
            // 
            this.rbAVARFile.AutoSize = true;
            this.rbAVARFile.Location = new System.Drawing.Point(17, 74);
            this.rbAVARFile.Name = "rbAVARFile";
            this.rbAVARFile.Size = new System.Drawing.Size(70, 17);
            this.rbAVARFile.TabIndex = 2;
            this.rbAVARFile.Text = "AVAR file";
            this.rbAVARFile.UseVisualStyleBackColor = true;
            // 
            // rbResultLiteDB
            // 
            this.rbResultLiteDB.AutoSize = true;
            this.rbResultLiteDB.Location = new System.Drawing.Point(17, 51);
            this.rbResultLiteDB.Name = "rbResultLiteDB";
            this.rbResultLiteDB.Size = new System.Drawing.Size(71, 17);
            this.rbResultLiteDB.TabIndex = 1;
            this.rbResultLiteDB.Text = "Database";
            this.rbResultLiteDB.UseVisualStyleBackColor = true;
            // 
            // rbResultFile
            // 
            this.rbResultFile.AutoSize = true;
            this.rbResultFile.Checked = true;
            this.rbResultFile.Location = new System.Drawing.Point(17, 28);
            this.rbResultFile.Name = "rbResultFile";
            this.rbResultFile.Size = new System.Drawing.Size(41, 17);
            this.rbResultFile.TabIndex = 0;
            this.rbResultFile.TabStop = true;
            this.rbResultFile.Text = "File";
            this.rbResultFile.UseVisualStyleBackColor = true;
            // 
            // ckMeasResultDefinitionActive
            // 
            this.ckMeasResultDefinitionActive.AutoSize = true;
            this.ckMeasResultDefinitionActive.Location = new System.Drawing.Point(200, 435);
            this.ckMeasResultDefinitionActive.Name = "ckMeasResultDefinitionActive";
            this.ckMeasResultDefinitionActive.Size = new System.Drawing.Size(83, 17);
            this.ckMeasResultDefinitionActive.TabIndex = 62;
            this.ckMeasResultDefinitionActive.Text = "Write active";
            this.ckMeasResultDefinitionActive.UseVisualStyleBackColor = true;
            // 
            // gbResultName
            // 
            this.gbResultName.Controls.Add(this.txtMeasResultDefinitionFilePattern);
            this.gbResultName.Location = new System.Drawing.Point(6, 365);
            this.gbResultName.Name = "gbResultName";
            this.gbResultName.Size = new System.Drawing.Size(547, 39);
            this.gbResultName.TabIndex = 60;
            this.gbResultName.TabStop = false;
            this.gbResultName.Text = "Name of Measfile";
            // 
            // txtMeasResultDefinitionFilePattern
            // 
            this.txtMeasResultDefinitionFilePattern.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMeasResultDefinitionFilePattern.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMeasResultDefinitionFilePattern.Location = new System.Drawing.Point(3, 16);
            this.txtMeasResultDefinitionFilePattern.Name = "txtMeasResultDefinitionFilePattern";
            this.txtMeasResultDefinitionFilePattern.Size = new System.Drawing.Size(541, 22);
            this.txtMeasResultDefinitionFilePattern.TabIndex = 0;
            this.txtMeasResultDefinitionFilePattern.Text = "results";
            // 
            // hsRemoveMeasResultDefinition
            // 
            this.hsRemoveMeasResultDefinition.BackColor = System.Drawing.Color.Transparent;
            this.hsRemoveMeasResultDefinition.BackColorHover = System.Drawing.Color.Transparent;
            this.hsRemoveMeasResultDefinition.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsRemoveMeasResultDefinition.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsRemoveMeasResultDefinition.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsRemoveMeasResultDefinition.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsRemoveMeasResultDefinition.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsRemoveMeasResultDefinition.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.hsRemoveMeasResultDefinition.FlatAppearance.BorderSize = 0;
            this.hsRemoveMeasResultDefinition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsRemoveMeasResultDefinition.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsRemoveMeasResultDefinition.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsRemoveMeasResultDefinition.Image = global::PRCCounterApp.Properties.Resources.minus_blue24x;
            this.hsRemoveMeasResultDefinition.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsRemoveMeasResultDefinition.ImageHover = global::PRCCounterApp.Properties.Resources.minus_rt24x;
            this.hsRemoveMeasResultDefinition.ImageToggleOnSelect = false;
            this.hsRemoveMeasResultDefinition.Location = new System.Drawing.Point(330, 222);
            this.hsRemoveMeasResultDefinition.Marked = false;
            this.hsRemoveMeasResultDefinition.MarkedColor = System.Drawing.Color.Teal;
            this.hsRemoveMeasResultDefinition.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsRemoveMeasResultDefinition.MarkedText = "";
            this.hsRemoveMeasResultDefinition.MarkMode = false;
            this.hsRemoveMeasResultDefinition.Name = "hsRemoveMeasResultDefinition";
            this.hsRemoveMeasResultDefinition.NonMarkedText = "";
            this.hsRemoveMeasResultDefinition.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsRemoveMeasResultDefinition.ShowShortcut = false;
            this.hsRemoveMeasResultDefinition.Size = new System.Drawing.Size(80, 50);
            this.hsRemoveMeasResultDefinition.TabIndex = 59;
            this.hsRemoveMeasResultDefinition.Text = "Remove";
            this.hsRemoveMeasResultDefinition.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsRemoveMeasResultDefinition.ToolTipActive = false;
            this.hsRemoveMeasResultDefinition.ToolTipAutomaticDelay = 500;
            this.hsRemoveMeasResultDefinition.ToolTipAutoPopDelay = 5000;
            this.hsRemoveMeasResultDefinition.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsRemoveMeasResultDefinition.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsRemoveMeasResultDefinition.ToolTipFor4ContextMenu = true;
            this.hsRemoveMeasResultDefinition.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsRemoveMeasResultDefinition.ToolTipInitialDelay = 500;
            this.hsRemoveMeasResultDefinition.ToolTipIsBallon = false;
            this.hsRemoveMeasResultDefinition.ToolTipOwnerDraw = false;
            this.hsRemoveMeasResultDefinition.ToolTipReshowDelay = 100;
            this.hsRemoveMeasResultDefinition.ToolTipShowAlways = false;
            this.hsRemoveMeasResultDefinition.ToolTipText = "";
            this.hsRemoveMeasResultDefinition.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsRemoveMeasResultDefinition.ToolTipTitle = "";
            this.hsRemoveMeasResultDefinition.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsRemoveMeasResultDefinition.UseVisualStyleBackColor = false;
            this.hsRemoveMeasResultDefinition.Click += new System.EventHandler(this.hsRemoveMeasResultDefinition_Click);
            // 
            // hsUpdateMeasResultDefinition
            // 
            this.hsUpdateMeasResultDefinition.BackColor = System.Drawing.Color.Transparent;
            this.hsUpdateMeasResultDefinition.BackColorHover = System.Drawing.Color.Transparent;
            this.hsUpdateMeasResultDefinition.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsUpdateMeasResultDefinition.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsUpdateMeasResultDefinition.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsUpdateMeasResultDefinition.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsUpdateMeasResultDefinition.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsUpdateMeasResultDefinition.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.hsUpdateMeasResultDefinition.FlatAppearance.BorderSize = 0;
            this.hsUpdateMeasResultDefinition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsUpdateMeasResultDefinition.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsUpdateMeasResultDefinition.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsUpdateMeasResultDefinition.Image = global::PRCCounterApp.Properties.Resources.media_playlist_repeat_gn_x24;
            this.hsUpdateMeasResultDefinition.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsUpdateMeasResultDefinition.ImageHover = global::PRCCounterApp.Properties.Resources.media_playlist_repeat_blue_x22;
            this.hsUpdateMeasResultDefinition.ImageToggleOnSelect = false;
            this.hsUpdateMeasResultDefinition.Location = new System.Drawing.Point(244, 222);
            this.hsUpdateMeasResultDefinition.Marked = false;
            this.hsUpdateMeasResultDefinition.MarkedColor = System.Drawing.Color.Teal;
            this.hsUpdateMeasResultDefinition.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsUpdateMeasResultDefinition.MarkedText = "";
            this.hsUpdateMeasResultDefinition.MarkMode = false;
            this.hsUpdateMeasResultDefinition.Name = "hsUpdateMeasResultDefinition";
            this.hsUpdateMeasResultDefinition.NonMarkedText = "";
            this.hsUpdateMeasResultDefinition.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsUpdateMeasResultDefinition.ShowShortcut = false;
            this.hsUpdateMeasResultDefinition.Size = new System.Drawing.Size(80, 50);
            this.hsUpdateMeasResultDefinition.TabIndex = 58;
            this.hsUpdateMeasResultDefinition.Text = "Update";
            this.hsUpdateMeasResultDefinition.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsUpdateMeasResultDefinition.ToolTipActive = false;
            this.hsUpdateMeasResultDefinition.ToolTipAutomaticDelay = 500;
            this.hsUpdateMeasResultDefinition.ToolTipAutoPopDelay = 5000;
            this.hsUpdateMeasResultDefinition.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsUpdateMeasResultDefinition.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsUpdateMeasResultDefinition.ToolTipFor4ContextMenu = true;
            this.hsUpdateMeasResultDefinition.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsUpdateMeasResultDefinition.ToolTipInitialDelay = 500;
            this.hsUpdateMeasResultDefinition.ToolTipIsBallon = false;
            this.hsUpdateMeasResultDefinition.ToolTipOwnerDraw = false;
            this.hsUpdateMeasResultDefinition.ToolTipReshowDelay = 100;
            this.hsUpdateMeasResultDefinition.ToolTipShowAlways = false;
            this.hsUpdateMeasResultDefinition.ToolTipText = "";
            this.hsUpdateMeasResultDefinition.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsUpdateMeasResultDefinition.ToolTipTitle = "";
            this.hsUpdateMeasResultDefinition.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsUpdateMeasResultDefinition.UseVisualStyleBackColor = false;
            this.hsUpdateMeasResultDefinition.Click += new System.EventHandler(this.hsUpdateMeasResultDefinition_Click);
            // 
            // hsAddMeasResultDefinition
            // 
            this.hsAddMeasResultDefinition.BackColor = System.Drawing.Color.Transparent;
            this.hsAddMeasResultDefinition.BackColorHover = System.Drawing.Color.Transparent;
            this.hsAddMeasResultDefinition.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsAddMeasResultDefinition.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsAddMeasResultDefinition.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsAddMeasResultDefinition.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsAddMeasResultDefinition.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsAddMeasResultDefinition.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.hsAddMeasResultDefinition.FlatAppearance.BorderSize = 0;
            this.hsAddMeasResultDefinition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsAddMeasResultDefinition.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsAddMeasResultDefinition.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsAddMeasResultDefinition.Image = global::PRCCounterApp.Properties.Resources.plus_gn22x;
            this.hsAddMeasResultDefinition.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsAddMeasResultDefinition.ImageHover = global::PRCCounterApp.Properties.Resources.plus_blue22x;
            this.hsAddMeasResultDefinition.ImageToggleOnSelect = false;
            this.hsAddMeasResultDefinition.Location = new System.Drawing.Point(158, 222);
            this.hsAddMeasResultDefinition.Marked = false;
            this.hsAddMeasResultDefinition.MarkedColor = System.Drawing.Color.Teal;
            this.hsAddMeasResultDefinition.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsAddMeasResultDefinition.MarkedText = "";
            this.hsAddMeasResultDefinition.MarkMode = false;
            this.hsAddMeasResultDefinition.Name = "hsAddMeasResultDefinition";
            this.hsAddMeasResultDefinition.NonMarkedText = "";
            this.hsAddMeasResultDefinition.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsAddMeasResultDefinition.ShowShortcut = false;
            this.hsAddMeasResultDefinition.Size = new System.Drawing.Size(80, 50);
            this.hsAddMeasResultDefinition.TabIndex = 57;
            this.hsAddMeasResultDefinition.Text = "Add";
            this.hsAddMeasResultDefinition.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsAddMeasResultDefinition.ToolTipActive = false;
            this.hsAddMeasResultDefinition.ToolTipAutomaticDelay = 500;
            this.hsAddMeasResultDefinition.ToolTipAutoPopDelay = 5000;
            this.hsAddMeasResultDefinition.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsAddMeasResultDefinition.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsAddMeasResultDefinition.ToolTipFor4ContextMenu = true;
            this.hsAddMeasResultDefinition.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsAddMeasResultDefinition.ToolTipInitialDelay = 500;
            this.hsAddMeasResultDefinition.ToolTipIsBallon = false;
            this.hsAddMeasResultDefinition.ToolTipOwnerDraw = false;
            this.hsAddMeasResultDefinition.ToolTipReshowDelay = 100;
            this.hsAddMeasResultDefinition.ToolTipShowAlways = false;
            this.hsAddMeasResultDefinition.ToolTipText = "";
            this.hsAddMeasResultDefinition.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsAddMeasResultDefinition.ToolTipTitle = "";
            this.hsAddMeasResultDefinition.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsAddMeasResultDefinition.UseVisualStyleBackColor = false;
            this.hsAddMeasResultDefinition.Click += new System.EventHandler(this.hsAddMeasResultDefinition_Click);
            // 
            // gbMeasResultFormat
            // 
            this.gbMeasResultFormat.Controls.Add(this.txtMeasResultDefinitionFormat);
            this.gbMeasResultFormat.Location = new System.Drawing.Point(6, 320);
            this.gbMeasResultFormat.Name = "gbMeasResultFormat";
            this.gbMeasResultFormat.Size = new System.Drawing.Size(547, 40);
            this.gbMeasResultFormat.TabIndex = 56;
            this.gbMeasResultFormat.TabStop = false;
            this.gbMeasResultFormat.Text = "Result Format Template";
            // 
            // txtMeasResultDefinitionFormat
            // 
            this.txtMeasResultDefinitionFormat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMeasResultDefinitionFormat.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMeasResultDefinitionFormat.Location = new System.Drawing.Point(3, 16);
            this.txtMeasResultDefinitionFormat.Name = "txtMeasResultDefinitionFormat";
            this.txtMeasResultDefinitionFormat.Size = new System.Drawing.Size(541, 22);
            this.txtMeasResultDefinitionFormat.TabIndex = 0;
            this.txtMeasResultDefinitionFormat.Text = "<timestamp>,<value>;";
            // 
            // gbMeasresultPath
            // 
            this.gbMeasresultPath.Controls.Add(this.txtMeasResultDefinitionPath);
            this.gbMeasresultPath.Controls.Add(this.hsMeasPath);
            this.gbMeasresultPath.Location = new System.Drawing.Point(6, 277);
            this.gbMeasresultPath.Name = "gbMeasresultPath";
            this.gbMeasresultPath.Size = new System.Drawing.Size(840, 40);
            this.gbMeasresultPath.TabIndex = 2;
            this.gbMeasresultPath.TabStop = false;
            this.gbMeasresultPath.Text = "Result Path";
            // 
            // txtMeasResultDefinitionPath
            // 
            this.txtMeasResultDefinitionPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMeasResultDefinitionPath.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMeasResultDefinitionPath.Location = new System.Drawing.Point(3, 16);
            this.txtMeasResultDefinitionPath.Name = "txtMeasResultDefinitionPath";
            this.txtMeasResultDefinitionPath.Size = new System.Drawing.Size(789, 22);
            this.txtMeasResultDefinitionPath.TabIndex = 0;
            this.txtMeasResultDefinitionPath.TextChanged += new System.EventHandler(this.txtMeasResultDefinitionPath_TextChanged);
            // 
            // hsMeasPath
            // 
            this.hsMeasPath.BackColor = System.Drawing.Color.Transparent;
            this.hsMeasPath.BackColorHover = System.Drawing.Color.Transparent;
            this.hsMeasPath.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsMeasPath.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsMeasPath.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsMeasPath.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsMeasPath.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsMeasPath.Dock = System.Windows.Forms.DockStyle.Right;
            this.hsMeasPath.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.hsMeasPath.FlatAppearance.BorderSize = 0;
            this.hsMeasPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsMeasPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsMeasPath.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsMeasPath.Image = global::PRCCounterApp.Properties.Resources.folder_closed_22x;
            this.hsMeasPath.ImageHover = global::PRCCounterApp.Properties.Resources.folder_open_22x;
            this.hsMeasPath.ImageToggleOnSelect = false;
            this.hsMeasPath.Location = new System.Drawing.Point(792, 16);
            this.hsMeasPath.Marked = false;
            this.hsMeasPath.MarkedColor = System.Drawing.Color.Teal;
            this.hsMeasPath.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsMeasPath.MarkedText = "";
            this.hsMeasPath.MarkMode = false;
            this.hsMeasPath.Name = "hsMeasPath";
            this.hsMeasPath.NonMarkedText = "";
            this.hsMeasPath.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsMeasPath.ShowShortcut = false;
            this.hsMeasPath.Size = new System.Drawing.Size(45, 21);
            this.hsMeasPath.TabIndex = 19;
            this.hsMeasPath.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsMeasPath.ToolTipActive = false;
            this.hsMeasPath.ToolTipAutomaticDelay = 500;
            this.hsMeasPath.ToolTipAutoPopDelay = 5000;
            this.hsMeasPath.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsMeasPath.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsMeasPath.ToolTipFor4ContextMenu = true;
            this.hsMeasPath.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsMeasPath.ToolTipInitialDelay = 500;
            this.hsMeasPath.ToolTipIsBallon = false;
            this.hsMeasPath.ToolTipOwnerDraw = false;
            this.hsMeasPath.ToolTipReshowDelay = 100;
            this.hsMeasPath.ToolTipShowAlways = false;
            this.hsMeasPath.ToolTipText = "";
            this.hsMeasPath.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsMeasPath.ToolTipTitle = "";
            this.hsMeasPath.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsMeasPath.UseVisualStyleBackColor = false;
            // 
            // dgvMeasResultConfiguration
            // 
            this.dgvMeasResultConfiguration.AllowUserToAddRows = false;
            this.dgvMeasResultConfiguration.AllowUserToDeleteRows = false;
            this.dgvMeasResultConfiguration.AutoGenerateColumns = false;
            this.dgvMeasResultConfiguration.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvMeasResultConfiguration.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMeasResultConfiguration.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.outdefID,
            this.outdefFILEPATTERN,
            this.outdefPATH,
            this.outdefFORMAT,
            this.outdefACTIVE,
            this.outdefDATASOURCE});
            this.dgvMeasResultConfiguration.DataSource = this.bsOutputDefinition;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMeasResultConfiguration.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMeasResultConfiguration.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvMeasResultConfiguration.Location = new System.Drawing.Point(3, 16);
            this.dgvMeasResultConfiguration.Name = "dgvMeasResultConfiguration";
            this.dgvMeasResultConfiguration.ReadOnly = true;
            this.dgvMeasResultConfiguration.RowHeadersVisible = false;
            this.dgvMeasResultConfiguration.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvMeasResultConfiguration.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMeasResultConfiguration.Size = new System.Drawing.Size(944, 200);
            this.dgvMeasResultConfiguration.TabIndex = 54;
            // 
            // outdefID
            // 
            this.outdefID.DataPropertyName = "outdefID";
            this.outdefID.HeaderText = "ID";
            this.outdefID.Name = "outdefID";
            this.outdefID.ReadOnly = true;
            this.outdefID.Width = 43;
            // 
            // outdefFILEPATTERN
            // 
            this.outdefFILEPATTERN.DataPropertyName = "outdefFILEPATTERN";
            this.outdefFILEPATTERN.HeaderText = "FILEPATTERN";
            this.outdefFILEPATTERN.Name = "outdefFILEPATTERN";
            this.outdefFILEPATTERN.ReadOnly = true;
            this.outdefFILEPATTERN.Width = 105;
            // 
            // outdefPATH
            // 
            this.outdefPATH.DataPropertyName = "outdefPATH";
            this.outdefPATH.HeaderText = "PATH";
            this.outdefPATH.Name = "outdefPATH";
            this.outdefPATH.ReadOnly = true;
            this.outdefPATH.Width = 61;
            // 
            // outdefFORMAT
            // 
            this.outdefFORMAT.DataPropertyName = "outdefFORMAT";
            this.outdefFORMAT.HeaderText = "FORMAT";
            this.outdefFORMAT.Name = "outdefFORMAT";
            this.outdefFORMAT.ReadOnly = true;
            this.outdefFORMAT.Width = 77;
            // 
            // outdefACTIVE
            // 
            this.outdefACTIVE.DataPropertyName = "outdefACTIVE";
            this.outdefACTIVE.HeaderText = "ACTIVE";
            this.outdefACTIVE.Name = "outdefACTIVE";
            this.outdefACTIVE.ReadOnly = true;
            this.outdefACTIVE.Width = 51;
            // 
            // outdefDATASOURCE
            // 
            this.outdefDATASOURCE.DataPropertyName = "outdefDATASOURCE";
            this.outdefDATASOURCE.HeaderText = "DATASOURCE";
            this.outdefDATASOURCE.Name = "outdefDATASOURCE";
            this.outdefDATASOURCE.ReadOnly = true;
            this.outdefDATASOURCE.Width = 106;
            // 
            // bsOutputDefinition
            // 
            this.bsOutputDefinition.DataMember = "Table1";
            this.bsOutputDefinition.DataSource = this.dsOutputDefintion;
            this.bsOutputDefinition.CurrentChanged += new System.EventHandler(this.bsOutputDefinition_CurrentChanged);
            // 
            // dsOutputDefintion
            // 
            this.dsOutputDefintion.DataSetName = "NewDataSet";
            this.dsOutputDefintion.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable2});
            // 
            // dataTable2
            // 
            this.dataTable2.Columns.AddRange(new System.Data.DataColumn[] {
            this.col_outdefID,
            this.col_outdefPATH,
            this.col_outdefFORMAT,
            this.col_outdefACTIVE,
            this.col_outdefFILEPATTERN,
            this.dataColumn1});
            this.dataTable2.TableName = "Table1";
            // 
            // col_outdefID
            // 
            this.col_outdefID.ColumnName = "outdefID";
            this.col_outdefID.DataType = typeof(System.Guid);
            // 
            // col_outdefPATH
            // 
            this.col_outdefPATH.ColumnName = "outdefPATH";
            // 
            // col_outdefFORMAT
            // 
            this.col_outdefFORMAT.ColumnName = "outdefFORMAT";
            // 
            // col_outdefACTIVE
            // 
            this.col_outdefACTIVE.ColumnName = "outdefACTIVE";
            this.col_outdefACTIVE.DataType = typeof(bool);
            // 
            // col_outdefFILEPATTERN
            // 
            this.col_outdefFILEPATTERN.ColumnName = "outdefFILEPATTERN";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "outdefDATASOURCE";
            // 
            // tabPageMeasFiles
            // 
            this.tabPageMeasFiles.Controls.Add(this.pnlMeasResultsCenter);
            this.tabPageMeasFiles.Controls.Add(this.flpResults);
            this.tabPageMeasFiles.ImageKey = "graph_24x.png";
            this.tabPageMeasFiles.Location = new System.Drawing.Point(4, 23);
            this.tabPageMeasFiles.Name = "tabPageMeasFiles";
            this.tabPageMeasFiles.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMeasFiles.Size = new System.Drawing.Size(1769, 690);
            this.tabPageMeasFiles.TabIndex = 3;
            this.tabPageMeasFiles.Text = "Result files";
            this.tabPageMeasFiles.UseVisualStyleBackColor = true;
            // 
            // pnlMeasResultsCenter
            // 
            this.pnlMeasResultsCenter.Controls.Add(this.gbFileInfos);
            this.pnlMeasResultsCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMeasResultsCenter.Location = new System.Drawing.Point(3, 51);
            this.pnlMeasResultsCenter.Name = "pnlMeasResultsCenter";
            this.pnlMeasResultsCenter.Size = new System.Drawing.Size(1763, 636);
            this.pnlMeasResultsCenter.TabIndex = 1;
            // 
            // gbFileInfos
            // 
            this.gbFileInfos.Controls.Add(this.spcResultFiles);
            this.gbFileInfos.Controls.Add(this.pnlResultfilesLeft);
            this.gbFileInfos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbFileInfos.Location = new System.Drawing.Point(0, 0);
            this.gbFileInfos.Name = "gbFileInfos";
            this.gbFileInfos.Size = new System.Drawing.Size(1763, 636);
            this.gbFileInfos.TabIndex = 66;
            this.gbFileInfos.TabStop = false;
            this.gbFileInfos.Text = "Resultfiles";
            // 
            // spcResultFiles
            // 
            this.spcResultFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcResultFiles.Location = new System.Drawing.Point(621, 16);
            this.spcResultFiles.Name = "spcResultFiles";
            // 
            // spcResultFiles.Panel1
            // 
            this.spcResultFiles.Panel1.Controls.Add(this.dataGridView1);
            // 
            // spcResultFiles.Panel2
            // 
            this.spcResultFiles.Panel2.Controls.Add(this.gbDatafile);
            this.spcResultFiles.Panel2.Controls.Add(this.gbHeaderfile);
            this.spcResultFiles.Size = new System.Drawing.Size(1139, 617);
            this.spcResultFiles.SplitterDistance = 379;
            this.spcResultFiles.TabIndex = 16;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFileName,
            this.colFileCreate,
            this.colFileSize});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(379, 617);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // colFileName
            // 
            this.colFileName.HeaderText = "Filename";
            this.colFileName.Name = "colFileName";
            this.colFileName.ReadOnly = true;
            this.colFileName.Width = 74;
            // 
            // colFileCreate
            // 
            this.colFileCreate.HeaderText = "Create";
            this.colFileCreate.Name = "colFileCreate";
            this.colFileCreate.ReadOnly = true;
            this.colFileCreate.Width = 63;
            // 
            // colFileSize
            // 
            this.colFileSize.HeaderText = "Filesize";
            this.colFileSize.Name = "colFileSize";
            this.colFileSize.ReadOnly = true;
            this.colFileSize.Width = 66;
            // 
            // gbDatafile
            // 
            this.gbDatafile.Controls.Add(this.rtbDataFile);
            this.gbDatafile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDatafile.Location = new System.Drawing.Point(0, 191);
            this.gbDatafile.Name = "gbDatafile";
            this.gbDatafile.Size = new System.Drawing.Size(756, 426);
            this.gbDatafile.TabIndex = 0;
            this.gbDatafile.TabStop = false;
            this.gbDatafile.Text = "Datafile";
            // 
            // rtbDataFile
            // 
            this.rtbDataFile.BackColor = System.Drawing.SystemColors.Info;
            this.rtbDataFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbDataFile.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbDataFile.Location = new System.Drawing.Point(3, 16);
            this.rtbDataFile.Name = "rtbDataFile";
            this.rtbDataFile.Size = new System.Drawing.Size(750, 407);
            this.rtbDataFile.TabIndex = 15;
            this.rtbDataFile.Text = "";
            // 
            // gbHeaderfile
            // 
            this.gbHeaderfile.Controls.Add(this.rtbHeaderfile);
            this.gbHeaderfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbHeaderfile.Location = new System.Drawing.Point(0, 0);
            this.gbHeaderfile.Name = "gbHeaderfile";
            this.gbHeaderfile.Size = new System.Drawing.Size(756, 191);
            this.gbHeaderfile.TabIndex = 69;
            this.gbHeaderfile.TabStop = false;
            this.gbHeaderfile.Text = "Headerfile";
            // 
            // rtbHeaderfile
            // 
            this.rtbHeaderfile.BackColor = System.Drawing.SystemColors.Info;
            this.rtbHeaderfile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbHeaderfile.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbHeaderfile.Location = new System.Drawing.Point(3, 16);
            this.rtbHeaderfile.Name = "rtbHeaderfile";
            this.rtbHeaderfile.Size = new System.Drawing.Size(750, 172);
            this.rtbHeaderfile.TabIndex = 16;
            this.rtbHeaderfile.Text = "";
            // 
            // pnlResultfilesLeft
            // 
            this.pnlResultfilesLeft.Controls.Add(this.groupBox9);
            this.pnlResultfilesLeft.Controls.Add(this.groupBox8);
            this.pnlResultfilesLeft.Controls.Add(this.gbStatistikType);
            this.pnlResultfilesLeft.Controls.Add(this.groupBox15);
            this.pnlResultfilesLeft.Controls.Add(this.gbOutliers);
            this.pnlResultfilesLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlResultfilesLeft.Location = new System.Drawing.Point(3, 16);
            this.pnlResultfilesLeft.Name = "pnlResultfilesLeft";
            this.pnlResultfilesLeft.Size = new System.Drawing.Size(618, 617);
            this.pnlResultfilesLeft.TabIndex = 1;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.gbMeasAttMeasOffset);
            this.groupBox9.Controls.Add(this.gbMeasAttEndtime);
            this.groupBox9.Controls.Add(this.gbMeasAttStarttime);
            this.groupBox9.Controls.Add(this.gbMeasAttStartdate);
            this.groupBox9.Controls.Add(this.gbMeasAttMeasDevice);
            this.groupBox9.Controls.Add(this.gbMeasAttScaleYAxis);
            this.groupBox9.Controls.Add(this.gbMeasAttGraph);
            this.groupBox9.Controls.Add(this.gbMeasAttXLegend);
            this.groupBox9.Controls.Add(this.gbMeasAttYLegend);
            this.groupBox9.Controls.Add(this.gbMeasAttMeasName);
            this.groupBox9.Location = new System.Drawing.Point(235, 16);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(378, 441);
            this.groupBox9.TabIndex = 68;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Meas attributes";
            // 
            // gbMeasAttMeasOffset
            // 
            this.gbMeasAttMeasOffset.Controls.Add(this.txtMeasAttMeasOffset);
            this.gbMeasAttMeasOffset.Location = new System.Drawing.Point(6, 399);
            this.gbMeasAttMeasOffset.Name = "gbMeasAttMeasOffset";
            this.gbMeasAttMeasOffset.Size = new System.Drawing.Size(205, 40);
            this.gbMeasAttMeasOffset.TabIndex = 56;
            this.gbMeasAttMeasOffset.TabStop = false;
            this.gbMeasAttMeasOffset.Text = "Const Y-offset of measurment";
            // 
            // txtMeasAttMeasOffset
            // 
            this.txtMeasAttMeasOffset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMeasAttMeasOffset.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMeasAttMeasOffset.Location = new System.Drawing.Point(3, 16);
            this.txtMeasAttMeasOffset.Name = "txtMeasAttMeasOffset";
            this.txtMeasAttMeasOffset.Size = new System.Drawing.Size(199, 22);
            this.txtMeasAttMeasOffset.TabIndex = 0;
            this.txtMeasAttMeasOffset.Text = "0";
            // 
            // gbMeasAttEndtime
            // 
            this.gbMeasAttEndtime.Controls.Add(this.txtMeasAttEndtime);
            this.gbMeasAttEndtime.Location = new System.Drawing.Point(158, 345);
            this.gbMeasAttEndtime.Name = "gbMeasAttEndtime";
            this.gbMeasAttEndtime.Size = new System.Drawing.Size(146, 40);
            this.gbMeasAttEndtime.TabIndex = 55;
            this.gbMeasAttEndtime.TabStop = false;
            this.gbMeasAttEndtime.Text = "X-Endvalue";
            // 
            // txtMeasAttEndtime
            // 
            this.txtMeasAttEndtime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMeasAttEndtime.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMeasAttEndtime.Location = new System.Drawing.Point(3, 16);
            this.txtMeasAttEndtime.Name = "txtMeasAttEndtime";
            this.txtMeasAttEndtime.Size = new System.Drawing.Size(140, 22);
            this.txtMeasAttEndtime.TabIndex = 0;
            this.txtMeasAttEndtime.Text = "0";
            // 
            // gbMeasAttStarttime
            // 
            this.gbMeasAttStarttime.Controls.Add(this.txtMeasAttStarttime);
            this.gbMeasAttStarttime.Location = new System.Drawing.Point(6, 345);
            this.gbMeasAttStarttime.Name = "gbMeasAttStarttime";
            this.gbMeasAttStarttime.Size = new System.Drawing.Size(146, 40);
            this.gbMeasAttStarttime.TabIndex = 54;
            this.gbMeasAttStarttime.TabStop = false;
            this.gbMeasAttStarttime.Text = "X-Startvalue";
            // 
            // txtMeasAttStarttime
            // 
            this.txtMeasAttStarttime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMeasAttStarttime.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMeasAttStarttime.Location = new System.Drawing.Point(3, 16);
            this.txtMeasAttStarttime.Name = "txtMeasAttStarttime";
            this.txtMeasAttStarttime.Size = new System.Drawing.Size(140, 22);
            this.txtMeasAttStarttime.TabIndex = 0;
            this.txtMeasAttStarttime.Text = "0";
            // 
            // gbMeasAttStartdate
            // 
            this.gbMeasAttStartdate.Controls.Add(this.txtMeasAttStartdate);
            this.gbMeasAttStartdate.Location = new System.Drawing.Point(6, 294);
            this.gbMeasAttStartdate.Name = "gbMeasAttStartdate";
            this.gbMeasAttStartdate.Size = new System.Drawing.Size(366, 40);
            this.gbMeasAttStartdate.TabIndex = 53;
            this.gbMeasAttStartdate.TabStop = false;
            this.gbMeasAttStartdate.Text = "Startdate";
            // 
            // txtMeasAttStartdate
            // 
            this.txtMeasAttStartdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMeasAttStartdate.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMeasAttStartdate.Location = new System.Drawing.Point(3, 16);
            this.txtMeasAttStartdate.Name = "txtMeasAttStartdate";
            this.txtMeasAttStartdate.Size = new System.Drawing.Size(360, 22);
            this.txtMeasAttStartdate.TabIndex = 0;
            // 
            // gbMeasAttMeasDevice
            // 
            this.gbMeasAttMeasDevice.Controls.Add(this.txtMeasAttMeasDevice);
            this.gbMeasAttMeasDevice.Location = new System.Drawing.Point(6, 19);
            this.gbMeasAttMeasDevice.Name = "gbMeasAttMeasDevice";
            this.gbMeasAttMeasDevice.Size = new System.Drawing.Size(366, 40);
            this.gbMeasAttMeasDevice.TabIndex = 52;
            this.gbMeasAttMeasDevice.TabStop = false;
            this.gbMeasAttMeasDevice.Text = "Device";
            // 
            // txtMeasAttMeasDevice
            // 
            this.txtMeasAttMeasDevice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMeasAttMeasDevice.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMeasAttMeasDevice.Location = new System.Drawing.Point(3, 16);
            this.txtMeasAttMeasDevice.Name = "txtMeasAttMeasDevice";
            this.txtMeasAttMeasDevice.Size = new System.Drawing.Size(360, 22);
            this.txtMeasAttMeasDevice.TabIndex = 0;
            this.txtMeasAttMeasDevice.Text = "GT900 USB3, API 1.7.1";
            // 
            // gbMeasAttScaleYAxis
            // 
            this.gbMeasAttScaleYAxis.Controls.Add(this.txtMeasAttScaleYAxis);
            this.gbMeasAttScaleYAxis.Location = new System.Drawing.Point(230, 399);
            this.gbMeasAttScaleYAxis.Name = "gbMeasAttScaleYAxis";
            this.gbMeasAttScaleYAxis.Size = new System.Drawing.Size(100, 40);
            this.gbMeasAttScaleYAxis.TabIndex = 51;
            this.gbMeasAttScaleYAxis.TabStop = false;
            this.gbMeasAttScaleYAxis.Text = "Scale Y-Axis";
            // 
            // txtMeasAttScaleYAxis
            // 
            this.txtMeasAttScaleYAxis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMeasAttScaleYAxis.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMeasAttScaleYAxis.Location = new System.Drawing.Point(3, 16);
            this.txtMeasAttScaleYAxis.Name = "txtMeasAttScaleYAxis";
            this.txtMeasAttScaleYAxis.Size = new System.Drawing.Size(94, 22);
            this.txtMeasAttScaleYAxis.TabIndex = 0;
            this.txtMeasAttScaleYAxis.Text = "9";
            // 
            // gbMeasAttGraph
            // 
            this.gbMeasAttGraph.Controls.Add(this.txtMeasAttGraphLegend);
            this.gbMeasAttGraph.Location = new System.Drawing.Point(6, 204);
            this.gbMeasAttGraph.Name = "gbMeasAttGraph";
            this.gbMeasAttGraph.Size = new System.Drawing.Size(366, 40);
            this.gbMeasAttGraph.TabIndex = 50;
            this.gbMeasAttGraph.TabStop = false;
            this.gbMeasAttGraph.Text = "Graph-Legend";
            // 
            // txtMeasAttGraphLegend
            // 
            this.txtMeasAttGraphLegend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMeasAttGraphLegend.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMeasAttGraphLegend.Location = new System.Drawing.Point(3, 16);
            this.txtMeasAttGraphLegend.Name = "txtMeasAttGraphLegend";
            this.txtMeasAttGraphLegend.Size = new System.Drawing.Size(360, 22);
            this.txtMeasAttGraphLegend.TabIndex = 0;
            this.txtMeasAttGraphLegend.Text = "Phase A-B";
            // 
            // gbMeasAttXLegend
            // 
            this.gbMeasAttXLegend.Controls.Add(this.txtMeasAttXLegend);
            this.gbMeasAttXLegend.Location = new System.Drawing.Point(6, 109);
            this.gbMeasAttXLegend.Name = "gbMeasAttXLegend";
            this.gbMeasAttXLegend.Size = new System.Drawing.Size(366, 40);
            this.gbMeasAttXLegend.TabIndex = 49;
            this.gbMeasAttXLegend.TabStop = false;
            this.gbMeasAttXLegend.Text = "X-Legend";
            // 
            // txtMeasAttXLegend
            // 
            this.txtMeasAttXLegend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMeasAttXLegend.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMeasAttXLegend.Location = new System.Drawing.Point(3, 16);
            this.txtMeasAttXLegend.Name = "txtMeasAttXLegend";
            this.txtMeasAttXLegend.Size = new System.Drawing.Size(360, 22);
            this.txtMeasAttXLegend.TabIndex = 0;
            this.txtMeasAttXLegend.Text = "timestamp (s)";
            // 
            // gbMeasAttYLegend
            // 
            this.gbMeasAttYLegend.Controls.Add(this.txtMeasAttYLegend);
            this.gbMeasAttYLegend.Location = new System.Drawing.Point(6, 153);
            this.gbMeasAttYLegend.Name = "gbMeasAttYLegend";
            this.gbMeasAttYLegend.Size = new System.Drawing.Size(366, 40);
            this.gbMeasAttYLegend.TabIndex = 48;
            this.gbMeasAttYLegend.TabStop = false;
            this.gbMeasAttYLegend.Text = "Y-Legend";
            // 
            // txtMeasAttYLegend
            // 
            this.txtMeasAttYLegend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMeasAttYLegend.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMeasAttYLegend.Location = new System.Drawing.Point(3, 16);
            this.txtMeasAttYLegend.Name = "txtMeasAttYLegend";
            this.txtMeasAttYLegend.Size = new System.Drawing.Size(360, 22);
            this.txtMeasAttYLegend.TabIndex = 0;
            this.txtMeasAttYLegend.Text = "offset (ns)";
            // 
            // gbMeasAttMeasName
            // 
            this.gbMeasAttMeasName.Controls.Add(this.txtMeasAttMeasName);
            this.gbMeasAttMeasName.Location = new System.Drawing.Point(6, 65);
            this.gbMeasAttMeasName.Name = "gbMeasAttMeasName";
            this.gbMeasAttMeasName.Size = new System.Drawing.Size(366, 40);
            this.gbMeasAttMeasName.TabIndex = 47;
            this.gbMeasAttMeasName.TabStop = false;
            this.gbMeasAttMeasName.Text = "Measurementname";
            // 
            // txtMeasAttMeasName
            // 
            this.txtMeasAttMeasName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMeasAttMeasName.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMeasAttMeasName.Location = new System.Drawing.Point(3, 16);
            this.txtMeasAttMeasName.Name = "txtMeasAttMeasName";
            this.txtMeasAttMeasName.Size = new System.Drawing.Size(360, 22);
            this.txtMeasAttMeasName.TabIndex = 0;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.hsMakeHeader);
            this.groupBox8.Controls.Add(this.hsRunGraph);
            this.groupBox8.Controls.Add(this.cbUseHeaderfile);
            this.groupBox8.Location = new System.Drawing.Point(10, 16);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(200, 100);
            this.groupBox8.TabIndex = 16;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Line Graph";
            // 
            // hsMakeHeader
            // 
            this.hsMakeHeader.BackColor = System.Drawing.Color.Transparent;
            this.hsMakeHeader.BackColorHover = System.Drawing.Color.Transparent;
            this.hsMakeHeader.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsMakeHeader.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsMakeHeader.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsMakeHeader.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsMakeHeader.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsMakeHeader.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.hsMakeHeader.FlatAppearance.BorderSize = 0;
            this.hsMakeHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsMakeHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsMakeHeader.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsMakeHeader.Image = global::PRCCounterApp.Properties.Resources.document_x24;
            this.hsMakeHeader.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsMakeHeader.ImageHover = global::PRCCounterApp.Properties.Resources.document_blue_x24;
            this.hsMakeHeader.ImageToggleOnSelect = false;
            this.hsMakeHeader.Location = new System.Drawing.Point(3, 19);
            this.hsMakeHeader.Marked = false;
            this.hsMakeHeader.MarkedColor = System.Drawing.Color.Teal;
            this.hsMakeHeader.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsMakeHeader.MarkedText = "";
            this.hsMakeHeader.MarkMode = false;
            this.hsMakeHeader.Name = "hsMakeHeader";
            this.hsMakeHeader.NonMarkedText = "";
            this.hsMakeHeader.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsMakeHeader.ShowShortcut = false;
            this.hsMakeHeader.Size = new System.Drawing.Size(97, 50);
            this.hsMakeHeader.TabIndex = 65;
            this.hsMakeHeader.Text = "Make Headerfile";
            this.hsMakeHeader.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsMakeHeader.ToolTipActive = false;
            this.hsMakeHeader.ToolTipAutomaticDelay = 500;
            this.hsMakeHeader.ToolTipAutoPopDelay = 5000;
            this.hsMakeHeader.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsMakeHeader.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsMakeHeader.ToolTipFor4ContextMenu = true;
            this.hsMakeHeader.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsMakeHeader.ToolTipInitialDelay = 500;
            this.hsMakeHeader.ToolTipIsBallon = false;
            this.hsMakeHeader.ToolTipOwnerDraw = false;
            this.hsMakeHeader.ToolTipReshowDelay = 100;
            this.hsMakeHeader.ToolTipShowAlways = false;
            this.hsMakeHeader.ToolTipText = "";
            this.hsMakeHeader.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsMakeHeader.ToolTipTitle = "";
            this.hsMakeHeader.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsMakeHeader.UseVisualStyleBackColor = false;
            this.hsMakeHeader.Click += new System.EventHandler(this.hsMakeHeader_Click);
            // 
            // hsRunGraph
            // 
            this.hsRunGraph.BackColor = System.Drawing.Color.Transparent;
            this.hsRunGraph.BackColorHover = System.Drawing.Color.Transparent;
            this.hsRunGraph.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsRunGraph.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsRunGraph.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsRunGraph.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsRunGraph.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsRunGraph.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.hsRunGraph.FlatAppearance.BorderSize = 0;
            this.hsRunGraph.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsRunGraph.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsRunGraph.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsRunGraph.Image = global::PRCCounterApp.Properties.Resources.graph_24x;
            this.hsRunGraph.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsRunGraph.ImageHover = global::PRCCounterApp.Properties.Resources.graph_2_24x;
            this.hsRunGraph.ImageToggleOnSelect = false;
            this.hsRunGraph.Location = new System.Drawing.Point(106, 19);
            this.hsRunGraph.Marked = false;
            this.hsRunGraph.MarkedColor = System.Drawing.Color.Teal;
            this.hsRunGraph.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsRunGraph.MarkedText = "";
            this.hsRunGraph.MarkMode = false;
            this.hsRunGraph.Name = "hsRunGraph";
            this.hsRunGraph.NonMarkedText = "";
            this.hsRunGraph.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsRunGraph.ShowShortcut = false;
            this.hsRunGraph.Size = new System.Drawing.Size(80, 50);
            this.hsRunGraph.TabIndex = 64;
            this.hsRunGraph.Text = "Show Graph";
            this.hsRunGraph.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsRunGraph.ToolTipActive = false;
            this.hsRunGraph.ToolTipAutomaticDelay = 500;
            this.hsRunGraph.ToolTipAutoPopDelay = 5000;
            this.hsRunGraph.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsRunGraph.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsRunGraph.ToolTipFor4ContextMenu = true;
            this.hsRunGraph.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsRunGraph.ToolTipInitialDelay = 500;
            this.hsRunGraph.ToolTipIsBallon = false;
            this.hsRunGraph.ToolTipOwnerDraw = false;
            this.hsRunGraph.ToolTipReshowDelay = 100;
            this.hsRunGraph.ToolTipShowAlways = false;
            this.hsRunGraph.ToolTipText = "";
            this.hsRunGraph.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsRunGraph.ToolTipTitle = "";
            this.hsRunGraph.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsRunGraph.UseVisualStyleBackColor = false;
            this.hsRunGraph.Click += new System.EventHandler(this.hsRunGraph_Click);
            // 
            // cbUseHeaderfile
            // 
            this.cbUseHeaderfile.AutoSize = true;
            this.cbUseHeaderfile.Location = new System.Drawing.Point(6, 75);
            this.cbUseHeaderfile.Name = "cbUseHeaderfile";
            this.cbUseHeaderfile.Size = new System.Drawing.Size(94, 17);
            this.cbUseHeaderfile.TabIndex = 3;
            this.cbUseHeaderfile.Text = "Use headerfile";
            this.cbUseHeaderfile.UseVisualStyleBackColor = true;
            // 
            // gbStatistikType
            // 
            this.gbStatistikType.Controls.Add(this.ckMDEV);
            this.gbStatistikType.Controls.Add(this.hsShowGraphStatistik);
            this.gbStatistikType.Controls.Add(this.ckOADEV);
            this.gbStatistikType.Controls.Add(this.ckADEV);
            this.gbStatistikType.Controls.Add(this.ckTDEV);
            this.gbStatistikType.Location = new System.Drawing.Point(10, 139);
            this.gbStatistikType.Name = "gbStatistikType";
            this.gbStatistikType.Size = new System.Drawing.Size(200, 133);
            this.gbStatistikType.TabIndex = 16;
            this.gbStatistikType.TabStop = false;
            this.gbStatistikType.Text = "Statistik graph";
            // 
            // ckMDEV
            // 
            this.ckMDEV.AutoSize = true;
            this.ckMDEV.Location = new System.Drawing.Point(6, 77);
            this.ckMDEV.Name = "ckMDEV";
            this.ckMDEV.Size = new System.Drawing.Size(57, 17);
            this.ckMDEV.TabIndex = 21;
            this.ckMDEV.Text = "MDEV";
            this.ckMDEV.UseVisualStyleBackColor = true;
            // 
            // hsShowGraphStatistik
            // 
            this.hsShowGraphStatistik.BackColor = System.Drawing.Color.Transparent;
            this.hsShowGraphStatistik.BackColorHover = System.Drawing.Color.Transparent;
            this.hsShowGraphStatistik.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsShowGraphStatistik.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsShowGraphStatistik.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsShowGraphStatistik.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsShowGraphStatistik.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsShowGraphStatistik.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.hsShowGraphStatistik.FlatAppearance.BorderSize = 0;
            this.hsShowGraphStatistik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsShowGraphStatistik.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsShowGraphStatistik.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsShowGraphStatistik.Image = global::PRCCounterApp.Properties.Resources.graph_24x;
            this.hsShowGraphStatistik.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hsShowGraphStatistik.ImageHover = global::PRCCounterApp.Properties.Resources.graph_2_24x;
            this.hsShowGraphStatistik.ImageToggleOnSelect = false;
            this.hsShowGraphStatistik.Location = new System.Drawing.Point(98, 31);
            this.hsShowGraphStatistik.Marked = false;
            this.hsShowGraphStatistik.MarkedColor = System.Drawing.Color.Teal;
            this.hsShowGraphStatistik.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsShowGraphStatistik.MarkedText = "";
            this.hsShowGraphStatistik.MarkMode = false;
            this.hsShowGraphStatistik.Name = "hsShowGraphStatistik";
            this.hsShowGraphStatistik.NonMarkedText = "";
            this.hsShowGraphStatistik.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsShowGraphStatistik.ShowShortcut = false;
            this.hsShowGraphStatistik.Size = new System.Drawing.Size(85, 50);
            this.hsShowGraphStatistik.TabIndex = 68;
            this.hsShowGraphStatistik.Text = "Show graph";
            this.hsShowGraphStatistik.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsShowGraphStatistik.ToolTipActive = false;
            this.hsShowGraphStatistik.ToolTipAutomaticDelay = 500;
            this.hsShowGraphStatistik.ToolTipAutoPopDelay = 5000;
            this.hsShowGraphStatistik.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsShowGraphStatistik.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsShowGraphStatistik.ToolTipFor4ContextMenu = true;
            this.hsShowGraphStatistik.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsShowGraphStatistik.ToolTipInitialDelay = 500;
            this.hsShowGraphStatistik.ToolTipIsBallon = false;
            this.hsShowGraphStatistik.ToolTipOwnerDraw = false;
            this.hsShowGraphStatistik.ToolTipReshowDelay = 100;
            this.hsShowGraphStatistik.ToolTipShowAlways = false;
            this.hsShowGraphStatistik.ToolTipText = "";
            this.hsShowGraphStatistik.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsShowGraphStatistik.ToolTipTitle = "";
            this.hsShowGraphStatistik.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsShowGraphStatistik.UseVisualStyleBackColor = false;
            this.hsShowGraphStatistik.Click += new System.EventHandler(this.hsShowGraphStatistik_Click);
            // 
            // ckOADEV
            // 
            this.ckOADEV.AutoSize = true;
            this.ckOADEV.Location = new System.Drawing.Point(6, 100);
            this.ckOADEV.Name = "ckOADEV";
            this.ckOADEV.Size = new System.Drawing.Size(63, 17);
            this.ckOADEV.TabIndex = 20;
            this.ckOADEV.Text = "OADEV";
            this.ckOADEV.UseVisualStyleBackColor = true;
            // 
            // ckADEV
            // 
            this.ckADEV.AutoSize = true;
            this.ckADEV.Checked = true;
            this.ckADEV.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckADEV.Location = new System.Drawing.Point(6, 54);
            this.ckADEV.Name = "ckADEV";
            this.ckADEV.Size = new System.Drawing.Size(55, 17);
            this.ckADEV.TabIndex = 19;
            this.ckADEV.Text = "ADEV";
            this.ckADEV.UseVisualStyleBackColor = true;
            // 
            // ckTDEV
            // 
            this.ckTDEV.AutoSize = true;
            this.ckTDEV.Checked = true;
            this.ckTDEV.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckTDEV.Location = new System.Drawing.Point(6, 31);
            this.ckTDEV.Name = "ckTDEV";
            this.ckTDEV.Size = new System.Drawing.Size(55, 17);
            this.ckTDEV.TabIndex = 18;
            this.ckTDEV.Text = "TDEV";
            this.ckTDEV.UseVisualStyleBackColor = true;
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.textBox6);
            this.groupBox15.Location = new System.Drawing.Point(13, 301);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(183, 38);
            this.groupBox15.TabIndex = 52;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "Additional Y-Offset for Graph";
            // 
            // textBox6
            // 
            this.textBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox6.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(3, 16);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(177, 22);
            this.textBox6.TabIndex = 14;
            this.textBox6.Text = "0";
            // 
            // gbOutliers
            // 
            this.gbOutliers.Controls.Add(this.hotSpot1);
            this.gbOutliers.Controls.Add(this.hsOutliers3);
            this.gbOutliers.Controls.Add(this.hsOutliers6);
            this.gbOutliers.Controls.Add(this.hsOutlier9);
            this.gbOutliers.Controls.Add(this.txtOutliers);
            this.gbOutliers.Location = new System.Drawing.Point(10, 345);
            this.gbOutliers.Name = "gbOutliers";
            this.gbOutliers.Size = new System.Drawing.Size(125, 136);
            this.gbOutliers.TabIndex = 67;
            this.gbOutliers.TabStop = false;
            this.gbOutliers.Text = "Outliers for Graph";
            // 
            // hotSpot1
            // 
            this.hotSpot1.BackColor = System.Drawing.Color.Transparent;
            this.hotSpot1.BackColorHover = System.Drawing.Color.Transparent;
            this.hotSpot1.BorderColorHover = System.Drawing.Color.Transparent;
            this.hotSpot1.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hotSpot1.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hotSpot1.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hotSpot1.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hotSpot1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.hotSpot1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.hotSpot1.FlatAppearance.BorderSize = 0;
            this.hotSpot1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hotSpot1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotSpot1.HoverStyle = SeControlsLib.frameStyle.none;
            this.hotSpot1.Image = null;
            this.hotSpot1.ImageHover = null;
            this.hotSpot1.ImageToggleOnSelect = false;
            this.hotSpot1.Location = new System.Drawing.Point(3, 49);
            this.hotSpot1.Marked = false;
            this.hotSpot1.MarkedColor = System.Drawing.Color.Teal;
            this.hotSpot1.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hotSpot1.MarkedText = "";
            this.hotSpot1.MarkMode = false;
            this.hotSpot1.Name = "hotSpot1";
            this.hotSpot1.NonMarkedText = "";
            this.hotSpot1.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hotSpot1.ShowShortcut = false;
            this.hotSpot1.Size = new System.Drawing.Size(119, 21);
            this.hotSpot1.TabIndex = 23;
            this.hotSpot1.Text = "No outliers";
            this.hotSpot1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hotSpot1.ToolTipActive = false;
            this.hotSpot1.ToolTipAutomaticDelay = 500;
            this.hotSpot1.ToolTipAutoPopDelay = 5000;
            this.hotSpot1.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hotSpot1.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hotSpot1.ToolTipFor4ContextMenu = true;
            this.hotSpot1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hotSpot1.ToolTipInitialDelay = 500;
            this.hotSpot1.ToolTipIsBallon = false;
            this.hotSpot1.ToolTipOwnerDraw = false;
            this.hotSpot1.ToolTipReshowDelay = 100;
            this.hotSpot1.ToolTipShowAlways = false;
            this.hotSpot1.ToolTipText = "";
            this.hotSpot1.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hotSpot1.ToolTipTitle = "";
            this.hotSpot1.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hotSpot1.UseVisualStyleBackColor = false;
            // 
            // hsOutliers3
            // 
            this.hsOutliers3.BackColor = System.Drawing.Color.Transparent;
            this.hsOutliers3.BackColorHover = System.Drawing.Color.Transparent;
            this.hsOutliers3.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsOutliers3.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsOutliers3.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsOutliers3.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsOutliers3.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsOutliers3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.hsOutliers3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.hsOutliers3.FlatAppearance.BorderSize = 0;
            this.hsOutliers3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsOutliers3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsOutliers3.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsOutliers3.Image = null;
            this.hsOutliers3.ImageHover = null;
            this.hsOutliers3.ImageToggleOnSelect = false;
            this.hsOutliers3.Location = new System.Drawing.Point(3, 70);
            this.hsOutliers3.Marked = false;
            this.hsOutliers3.MarkedColor = System.Drawing.Color.Teal;
            this.hsOutliers3.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsOutliers3.MarkedText = "";
            this.hsOutliers3.MarkMode = false;
            this.hsOutliers3.Name = "hsOutliers3";
            this.hsOutliers3.NonMarkedText = "";
            this.hsOutliers3.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsOutliers3.ShowShortcut = false;
            this.hsOutliers3.Size = new System.Drawing.Size(119, 21);
            this.hsOutliers3.TabIndex = 22;
            this.hsOutliers3.Text = "1E-3";
            this.hsOutliers3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsOutliers3.ToolTipActive = false;
            this.hsOutliers3.ToolTipAutomaticDelay = 500;
            this.hsOutliers3.ToolTipAutoPopDelay = 5000;
            this.hsOutliers3.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsOutliers3.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsOutliers3.ToolTipFor4ContextMenu = true;
            this.hsOutliers3.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsOutliers3.ToolTipInitialDelay = 500;
            this.hsOutliers3.ToolTipIsBallon = false;
            this.hsOutliers3.ToolTipOwnerDraw = false;
            this.hsOutliers3.ToolTipReshowDelay = 100;
            this.hsOutliers3.ToolTipShowAlways = false;
            this.hsOutliers3.ToolTipText = "";
            this.hsOutliers3.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsOutliers3.ToolTipTitle = "";
            this.hsOutliers3.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsOutliers3.UseVisualStyleBackColor = false;
            this.hsOutliers3.Click += new System.EventHandler(this.hsOutliers3_Click);
            // 
            // hsOutliers6
            // 
            this.hsOutliers6.BackColor = System.Drawing.Color.Transparent;
            this.hsOutliers6.BackColorHover = System.Drawing.Color.Transparent;
            this.hsOutliers6.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsOutliers6.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsOutliers6.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsOutliers6.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsOutliers6.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsOutliers6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.hsOutliers6.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.hsOutliers6.FlatAppearance.BorderSize = 0;
            this.hsOutliers6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsOutliers6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsOutliers6.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsOutliers6.Image = null;
            this.hsOutliers6.ImageHover = null;
            this.hsOutliers6.ImageToggleOnSelect = false;
            this.hsOutliers6.Location = new System.Drawing.Point(3, 91);
            this.hsOutliers6.Marked = false;
            this.hsOutliers6.MarkedColor = System.Drawing.Color.Teal;
            this.hsOutliers6.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsOutliers6.MarkedText = "";
            this.hsOutliers6.MarkMode = false;
            this.hsOutliers6.Name = "hsOutliers6";
            this.hsOutliers6.NonMarkedText = "";
            this.hsOutliers6.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsOutliers6.ShowShortcut = false;
            this.hsOutliers6.Size = new System.Drawing.Size(119, 21);
            this.hsOutliers6.TabIndex = 21;
            this.hsOutliers6.Text = "1E-6";
            this.hsOutliers6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsOutliers6.ToolTipActive = false;
            this.hsOutliers6.ToolTipAutomaticDelay = 500;
            this.hsOutliers6.ToolTipAutoPopDelay = 5000;
            this.hsOutliers6.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsOutliers6.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsOutliers6.ToolTipFor4ContextMenu = true;
            this.hsOutliers6.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsOutliers6.ToolTipInitialDelay = 500;
            this.hsOutliers6.ToolTipIsBallon = false;
            this.hsOutliers6.ToolTipOwnerDraw = false;
            this.hsOutliers6.ToolTipReshowDelay = 100;
            this.hsOutliers6.ToolTipShowAlways = false;
            this.hsOutliers6.ToolTipText = "";
            this.hsOutliers6.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsOutliers6.ToolTipTitle = "";
            this.hsOutliers6.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsOutliers6.UseVisualStyleBackColor = false;
            this.hsOutliers6.Click += new System.EventHandler(this.hsOutliers6_Click);
            // 
            // hsOutlier9
            // 
            this.hsOutlier9.BackColor = System.Drawing.Color.Transparent;
            this.hsOutlier9.BackColorHover = System.Drawing.Color.Transparent;
            this.hsOutlier9.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsOutlier9.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsOutlier9.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsOutlier9.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsOutlier9.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsOutlier9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.hsOutlier9.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.hsOutlier9.FlatAppearance.BorderSize = 0;
            this.hsOutlier9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsOutlier9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsOutlier9.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsOutlier9.Image = null;
            this.hsOutlier9.ImageHover = null;
            this.hsOutlier9.ImageToggleOnSelect = false;
            this.hsOutlier9.Location = new System.Drawing.Point(3, 112);
            this.hsOutlier9.Marked = false;
            this.hsOutlier9.MarkedColor = System.Drawing.Color.Teal;
            this.hsOutlier9.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsOutlier9.MarkedText = "";
            this.hsOutlier9.MarkMode = false;
            this.hsOutlier9.Name = "hsOutlier9";
            this.hsOutlier9.NonMarkedText = "";
            this.hsOutlier9.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsOutlier9.ShowShortcut = false;
            this.hsOutlier9.Size = new System.Drawing.Size(119, 21);
            this.hsOutlier9.TabIndex = 20;
            this.hsOutlier9.Text = "1E-9";
            this.hsOutlier9.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hsOutlier9.ToolTipActive = false;
            this.hsOutlier9.ToolTipAutomaticDelay = 500;
            this.hsOutlier9.ToolTipAutoPopDelay = 5000;
            this.hsOutlier9.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsOutlier9.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsOutlier9.ToolTipFor4ContextMenu = true;
            this.hsOutlier9.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsOutlier9.ToolTipInitialDelay = 500;
            this.hsOutlier9.ToolTipIsBallon = false;
            this.hsOutlier9.ToolTipOwnerDraw = false;
            this.hsOutlier9.ToolTipReshowDelay = 100;
            this.hsOutlier9.ToolTipShowAlways = false;
            this.hsOutlier9.ToolTipText = "";
            this.hsOutlier9.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsOutlier9.ToolTipTitle = "";
            this.hsOutlier9.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsOutlier9.UseVisualStyleBackColor = false;
            this.hsOutlier9.Click += new System.EventHandler(this.hsOutlier9_Click);
            // 
            // txtOutliers
            // 
            this.txtOutliers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOutliers.Location = new System.Drawing.Point(3, 16);
            this.txtOutliers.Name = "txtOutliers";
            this.txtOutliers.Size = new System.Drawing.Size(119, 20);
            this.txtOutliers.TabIndex = 13;
            this.txtOutliers.Text = "0.0";
            // 
            // flpResults
            // 
            this.flpResults.BackColor = System.Drawing.Color.Gainsboro;
            this.flpResults.Controls.Add(this.groupBox6);
            this.flpResults.Controls.Add(this.hsRefreshFiles);
            this.flpResults.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpResults.Location = new System.Drawing.Point(3, 3);
            this.flpResults.Name = "flpResults";
            this.flpResults.Size = new System.Drawing.Size(1763, 48);
            this.flpResults.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.hotSpot2);
            this.groupBox6.Controls.Add(this.txtFilesPath);
            this.groupBox6.Location = new System.Drawing.Point(3, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(874, 36);
            this.groupBox6.TabIndex = 70;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Measfile path";
            // 
            // hotSpot2
            // 
            this.hotSpot2.BackColor = System.Drawing.Color.Transparent;
            this.hotSpot2.BackColorHover = System.Drawing.Color.Transparent;
            this.hotSpot2.BorderColorHover = System.Drawing.Color.Transparent;
            this.hotSpot2.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hotSpot2.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hotSpot2.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hotSpot2.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hotSpot2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.hotSpot2.FlatAppearance.BorderSize = 0;
            this.hotSpot2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hotSpot2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotSpot2.HoverStyle = SeControlsLib.frameStyle.none;
            this.hotSpot2.Image = global::PRCCounterApp.Properties.Resources.folder_closed_22x;
            this.hotSpot2.ImageHover = global::PRCCounterApp.Properties.Resources.folder_open_22x;
            this.hotSpot2.ImageToggleOnSelect = false;
            this.hotSpot2.Location = new System.Drawing.Point(827, 9);
            this.hotSpot2.Marked = false;
            this.hotSpot2.MarkedColor = System.Drawing.Color.Teal;
            this.hotSpot2.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hotSpot2.MarkedText = "";
            this.hotSpot2.MarkMode = false;
            this.hotSpot2.Name = "hotSpot2";
            this.hotSpot2.NonMarkedText = "";
            this.hotSpot2.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hotSpot2.ShowShortcut = false;
            this.hotSpot2.Size = new System.Drawing.Size(45, 23);
            this.hotSpot2.TabIndex = 68;
            this.hotSpot2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hotSpot2.ToolTipActive = false;
            this.hotSpot2.ToolTipAutomaticDelay = 500;
            this.hotSpot2.ToolTipAutoPopDelay = 5000;
            this.hotSpot2.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hotSpot2.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hotSpot2.ToolTipFor4ContextMenu = true;
            this.hotSpot2.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hotSpot2.ToolTipInitialDelay = 500;
            this.hotSpot2.ToolTipIsBallon = false;
            this.hotSpot2.ToolTipOwnerDraw = false;
            this.hotSpot2.ToolTipReshowDelay = 100;
            this.hotSpot2.ToolTipShowAlways = false;
            this.hotSpot2.ToolTipText = "";
            this.hotSpot2.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hotSpot2.ToolTipTitle = "";
            this.hotSpot2.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hotSpot2.UseVisualStyleBackColor = false;
            this.hotSpot2.Click += new System.EventHandler(this.hotSpot2_Click);
            // 
            // txtFilesPath
            // 
            this.txtFilesPath.Location = new System.Drawing.Point(8, 14);
            this.txtFilesPath.Name = "txtFilesPath";
            this.txtFilesPath.Size = new System.Drawing.Size(804, 20);
            this.txtFilesPath.TabIndex = 69;
            this.txtFilesPath.TextChanged += new System.EventHandler(this.txtFilesPath_TextChanged);
            // 
            // hsRefreshFiles
            // 
            this.hsRefreshFiles.BackColor = System.Drawing.Color.Transparent;
            this.hsRefreshFiles.BackColorHover = System.Drawing.Color.Transparent;
            this.hsRefreshFiles.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsRefreshFiles.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsRefreshFiles.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsRefreshFiles.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsRefreshFiles.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsRefreshFiles.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.hsRefreshFiles.FlatAppearance.BorderSize = 0;
            this.hsRefreshFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsRefreshFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsRefreshFiles.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsRefreshFiles.Image = global::PRCCounterApp.Properties.Resources.view_refresh_24x;
            this.hsRefreshFiles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hsRefreshFiles.ImageHover = global::PRCCounterApp.Properties.Resources.view_refresh_2_24x;
            this.hsRefreshFiles.ImageToggleOnSelect = false;
            this.hsRefreshFiles.Location = new System.Drawing.Point(883, 3);
            this.hsRefreshFiles.Marked = false;
            this.hsRefreshFiles.MarkedColor = System.Drawing.Color.Teal;
            this.hsRefreshFiles.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsRefreshFiles.MarkedText = "";
            this.hsRefreshFiles.MarkMode = false;
            this.hsRefreshFiles.Name = "hsRefreshFiles";
            this.hsRefreshFiles.NonMarkedText = "";
            this.hsRefreshFiles.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsRefreshFiles.ShowShortcut = false;
            this.hsRefreshFiles.Size = new System.Drawing.Size(110, 33);
            this.hsRefreshFiles.TabIndex = 66;
            this.hsRefreshFiles.Text = "Refresh Files";
            this.hsRefreshFiles.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hsRefreshFiles.ToolTipActive = false;
            this.hsRefreshFiles.ToolTipAutomaticDelay = 500;
            this.hsRefreshFiles.ToolTipAutoPopDelay = 5000;
            this.hsRefreshFiles.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsRefreshFiles.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsRefreshFiles.ToolTipFor4ContextMenu = true;
            this.hsRefreshFiles.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsRefreshFiles.ToolTipInitialDelay = 500;
            this.hsRefreshFiles.ToolTipIsBallon = false;
            this.hsRefreshFiles.ToolTipOwnerDraw = false;
            this.hsRefreshFiles.ToolTipReshowDelay = 100;
            this.hsRefreshFiles.ToolTipShowAlways = false;
            this.hsRefreshFiles.ToolTipText = "";
            this.hsRefreshFiles.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsRefreshFiles.ToolTipTitle = "";
            this.hsRefreshFiles.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsRefreshFiles.UseVisualStyleBackColor = false;
            this.hsRefreshFiles.Click += new System.EventHandler(this.hsRefreshFiles_Click);
            // 
            // tabPageAppConfiguration
            // 
            this.tabPageAppConfiguration.Controls.Add(this.xmlEditSimpleUserControl1);
            this.tabPageAppConfiguration.ImageKey = "preferences_system_x24.png";
            this.tabPageAppConfiguration.Location = new System.Drawing.Point(4, 23);
            this.tabPageAppConfiguration.Name = "tabPageAppConfiguration";
            this.tabPageAppConfiguration.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAppConfiguration.Size = new System.Drawing.Size(1769, 690);
            this.tabPageAppConfiguration.TabIndex = 4;
            this.tabPageAppConfiguration.Text = "Application configruration";
            this.tabPageAppConfiguration.UseVisualStyleBackColor = true;
            // 
            // xmlEditSimpleUserControl1
            // 
            this.xmlEditSimpleUserControl1.Caption = "Input File";
            this.xmlEditSimpleUserControl1.DefaultExt = "xml";
            this.xmlEditSimpleUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xmlEditSimpleUserControl1.EditorFont = new System.Drawing.Font("Courier New", 10F);
            this.xmlEditSimpleUserControl1.Filter = "Xml files|*.xml|All files|*.*";
            this.xmlEditSimpleUserControl1.KeyName = "XmlFile";
            this.xmlEditSimpleUserControl1.LastXmlDirKey = "LastXmlDir";
            this.xmlEditSimpleUserControl1.Location = new System.Drawing.Point(3, 3);
            this.xmlEditSimpleUserControl1.Margin = new System.Windows.Forms.Padding(0);
            this.xmlEditSimpleUserControl1.MinimumSize = new System.Drawing.Size(200, 100);
            this.xmlEditSimpleUserControl1.Name = "xmlEditSimpleUserControl1";
            this.xmlEditSimpleUserControl1.Size = new System.Drawing.Size(1763, 684);
            this.xmlEditSimpleUserControl1.StatusBarVisible = false;
            this.xmlEditSimpleUserControl1.TabIndex = 0;
            // 
            // tabPageAppLog
            // 
            this.tabPageAppLog.Controls.Add(this.rtbAppLog);
            this.tabPageAppLog.Controls.Add(this.panel2);
            this.tabPageAppLog.ImageKey = "dictionary_blue_24X.png";
            this.tabPageAppLog.Location = new System.Drawing.Point(4, 23);
            this.tabPageAppLog.Name = "tabPageAppLog";
            this.tabPageAppLog.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAppLog.Size = new System.Drawing.Size(1769, 690);
            this.tabPageAppLog.TabIndex = 5;
            this.tabPageAppLog.Text = "Application log\'s";
            this.tabPageAppLog.UseVisualStyleBackColor = true;
            // 
            // rtbAppLog
            // 
            this.rtbAppLog.BackColor = System.Drawing.SystemColors.Info;
            this.rtbAppLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbAppLog.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbAppLog.Location = new System.Drawing.Point(3, 45);
            this.rtbAppLog.Name = "rtbAppLog";
            this.rtbAppLog.Size = new System.Drawing.Size(1763, 642);
            this.rtbAppLog.TabIndex = 15;
            this.rtbAppLog.Text = "";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.hotSpot3);
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1763, 42);
            this.panel2.TabIndex = 16;
            // 
            // hotSpot3
            // 
            this.hotSpot3.BackColor = System.Drawing.Color.Transparent;
            this.hotSpot3.BackColorHover = System.Drawing.Color.Transparent;
            this.hotSpot3.BorderColorHover = System.Drawing.Color.Transparent;
            this.hotSpot3.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hotSpot3.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hotSpot3.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hotSpot3.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hotSpot3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.hotSpot3.FlatAppearance.BorderSize = 0;
            this.hotSpot3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hotSpot3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotSpot3.HoverStyle = SeControlsLib.frameStyle.none;
            this.hotSpot3.Image = global::PRCCounterApp.Properties.Resources.floppy_x24;
            this.hotSpot3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hotSpot3.ImageHover = global::PRCCounterApp.Properties.Resources.floppy2_x24;
            this.hotSpot3.ImageToggleOnSelect = false;
            this.hotSpot3.Location = new System.Drawing.Point(222, 0);
            this.hotSpot3.Marked = false;
            this.hotSpot3.MarkedColor = System.Drawing.Color.Teal;
            this.hotSpot3.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hotSpot3.MarkedText = "";
            this.hotSpot3.MarkMode = false;
            this.hotSpot3.Name = "hotSpot3";
            this.hotSpot3.NonMarkedText = "";
            this.hotSpot3.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hotSpot3.ShowShortcut = false;
            this.hotSpot3.Size = new System.Drawing.Size(131, 42);
            this.hotSpot3.TabIndex = 65;
            this.hotSpot3.Text = "Save Log\'s";
            this.hotSpot3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.hotSpot3.ToolTipActive = false;
            this.hotSpot3.ToolTipAutomaticDelay = 500;
            this.hotSpot3.ToolTipAutoPopDelay = 5000;
            this.hotSpot3.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hotSpot3.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hotSpot3.ToolTipFor4ContextMenu = true;
            this.hotSpot3.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hotSpot3.ToolTipInitialDelay = 500;
            this.hotSpot3.ToolTipIsBallon = false;
            this.hotSpot3.ToolTipOwnerDraw = false;
            this.hotSpot3.ToolTipReshowDelay = 100;
            this.hotSpot3.ToolTipShowAlways = false;
            this.hotSpot3.ToolTipText = "";
            this.hotSpot3.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hotSpot3.ToolTipTitle = "";
            this.hotSpot3.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hotSpot3.UseVisualStyleBackColor = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(28, 14);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(156, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Update log every new entry";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // ckDebugmode
            // 
            this.ckDebugmode.AutoSize = true;
            this.ckDebugmode.Location = new System.Drawing.Point(1571, 21);
            this.ckDebugmode.Name = "ckDebugmode";
            this.ckDebugmode.Size = new System.Drawing.Size(84, 17);
            this.ckDebugmode.TabIndex = 51;
            this.ckDebugmode.Text = "Debugmode";
            this.ckDebugmode.UseVisualStyleBackColor = true;
            this.ckDebugmode.CheckedChanged += new System.EventHandler(this.ckDebugmode_CheckedChanged);
            // 
            // pnlUpper
            // 
            this.pnlUpper.Controls.Add(this.groupBox7);
            this.pnlUpper.Controls.Add(this.hsCloseApp);
            this.pnlUpper.Controls.Add(this.gbActCommand);
            this.pnlUpper.Controls.Add(this.ckDebugmode);
            this.pnlUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUpper.Location = new System.Drawing.Point(0, 0);
            this.pnlUpper.Name = "pnlUpper";
            this.pnlUpper.Size = new System.Drawing.Size(1777, 48);
            this.pnlUpper.TabIndex = 48;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txtActConfigurationFile);
            this.groupBox7.Location = new System.Drawing.Point(559, 5);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(915, 38);
            this.groupBox7.TabIndex = 55;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Act configuration file";
            // 
            // txtActConfigurationFile
            // 
            this.txtActConfigurationFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtActConfigurationFile.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActConfigurationFile.Location = new System.Drawing.Point(3, 16);
            this.txtActConfigurationFile.Name = "txtActConfigurationFile";
            this.txtActConfigurationFile.ReadOnly = true;
            this.txtActConfigurationFile.Size = new System.Drawing.Size(909, 22);
            this.txtActConfigurationFile.TabIndex = 0;
            // 
            // hsCloseApp
            // 
            this.hsCloseApp.BackColor = System.Drawing.Color.Transparent;
            this.hsCloseApp.BackColorHover = System.Drawing.Color.Transparent;
            this.hsCloseApp.BorderColorHover = System.Drawing.Color.Transparent;
            this.hsCloseApp.ContextMenuEdges = SeControlsLib.Edge.Center;
            this.hsCloseApp.ContextMenuXDirection = SeControlsLib.XDirection.Right;
            this.hsCloseApp.ContextMenuYDirection = SeControlsLib.YDirection.Down;
            this.hsCloseApp.DefaultButtonMode = SeControlsLib.BtnMode.Context;
            this.hsCloseApp.Dock = System.Windows.Forms.DockStyle.Left;
            this.hsCloseApp.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.hsCloseApp.FlatAppearance.BorderSize = 0;
            this.hsCloseApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hsCloseApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsCloseApp.HoverStyle = SeControlsLib.frameStyle.none;
            this.hsCloseApp.Image = global::PRCCounterApp.Properties.Resources.go_previous32x;
            this.hsCloseApp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hsCloseApp.ImageHover = global::PRCCounterApp.Properties.Resources.go_left_blue32x;
            this.hsCloseApp.ImageToggleOnSelect = false;
            this.hsCloseApp.Location = new System.Drawing.Point(0, 0);
            this.hsCloseApp.Marked = false;
            this.hsCloseApp.MarkedColor = System.Drawing.Color.Teal;
            this.hsCloseApp.MarkedStyle = SeControlsLib.frameStyle.filled;
            this.hsCloseApp.MarkedText = "";
            this.hsCloseApp.MarkMode = false;
            this.hsCloseApp.Name = "hsCloseApp";
            this.hsCloseApp.NonMarkedText = "";
            this.hsCloseApp.Shortcut = BasicClassLibrary.Shortcut.None;
            this.hsCloseApp.ShowShortcut = false;
            this.hsCloseApp.Size = new System.Drawing.Size(62, 48);
            this.hsCloseApp.TabIndex = 18;
            this.hsCloseApp.Text = "Exit";
            this.hsCloseApp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hsCloseApp.ToolTipActive = false;
            this.hsCloseApp.ToolTipAutomaticDelay = 500;
            this.hsCloseApp.ToolTipAutoPopDelay = 5000;
            this.hsCloseApp.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.hsCloseApp.ToolTipFont = new System.Drawing.Font("Comic Sans MS", 9F);
            this.hsCloseApp.ToolTipFor4ContextMenu = true;
            this.hsCloseApp.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.hsCloseApp.ToolTipInitialDelay = 500;
            this.hsCloseApp.ToolTipIsBallon = false;
            this.hsCloseApp.ToolTipOwnerDraw = false;
            this.hsCloseApp.ToolTipReshowDelay = 100;
            this.hsCloseApp.ToolTipShowAlways = false;
            this.hsCloseApp.ToolTipText = "";
            this.hsCloseApp.ToolTipTextColor = System.Drawing.SystemColors.InfoText;
            this.hsCloseApp.ToolTipTitle = "";
            this.hsCloseApp.ToolTipTitleColor = System.Drawing.Color.Blue;
            this.hsCloseApp.UseVisualStyleBackColor = false;
            this.hsCloseApp.Click += new System.EventHandler(this.hsCloseApp_Click);
            // 
            // gbActCommand
            // 
            this.gbActCommand.Controls.Add(this.txtActInfo);
            this.gbActCommand.Location = new System.Drawing.Point(86, 5);
            this.gbActCommand.Name = "gbActCommand";
            this.gbActCommand.Size = new System.Drawing.Size(470, 39);
            this.gbActCommand.TabIndex = 54;
            this.gbActCommand.TabStop = false;
            this.gbActCommand.Text = "Act info";
            // 
            // txtActInfo
            // 
            this.txtActInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtActInfo.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActInfo.Location = new System.Drawing.Point(3, 16);
            this.txtActInfo.Name = "txtActInfo";
            this.txtActInfo.ReadOnly = true;
            this.txtActInfo.Size = new System.Drawing.Size(464, 22);
            this.txtActInfo.TabIndex = 0;
            // 
            // pnlCenter
            // 
            this.pnlCenter.Controls.Add(this.tabControlMeasurements);
            this.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenter.Location = new System.Drawing.Point(0, 48);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(1777, 717);
            this.pnlCenter.TabIndex = 49;
            // 
            // ofdLoadConfiguration
            // 
            this.ofdLoadConfiguration.DefaultExt = "xml";
            this.ofdLoadConfiguration.FileName = "MeasConfiguration.xml";
            this.ofdLoadConfiguration.Filter = "Configuration File|*.xml";
            this.ofdLoadConfiguration.InitialDirectory = "config";
            this.ofdLoadConfiguration.Title = "Load Measconfiguration";
            // 
            // sfdMeasconfiguration
            // 
            this.sfdMeasconfiguration.DefaultExt = "xml";
            this.sfdMeasconfiguration.Filter = "Meas configuration|*.xml";
            this.sfdMeasconfiguration.InitialDirectory = "Config";
            this.sfdMeasconfiguration.Title = "Save measconfiguration";
            // 
            // sfdLogs
            // 
            this.sfdLogs.DefaultExt = "log";
            this.sfdLogs.Filter = "Log datas|*.log|Text|*.txt|All|*.*";
            this.sfdLogs.InitialDirectory = "Config";
            this.sfdLogs.Title = "Save log datas";
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 43;
            // 
            // STAMP
            // 
            this.STAMP.DataPropertyName = "STAMP";
            dataGridViewCellStyle1.Format = "G";
            dataGridViewCellStyle1.NullValue = null;
            this.STAMP.DefaultCellStyle = dataGridViewCellStyle1;
            this.STAMP.HeaderText = "STAMP";
            this.STAMP.Name = "STAMP";
            this.STAMP.ReadOnly = true;
            this.STAMP.Width = 69;
            // 
            // DATASTAMP
            // 
            this.DATASTAMP.DataPropertyName = "DATASTAMP";
            this.DATASTAMP.HeaderText = "DATASTAMP";
            this.DATASTAMP.Name = "DATASTAMP";
            this.DATASTAMP.ReadOnly = true;
            this.DATASTAMP.Width = 98;
            // 
            // VALUE
            // 
            this.VALUE.DataPropertyName = "VALUE";
            dataGridViewCellStyle2.Format = "E12";
            dataGridViewCellStyle2.NullValue = null;
            this.VALUE.DefaultCellStyle = dataGridViewCellStyle2;
            this.VALUE.HeaderText = "VALUE";
            this.VALUE.Name = "VALUE";
            this.VALUE.ReadOnly = true;
            this.VALUE.Width = 67;
            // 
            // INFO
            // 
            this.INFO.DataPropertyName = "INFO";
            this.INFO.HeaderText = "INFO";
            this.INFO.Name = "INFO";
            this.INFO.ReadOnly = true;
            this.INFO.Width = 57;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1777, 765);
            this.Controls.Add(this.pnlCenter);
            this.Controls.Add(this.pnlUpper);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(dataTable1)).EndInit();
            this.gbSleep.ResumeLayout(false);
            this.gbSleep.PerformLayout();
            this.gbNumTags0.ResumeLayout(false);
            this.gbNumTags0.PerformLayout();
            this.gbLoops.ResumeLayout(false);
            this.gbLoops.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gbMeasSkip.ResumeLayout(false);
            this.gbMeasSkip.PerformLayout();
            this.tabControlMeasurements.ResumeLayout(false);
            this.tabPageMeasurement.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.tabControlResultConfiguration.ResumeLayout(false);
            this.tabPageResults.ResumeLayout(false);
            this.gbMeasResults.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsResults)).EndInit();
            this.tabPageMeasResultsLog.ResumeLayout(false);
            this.pnlLogUpper.ResumeLayout(false);
            this.pnlLogUpper.PerformLayout();
            this.tabPageMeasResultsErrorlog.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPageCounterTesting.ResumeLayout(false);
            this.tabPageCounterTesting.PerformLayout();
            this.tabPageMeasurementConfiguration.ResumeLayout(false);
            this.pnlMeasconfigCenter.ResumeLayout(false);
            this.gbUserDefinedAttributes.ResumeLayout(false);
            this.gbYOffset.ResumeLayout(false);
            this.gbYOffset.PerformLayout();
            this.gbMeasinfo.ResumeLayout(false);
            this.gbScaleYAxis.ResumeLayout(false);
            this.gbScaleYAxis.PerformLayout();
            this.gbGraphLegend.ResumeLayout(false);
            this.gbGraphLegend.PerformLayout();
            this.gbXLegend.ResumeLayout(false);
            this.gbXLegend.PerformLayout();
            this.gbYLegend.ResumeLayout(false);
            this.gbYLegend.PerformLayout();
            this.gbMeasinfos.ResumeLayout(false);
            this.gbMeasinfos.PerformLayout();
            this.gbMeasname.ResumeLayout(false);
            this.gbMeasname.PerformLayout();
            this.cbActualMeasConfiguration.ResumeLayout(false);
            this.cbActualMeasConfiguration.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.gbMeasconfigDevice.ResumeLayout(false);
            this.gbSleepAfterSingleRead.ResumeLayout(false);
            this.gbSleepAfterSingleRead.PerformLayout();
            this.gbMeasType.ResumeLayout(false);
            this.gbMeasType.PerformLayout();
            this.gbMeasOptions.ResumeLayout(false);
            this.gbMeasGate1.ResumeLayout(false);
            this.gbMeasGate1.PerformLayout();
            this.gbMeasGate0.ResumeLayout(false);
            this.gbMeasGate0.PerformLayout();
            this.gbNumTags1.ResumeLayout(false);
            this.gbNumTags1.PerformLayout();
            this.gbMeasSkip1.ResumeLayout(false);
            this.gbMeasSkip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.gbClockExternFreq.ResumeLayout(false);
            this.gbClockExternFreq.PerformLayout();
            this.gbSelectClock.ResumeLayout(false);
            this.gbSelectClock.PerformLayout();
            this.gbThresholdClock.ResumeLayout(false);
            this.gbThresholdClock.PerformLayout();
            this.gbInputs.ResumeLayout(false);
            this.gbTresholdB.ResumeLayout(false);
            this.gbTresholdB.PerformLayout();
            this.gbTresholdA.ResumeLayout(false);
            this.gbTresholdA.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.gbPrescaleA.ResumeLayout(false);
            this.gbChannelAImpedance.ResumeLayout(false);
            this.gbChannelAImpedance.PerformLayout();
            this.gbChannelAVoltage.ResumeLayout(false);
            this.gbChannelAVoltage.PerformLayout();
            this.gbChannelBImpedance.ResumeLayout(false);
            this.gbChannelBImpedance.PerformLayout();
            this.gbChannelBVoltage.ResumeLayout(false);
            this.gbChannelBVoltage.PerformLayout();
            this.gbChannelBCoupling.ResumeLayout(false);
            this.gbChannelBCoupling.PerformLayout();
            this.gbChannelACoupling.ResumeLayout(false);
            this.gbChannelACoupling.PerformLayout();
            this.pnlMeasconfigUpper.ResumeLayout(false);
            this.gbConfigurationFile.ResumeLayout(false);
            this.gbConfigurationFile.PerformLayout();
            this.gbMeasPathAndFormats.ResumeLayout(false);
            this.gbMeasPathAndFormats.PerformLayout();
            this.gbDatasource.ResumeLayout(false);
            this.gbDatasource.PerformLayout();
            this.gbResultName.ResumeLayout(false);
            this.gbResultName.PerformLayout();
            this.gbMeasResultFormat.ResumeLayout(false);
            this.gbMeasResultFormat.PerformLayout();
            this.gbMeasresultPath.ResumeLayout(false);
            this.gbMeasresultPath.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeasResultConfiguration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOutputDefinition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOutputDefintion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2)).EndInit();
            this.tabPageMeasFiles.ResumeLayout(false);
            this.pnlMeasResultsCenter.ResumeLayout(false);
            this.gbFileInfos.ResumeLayout(false);
            this.spcResultFiles.Panel1.ResumeLayout(false);
            this.spcResultFiles.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcResultFiles)).EndInit();
            this.spcResultFiles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbDatafile.ResumeLayout(false);
            this.gbHeaderfile.ResumeLayout(false);
            this.pnlResultfilesLeft.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.gbMeasAttMeasOffset.ResumeLayout(false);
            this.gbMeasAttMeasOffset.PerformLayout();
            this.gbMeasAttEndtime.ResumeLayout(false);
            this.gbMeasAttEndtime.PerformLayout();
            this.gbMeasAttStarttime.ResumeLayout(false);
            this.gbMeasAttStarttime.PerformLayout();
            this.gbMeasAttStartdate.ResumeLayout(false);
            this.gbMeasAttStartdate.PerformLayout();
            this.gbMeasAttMeasDevice.ResumeLayout(false);
            this.gbMeasAttMeasDevice.PerformLayout();
            this.gbMeasAttScaleYAxis.ResumeLayout(false);
            this.gbMeasAttScaleYAxis.PerformLayout();
            this.gbMeasAttGraph.ResumeLayout(false);
            this.gbMeasAttGraph.PerformLayout();
            this.gbMeasAttXLegend.ResumeLayout(false);
            this.gbMeasAttXLegend.PerformLayout();
            this.gbMeasAttYLegend.ResumeLayout(false);
            this.gbMeasAttYLegend.PerformLayout();
            this.gbMeasAttMeasName.ResumeLayout(false);
            this.gbMeasAttMeasName.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.gbStatistikType.ResumeLayout(false);
            this.gbStatistikType.PerformLayout();
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
            this.gbOutliers.ResumeLayout(false);
            this.gbOutliers.PerformLayout();
            this.flpResults.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.tabPageAppConfiguration.ResumeLayout(false);
            this.tabPageAppLog.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlUpper.ResumeLayout(false);
            this.pnlUpper.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.gbActCommand.ResumeLayout(false);
            this.gbActCommand.PerformLayout();
            this.pnlCenter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtResultIsMaster;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtResultBoardModel;
        private System.Windows.Forms.TextBox txtResultSerial;
        private System.Windows.Forms.Button btnSerialNumber;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtResultInitialize;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txtBoard;
        private System.Windows.Forms.TextBox txtSleep;
        private System.Windows.Forms.GroupBox gbSleep;
        private System.Windows.Forms.GroupBox gbNumTags0;
        private System.Windows.Forms.TextBox txtNumTags0;
        private System.Windows.Forms.GroupBox gbLoops;
        private System.Windows.Forms.TextBox txtLoops;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox txtMeasInput;
        private System.Windows.Forms.TextBox txtDriver;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSetInputA;
        private System.Windows.Forms.TextBox txtInputA;
        private System.Windows.Forms.CheckBox ckShowResults;
        private System.Windows.Forms.TextBox txtCh2;
        private System.Windows.Forms.CheckBox ckNewMeas;
        private System.Windows.Forms.CheckBox ckChannel0;
        private System.Windows.Forms.CheckBox ckChannel1;
        private System.Windows.Forms.GroupBox gbMeasSkip;
        private System.Windows.Forms.TextBox txtMeasSkipCh0;
        private System.Windows.Forms.TextBox txtMeasSkipCh1;
        private System.Windows.Forms.CheckBox ckMemoryWrap;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox txtInputB;
        private System.Windows.Forms.Button btnSetInputB;
        private System.Windows.Forms.TextBox txtCalibrate;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.CheckBox ckCal;
        private System.Windows.Forms.TextBox txtSetRealtime;
        private System.Windows.Forms.Button btnSetRealtime;
        private System.Windows.Forms.TextBox txtGetRealtime1;
        private System.Windows.Forms.TextBox txtGetRealtime2;
        private System.Windows.Forms.CheckBox ckReadRAW;
        private System.Windows.Forms.CheckBox ckTagsSucceded;
        private System.Windows.Forms.CheckBox ckReadAllErrors;
        private System.Windows.Forms.Label lblBoardInit;
        private System.Windows.Forms.Label lblChannelInputBPos;
        private System.Windows.Forms.Label lblChannelInputAPos;
        private System.Windows.Forms.Label lblChanneMeasinoutl;
        private System.Windows.Forms.Label lblInpMeasinout;
        private System.Windows.Forms.TabControl tabControlMeasurements;
        private System.Windows.Forms.TabPage tabPageMeasurement;
        private System.Windows.Forms.TabPage tabPageCounterTesting;
        private System.Windows.Forms.TabPage tabPageMeasurementConfiguration;
        private System.Windows.Forms.TabControl tabControlResultConfiguration;
        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.BindingSource bsResults;
        private System.Data.DataColumn colID;
        private System.Data.DataColumn colSTAMP;
        private System.Data.DataColumn colDATASTAMP;
        private System.Data.DataColumn colVALUE;
        private System.Windows.Forms.TabPage tabPageMeasResultsLog;
        private System.Windows.Forms.Panel pnlLogUpper;
        private System.Windows.Forms.RichTextBox rtResultLogs;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox gbPrescaleA;
        private SeControlsLib.HotSpot hsAssignLoops;
        private System.Windows.Forms.GroupBox gbMeasSkip1;
        private System.Windows.Forms.GroupBox gbInputs;
        private System.Windows.Forms.GroupBox gbMeasOptions;
        private System.Windows.Forms.GroupBox gbNumTags1;
        private System.Windows.Forms.TextBox txtNumTags1;
        private System.Windows.Forms.TextBox txtInitDefault;
        private System.Windows.Forms.Panel pnlUpper;
        private System.Windows.Forms.Panel pnlCenter;
        private System.Windows.Forms.BindingSource bsOutputDefinition;
        private System.Data.DataSet dsOutputDefintion;
        private System.Data.DataTable dataTable2;
        private System.Data.DataColumn col_outdefID;
        private System.Data.DataColumn col_outdefPATH;
        private System.Data.DataColumn col_outdefFORMAT;
        private System.Data.DataColumn col_outdefACTIVE;
        private SeControlsLib.HotSpot hsCloseApp;
        private System.Windows.Forms.TextBox txtSelectDev;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TextBox txtSelectDeviceResult;
        private System.Windows.Forms.CheckBox ckSetClock;
        private System.Windows.Forms.Label lblVDeviceAssign;
        private System.Windows.Forms.TextBox txtVirtDev;
        private System.Windows.Forms.Label lblPhysBoardAssign;
        private System.Windows.Forms.TextBox txtPhysBd;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.TextBox txtAssignResult;
        private System.Windows.Forms.Label lblDevMaskSystemInit;
        private System.Windows.Forms.TextBox txtSystemInitDevMask;
        private System.Windows.Forms.Label lblDevSystemInit;
        private System.Windows.Forms.TextBox txtSystemInitDev;
        private System.Windows.Forms.Button btnSystemInit;
        private System.Windows.Forms.TextBox txtResultSystemInit;
        private System.Windows.Forms.TextBox txtResultBoard;
        private System.Windows.Forms.CheckBox ckFirst;
        private System.Windows.Forms.TextBox txtResuldBoardError;
        private System.Windows.Forms.Button btnGetBoard;
        private System.Windows.Forms.Label lblBoardIsInit;
        private System.Windows.Forms.TextBox txtIsInitDev;
        private System.Windows.Forms.Button btnIsInit;
        private System.Windows.Forms.TextBox txtResultIsInitDev;
        private System.Windows.Forms.Button btnCloseDevice;
        private System.Windows.Forms.TextBox txtResultCloseDevice;
        private System.Windows.Forms.Button btnRecreateAPI;
        private System.Windows.Forms.Button btnSystemCLose;
        private System.Windows.Forms.TextBox txtErrorBoardRevision;
        private System.Windows.Forms.Button btnBoardRevision;
        private System.Windows.Forms.TextBox txtResultBoardRevision;
        private System.Windows.Forms.GroupBox gbMeasType;
        private System.Windows.Forms.RadioButton rbFrequencyA;
        private System.Windows.Forms.RadioButton rbPhaseAB;
        private System.Windows.Forms.GroupBox gbTresholdB;
        private System.Windows.Forms.TextBox txtThresholdB;
        private System.Windows.Forms.GroupBox gbTresholdA;
        private System.Windows.Forms.TextBox txtThresholdA;
        private System.Data.DataColumn colINFO;
        private System.Windows.Forms.GroupBox gbThresholdClock;
        private System.Windows.Forms.TextBox txtThresholdClock;
        private System.Windows.Forms.ComboBox cbPrescaleB;
        private System.Windows.Forms.ComboBox cbPrescaleA;
        private System.Windows.Forms.CheckBox ckDebugmode;
        private System.Windows.Forms.GroupBox cbActualMeasConfiguration;
        private System.Windows.Forms.GroupBox gbMeasinfo;
        private System.Windows.Forms.GroupBox gbMeasname;
        private System.Windows.Forms.TextBox txtMeasname;
        private System.Windows.Forms.GroupBox gbMeasresultPath;
        private SeControlsLib.HotSpot hsMeasPath;
        private System.Windows.Forms.TextBox txtMeasResultDefinitionPath;
        private System.Windows.Forms.GroupBox gbMeasinfos;
        private System.Windows.Forms.TextBox txtMeasinfo;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabPage tabPageResults;
        private System.Windows.Forms.GroupBox gbMeasResults;
        private System.Windows.Forms.GroupBox gbMeasPathAndFormats;
        private System.Windows.Forms.GroupBox gbResultName;
        private System.Windows.Forms.TextBox txtMeasResultDefinitionFilePattern;
        private SeControlsLib.HotSpot hsRemoveMeasResultDefinition;
        private SeControlsLib.HotSpot hsUpdateMeasResultDefinition;
        private SeControlsLib.HotSpot hsAddMeasResultDefinition;
        private System.Windows.Forms.GroupBox gbMeasResultFormat;
        private System.Windows.Forms.TextBox txtMeasResultDefinitionFormat;
        private System.Windows.Forms.DataGridView dgvMeasResultConfiguration;
        private System.Windows.Forms.CheckBox ckMeasResultDefinitionActive;
        private System.Data.DataColumn col_outdefFILEPATTERN;
        private System.Windows.Forms.GroupBox gbChannelAVoltage;
        private System.Windows.Forms.RadioButton rbChannelANegativeVoltage;
        private System.Windows.Forms.RadioButton rbChannelAPositiveVoltage;
        private System.Windows.Forms.GroupBox gbChannelBVoltage;
        private System.Windows.Forms.RadioButton rbChannelBNegativeVoltage;
        private System.Windows.Forms.RadioButton rbChannelBPositiveVoltage;
        private System.Windows.Forms.GroupBox gbChannelBCoupling;
        private System.Windows.Forms.RadioButton rbChannelBCouplingAC;
        private System.Windows.Forms.RadioButton rbChannelBCouplingDC;
        private System.Windows.Forms.GroupBox gbChannelACoupling;
        private System.Windows.Forms.RadioButton rbChannelACouplingAC;
        private System.Windows.Forms.RadioButton rbChannelACouplingDC;
        private System.Windows.Forms.GroupBox gbChannelAImpedance;
        private System.Windows.Forms.RadioButton rbChannelAImpedanceHIGH;
        private System.Windows.Forms.RadioButton rbChannelAImpedanceLO;
        private System.Windows.Forms.GroupBox gbChannelBImpedance;
        private System.Windows.Forms.RadioButton rbChannelBImpedanceHIGH;
        private System.Windows.Forms.RadioButton rbChannelBImpedanceLO;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbClockExternFreq;
        private System.Windows.Forms.RadioButton rbClock10MHZ;
        private System.Windows.Forms.RadioButton rbClock5MHZ;
        private System.Windows.Forms.GroupBox gbSelectClock;
        private System.Windows.Forms.RadioButton rbUseInternClock;
        private System.Windows.Forms.RadioButton rbClockUseExtern;
        private System.Windows.Forms.GroupBox gbConfigurationFile;
        private SeControlsLib.HotSpot hsLoadConfigurationFile;
        private System.Windows.Forms.TextBox txtConfigurationFile;
        private System.Windows.Forms.OpenFileDialog ofdLoadConfiguration;
        private SeControlsLib.HotSpot hsSaveMeasconfiguration;
        private System.Windows.Forms.SaveFileDialog sfdMeasconfiguration;
        private System.Windows.Forms.CheckBox cbResultLogActive;
        private SeControlsLib.HotSpot hsSaveMeasResultsLogs;
        private System.Windows.Forms.SaveFileDialog sfdLogs;
        private System.Windows.Forms.GroupBox gbSleepAfterSingleRead;
        private System.Windows.Forms.TextBox txtSleepEverySingleRead;
        private System.Windows.Forms.GroupBox groupBox4;
        private SeControlsLib.HotSpot hsSetPhase_A_B;
        private SeControlsLib.HotSpot hsSetFrequencyMeasurment_A;
        private System.Windows.Forms.Panel pnlMeasconfigUpper;
        private System.Windows.Forms.Panel pnlMeasconfigCenter;
        private System.Windows.Forms.GroupBox gbDatasource;
        private System.Windows.Forms.RadioButton rbResultLiteDB;
        private System.Windows.Forms.RadioButton rbResultFile;
        private System.Data.DataColumn dataColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn outdefID;
        private System.Windows.Forms.DataGridViewTextBoxColumn outdefFILEPATTERN;
        private System.Windows.Forms.DataGridViewTextBoxColumn outdefPATH;
        private System.Windows.Forms.DataGridViewTextBoxColumn outdefFORMAT;
        private System.Windows.Forms.DataGridViewCheckBoxColumn outdefACTIVE;
        private System.Windows.Forms.DataGridViewTextBoxColumn outdefDATASOURCE;
        private System.Windows.Forms.RadioButton rbFrequency_A_B;
        private SeControlsLib.HotSpot hs_SetFrequency_A_B;
        private System.Windows.Forms.GroupBox gbActCommand;
        private System.Windows.Forms.TextBox txtActInfo;
        private SeControlsLib.HotSpot hsRun;
        private SeControlsLib.HotSpot hsStop;
        private System.Windows.Forms.TabPage tabPageMeasResultsErrorlog;
        private System.Windows.Forms.RichTextBox rtResultsErrorLog;
        private System.Windows.Forms.Panel panel1;
        private SeControlsLib.HotSpot hsSaveMeasResultErrorLogs;
        private System.Windows.Forms.CheckBox cbUpdateErrorLogEveryNewEntry;
        private SeControlsLib.HotSpot hsTestFrequency;
        private System.Windows.Forms.GroupBox gbUserDefinedAttributes;
        private System.Windows.Forms.GroupBox gbYOffset;
        private System.Windows.Forms.TextBox txtYOffset;
        private System.Windows.Forms.TabPage tabPageMeasFiles;
        private System.Windows.Forms.Panel pnlMeasResultsCenter;
        private System.Windows.Forms.GroupBox gbFileInfos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFileCreate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFileSize;
        private System.Windows.Forms.Panel pnlResultfilesLeft;
        private System.Windows.Forms.GroupBox gbOutliers;
        private SeControlsLib.HotSpot hotSpot1;
        private SeControlsLib.HotSpot hsOutliers3;
        private SeControlsLib.HotSpot hsOutliers6;
        private SeControlsLib.HotSpot hsOutlier9;
        private System.Windows.Forms.TextBox txtOutliers;
        private SeControlsLib.HotSpot hsRefreshFiles;
        private SeControlsLib.HotSpot hsRunGraph;
        private System.Windows.Forms.FlowLayoutPanel flpResults;
        private SeControlsLib.HotSpot hotSpot2;
        private System.Windows.Forms.TextBox txtFilesPath;
        private System.Windows.Forms.FolderBrowserDialog fbdResultFiles;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TabPage tabPageAppConfiguration;
        private XMLSimlpeEdit.XMLEditSimpleUserControl xmlEditSimpleUserControl1;
        private System.Windows.Forms.TabPage tabPageAppLog;
        private System.Windows.Forms.RichTextBox rtbAppLog;
        private System.Windows.Forms.Panel panel2;
        private SeControlsLib.HotSpot hotSpot3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.GroupBox gbGraphLegend;
        private System.Windows.Forms.TextBox txtGraphLegend;
        private System.Windows.Forms.GroupBox gbXLegend;
        private System.Windows.Forms.TextBox txtXLegend;
        private System.Windows.Forms.GroupBox gbYLegend;
        private System.Windows.Forms.TextBox txtYLegend;
        private System.Windows.Forms.CheckBox cbUseHeaderfile;
        private System.Windows.Forms.RichTextBox rtbDataFile;
        private System.Windows.Forms.GroupBox gbMeasGate1;
        private System.Windows.Forms.TextBox txtMeasGate1;
        private System.Windows.Forms.GroupBox gbMeasGate0;
        private System.Windows.Forms.TextBox txtMeasGate0;
        private System.Windows.Forms.GroupBox gbScaleYAxis;
        private System.Windows.Forms.TextBox txtScaleYAxis;
        private System.Windows.Forms.RadioButton rbTimeAnalyzerFile;
        private System.Windows.Forms.RadioButton rbAVARFile;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox txtActConfigurationFile;
        private System.Data.DataSet dsResults;
        private SeControlsLib.HotSpot hsShowGraphStatistik;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox gbStatistikType;
        private System.Windows.Forms.CheckBox ckMDEV;
        private System.Windows.Forms.CheckBox ckOADEV;
        private System.Windows.Forms.CheckBox ckADEV;
        private System.Windows.Forms.CheckBox ckTDEV;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox gbMeasAttScaleYAxis;
        private System.Windows.Forms.TextBox txtMeasAttScaleYAxis;
        private System.Windows.Forms.GroupBox gbMeasAttGraph;
        private System.Windows.Forms.TextBox txtMeasAttGraphLegend;
        private System.Windows.Forms.GroupBox gbMeasAttXLegend;
        private System.Windows.Forms.TextBox txtMeasAttXLegend;
        private System.Windows.Forms.GroupBox gbMeasAttYLegend;
        private System.Windows.Forms.TextBox txtMeasAttYLegend;
        private System.Windows.Forms.GroupBox gbMeasAttMeasName;
        private System.Windows.Forms.TextBox txtMeasAttMeasName;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.GroupBox gbMeasAttMeasDevice;
        private System.Windows.Forms.TextBox txtMeasAttMeasDevice;
        private System.Windows.Forms.GroupBox gbHeaderfile;
        private System.Windows.Forms.RichTextBox rtbHeaderfile;
        private SeControlsLib.HotSpot hsMakeHeader;
        private System.Windows.Forms.SplitContainer spcResultFiles;
        private System.Windows.Forms.GroupBox gbDatafile;
        private System.Windows.Forms.GroupBox gbMeasAttStartdate;
        private System.Windows.Forms.TextBox txtMeasAttStartdate;
        private System.Windows.Forms.GroupBox gbMeasAttEndtime;
        private System.Windows.Forms.TextBox txtMeasAttEndtime;
        private System.Windows.Forms.GroupBox gbMeasAttStarttime;
        private System.Windows.Forms.TextBox txtMeasAttStarttime;
        private System.Windows.Forms.GroupBox gbMeasAttMeasOffset;
        private System.Windows.Forms.TextBox txtMeasAttMeasOffset;
        private System.Windows.Forms.GroupBox gbMeasconfigDevice;
        private System.Windows.Forms.ComboBox cbMeasconfigDevice;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn STAMP;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATASTAMP;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALUE;
        private System.Windows.Forms.DataGridViewTextBoxColumn INFO;
    }
}

