namespace Document_view_for_musicTheory
{
    partial class Jam
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
            this.label_key = new System.Windows.Forms.Label();
            this.label_scale = new System.Windows.Forms.Label();
            this.comboBox_keys = new System.Windows.Forms.ComboBox();
            this.comboBox_scales = new System.Windows.Forms.ComboBox();
            this.label_list_of_notes = new System.Windows.Forms.Label();
            this.listBox_notes_in_scales = new System.Windows.Forms.ListBox();
            this.button_scale = new System.Windows.Forms.Button();
            this.button_modes = new System.Windows.Forms.Button();
            this.combox_mode = new System.Windows.Forms.ComboBox();
            this.label_mode = new System.Windows.Forms.Label();
            this.listBox_notes_in_chord = new System.Windows.Forms.ListBox();
            this.label_notes_in_chords = new System.Windows.Forms.Label();
            this.comboBox_chords = new System.Windows.Forms.ComboBox();
            this.label_chords = new System.Windows.Forms.Label();
            this.button_chord = new System.Windows.Forms.Button();
            this.button_relative_minor = new System.Windows.Forms.Button();
            this.textBox_relativeMinor = new System.Windows.Forms.TextBox();
            this.listBox_notes_in_mode = new System.Windows.Forms.ListBox();
            this.label_note_in_mode = new System.Windows.Forms.Label();
            this.comboBox_list_of_jam_songs = new System.Windows.Forms.ComboBox();
            this.button_start_jamming = new System.Windows.Forms.Button();
            this.button_Stop_jamming = new System.Windows.Forms.Button();
            this.label_jam = new System.Windows.Forms.Label();
            this.label_select_jam_songs = new System.Windows.Forms.Label();
            this.button_recommend_scales = new System.Windows.Forms.Button();
            this.button_scaleDiagram = new System.Windows.Forms.Button();
            this.button_modeDiagram = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_key
            // 
            this.label_key.AutoSize = true;
            this.label_key.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label_key.ForeColor = System.Drawing.Color.Blue;
            this.label_key.Location = new System.Drawing.Point(542, 38);
            this.label_key.Name = "label_key";
            this.label_key.Size = new System.Drawing.Size(57, 30);
            this.label_key.TabIndex = 0;
            this.label_key.Text = "Key";
            // 
            // label_scale
            // 
            this.label_scale.AutoSize = true;
            this.label_scale.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_scale.ForeColor = System.Drawing.Color.Blue;
            this.label_scale.Location = new System.Drawing.Point(541, 138);
            this.label_scale.Name = "label_scale";
            this.label_scale.Size = new System.Drawing.Size(77, 30);
            this.label_scale.TabIndex = 1;
            this.label_scale.Text = "Scale";
            // 
            // comboBox_keys
            // 
            this.comboBox_keys.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.comboBox_keys.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.comboBox_keys.FormattingEnabled = true;
            this.comboBox_keys.Items.AddRange(new object[] {
            "C",
            "C#",
            "Db",
            "D",
            "D#",
            "Eb",
            "E",
            "E#",
            "Fb",
            "F",
            "F#",
            "Gb",
            "G",
            "G#",
            "Gb",
            "A",
            "A#",
            "Ab",
            "B",
            "B#",
            "Bb"});
            this.comboBox_keys.Location = new System.Drawing.Point(547, 79);
            this.comboBox_keys.Name = "comboBox_keys";
            this.comboBox_keys.Size = new System.Drawing.Size(74, 38);
            this.comboBox_keys.TabIndex = 2;
            this.comboBox_keys.Text = "C";
            this.comboBox_keys.SelectedIndexChanged += new System.EventHandler(this.comboBox_keys_SelectedIndexChanged);
            // 
            // comboBox_scales
            // 
            this.comboBox_scales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.comboBox_scales.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_scales.FormattingEnabled = true;
            this.comboBox_scales.Items.AddRange(new object[] {
            "Major Scale",
            "Minor (Natural) Scale",
            "Harmonic Minor Scale",
            "Melodic Minor Scale",
            "Pentatonic Major",
            "Pentatonic Minor",
            "Blues",
            "Japanese (Sen)",
            "Japanese (Hirajoshi)",
            "Bebop (Mixolydian)",
            "Bebop (Dorian)",
            "Bebop (Major)",
            "Spanish Scale"});
            this.comboBox_scales.Location = new System.Drawing.Point(545, 189);
            this.comboBox_scales.Name = "comboBox_scales";
            this.comboBox_scales.Size = new System.Drawing.Size(310, 38);
            this.comboBox_scales.TabIndex = 3;
            this.comboBox_scales.Text = "Major Scale";
            this.comboBox_scales.SelectedIndexChanged += new System.EventHandler(this.comboBox_scales_SelectedIndexChanged);
            // 
            // label_list_of_notes
            // 
            this.label_list_of_notes.AutoSize = true;
            this.label_list_of_notes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_list_of_notes.ForeColor = System.Drawing.Color.Blue;
            this.label_list_of_notes.Location = new System.Drawing.Point(542, 419);
            this.label_list_of_notes.Name = "label_list_of_notes";
            this.label_list_of_notes.Size = new System.Drawing.Size(185, 30);
            this.label_list_of_notes.TabIndex = 4;
            this.label_list_of_notes.Text = "Notes in Scale ";
            // 
            // listBox_notes_in_scales
            // 
            this.listBox_notes_in_scales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.listBox_notes_in_scales.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_notes_in_scales.FormattingEnabled = true;
            this.listBox_notes_in_scales.ItemHeight = 25;
            this.listBox_notes_in_scales.Location = new System.Drawing.Point(546, 475);
            this.listBox_notes_in_scales.Name = "listBox_notes_in_scales";
            this.listBox_notes_in_scales.Size = new System.Drawing.Size(184, 254);
            this.listBox_notes_in_scales.TabIndex = 5;
            // 
            // button_scale
            // 
            this.button_scale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_scale.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_scale.ForeColor = System.Drawing.Color.Snow;
            this.button_scale.Location = new System.Drawing.Point(545, 235);
            this.button_scale.Name = "button_scale";
            this.button_scale.Size = new System.Drawing.Size(222, 49);
            this.button_scale.TabIndex = 6;
            this.button_scale.Text = "Get Scale";
            this.button_scale.UseVisualStyleBackColor = false;
            this.button_scale.Click += new System.EventHandler(this.button_scale_Click);
            // 
            // button_modes
            // 
            this.button_modes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_modes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_modes.ForeColor = System.Drawing.Color.Snow;
            this.button_modes.Location = new System.Drawing.Point(884, 235);
            this.button_modes.Name = "button_modes";
            this.button_modes.Size = new System.Drawing.Size(223, 49);
            this.button_modes.TabIndex = 7;
            this.button_modes.Text = "Get Mode";
            this.button_modes.UseVisualStyleBackColor = false;
            this.button_modes.Click += new System.EventHandler(this.button_modes_Click);
            // 
            // combox_mode
            // 
            this.combox_mode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.combox_mode.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combox_mode.FormattingEnabled = true;
            this.combox_mode.Items.AddRange(new object[] {
            "Ionian (I)",
            "Dorian (II)",
            "Phrygian (III)",
            "Lydian (IV)",
            "Mixolydian (V)",
            "Aeolian (VI)",
            "Locrian (VII)"});
            this.combox_mode.Location = new System.Drawing.Point(884, 189);
            this.combox_mode.Name = "combox_mode";
            this.combox_mode.Size = new System.Drawing.Size(223, 38);
            this.combox_mode.TabIndex = 9;
            this.combox_mode.Text = "Ionian (I)";
            this.combox_mode.SelectedIndexChanged += new System.EventHandler(this.combox_mode_SelectedIndexChanged);
            // 
            // label_mode
            // 
            this.label_mode.AutoSize = true;
            this.label_mode.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_mode.ForeColor = System.Drawing.Color.Blue;
            this.label_mode.Location = new System.Drawing.Point(880, 138);
            this.label_mode.Name = "label_mode";
            this.label_mode.Size = new System.Drawing.Size(77, 30);
            this.label_mode.TabIndex = 8;
            this.label_mode.Text = "Mode";
            // 
            // listBox_notes_in_chord
            // 
            this.listBox_notes_in_chord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.listBox_notes_in_chord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_notes_in_chord.FormattingEnabled = true;
            this.listBox_notes_in_chord.ItemHeight = 25;
            this.listBox_notes_in_chord.Location = new System.Drawing.Point(1200, 475);
            this.listBox_notes_in_chord.Name = "listBox_notes_in_chord";
            this.listBox_notes_in_chord.Size = new System.Drawing.Size(178, 254);
            this.listBox_notes_in_chord.TabIndex = 11;
            // 
            // label_notes_in_chords
            // 
            this.label_notes_in_chords.AutoSize = true;
            this.label_notes_in_chords.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_notes_in_chords.ForeColor = System.Drawing.Color.Blue;
            this.label_notes_in_chords.Location = new System.Drawing.Point(1196, 419);
            this.label_notes_in_chords.Name = "label_notes_in_chords";
            this.label_notes_in_chords.Size = new System.Drawing.Size(197, 30);
            this.label_notes_in_chords.TabIndex = 10;
            this.label_notes_in_chords.Text = "Notes in Chrods";
            // 
            // comboBox_chords
            // 
            this.comboBox_chords.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.comboBox_chords.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_chords.FormattingEnabled = true;
            this.comboBox_chords.Items.AddRange(new object[] {
            "Major",
            "Major7",
            "Major9",
            "Minor",
            "Minor7",
            "Minor7b5",
            "Minor9",
            "Dominant",
            "Dominant9",
            "Dominant11",
            "Dominant13"});
            this.comboBox_chords.Location = new System.Drawing.Point(1200, 189);
            this.comboBox_chords.Name = "comboBox_chords";
            this.comboBox_chords.Size = new System.Drawing.Size(178, 38);
            this.comboBox_chords.TabIndex = 14;
            this.comboBox_chords.Text = "Major";
            this.comboBox_chords.SelectedIndexChanged += new System.EventHandler(this.comboBox_chords_SelectedIndexChanged);
            // 
            // label_chords
            // 
            this.label_chords.AutoSize = true;
            this.label_chords.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_chords.ForeColor = System.Drawing.Color.Blue;
            this.label_chords.Location = new System.Drawing.Point(1196, 138);
            this.label_chords.Name = "label_chords";
            this.label_chords.Size = new System.Drawing.Size(96, 30);
            this.label_chords.TabIndex = 13;
            this.label_chords.Text = "Chords";
            // 
            // button_chord
            // 
            this.button_chord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_chord.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_chord.ForeColor = System.Drawing.Color.Snow;
            this.button_chord.Location = new System.Drawing.Point(1200, 235);
            this.button_chord.Name = "button_chord";
            this.button_chord.Size = new System.Drawing.Size(178, 49);
            this.button_chord.TabIndex = 12;
            this.button_chord.Text = "Get Arpeggio";
            this.button_chord.UseVisualStyleBackColor = false;
            this.button_chord.Click += new System.EventHandler(this.button_chord_Click);
            // 
            // button_relative_minor
            // 
            this.button_relative_minor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_relative_minor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.button_relative_minor.ForeColor = System.Drawing.Color.Snow;
            this.button_relative_minor.Location = new System.Drawing.Point(660, 75);
            this.button_relative_minor.Name = "button_relative_minor";
            this.button_relative_minor.Size = new System.Drawing.Size(262, 45);
            this.button_relative_minor.TabIndex = 15;
            this.button_relative_minor.Text = "Relative Minor";
            this.button_relative_minor.UseVisualStyleBackColor = false;
            this.button_relative_minor.Click += new System.EventHandler(this.button_relative_minor_Click);
            // 
            // textBox_relativeMinor
            // 
            this.textBox_relativeMinor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.textBox_relativeMinor.Location = new System.Drawing.Point(948, 79);
            this.textBox_relativeMinor.Name = "textBox_relativeMinor";
            this.textBox_relativeMinor.ReadOnly = true;
            this.textBox_relativeMinor.Size = new System.Drawing.Size(83, 37);
            this.textBox_relativeMinor.TabIndex = 16;
            this.textBox_relativeMinor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // listBox_notes_in_mode
            // 
            this.listBox_notes_in_mode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.listBox_notes_in_mode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_notes_in_mode.FormattingEnabled = true;
            this.listBox_notes_in_mode.ItemHeight = 25;
            this.listBox_notes_in_mode.Location = new System.Drawing.Point(885, 475);
            this.listBox_notes_in_mode.Name = "listBox_notes_in_mode";
            this.listBox_notes_in_mode.Size = new System.Drawing.Size(178, 254);
            this.listBox_notes_in_mode.TabIndex = 18;
            // 
            // label_note_in_mode
            // 
            this.label_note_in_mode.AutoSize = true;
            this.label_note_in_mode.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_note_in_mode.ForeColor = System.Drawing.Color.Blue;
            this.label_note_in_mode.Location = new System.Drawing.Point(881, 419);
            this.label_note_in_mode.Name = "label_note_in_mode";
            this.label_note_in_mode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label_note_in_mode.Size = new System.Drawing.Size(178, 30);
            this.label_note_in_mode.TabIndex = 17;
            this.label_note_in_mode.Text = "Notes in Mode";
            // 
            // comboBox_list_of_jam_songs
            // 
            this.comboBox_list_of_jam_songs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.comboBox_list_of_jam_songs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_list_of_jam_songs.FormattingEnabled = true;
            this.comboBox_list_of_jam_songs.Items.AddRange(new object[] {
            "2-5-1 in C",
            "Practice for CMaj7",
            "Regea 1-4 in C",
            "Disco (1-2 in Eb, 110 BPM)",
            "Funk on E9",
            "Hip (Bassline A, Bb, F, E, 95 BPM)",
            "Dance (1-6-2-5 in F, 128 BPM)",
            "Blues in C (90 BPM)",
            "Blues in C (120 BPM)",
            "Blues in C (160 BPM)",
            "Blues in G (90 BPM)",
            "Blues in G (120 BPM)",
            "Blues in G (160 BPM)"});
            this.comboBox_list_of_jam_songs.Location = new System.Drawing.Point(54, 195);
            this.comboBox_list_of_jam_songs.Name = "comboBox_list_of_jam_songs";
            this.comboBox_list_of_jam_songs.Size = new System.Drawing.Size(333, 44);
            this.comboBox_list_of_jam_songs.TabIndex = 19;
            this.comboBox_list_of_jam_songs.Text = "Practice for CMaj7";
            this.comboBox_list_of_jam_songs.SelectedIndexChanged += new System.EventHandler(this.comboBox_list_of_jam_songs_SelectedIndexChanged);
            // 
            // button_start_jamming
            // 
            this.button_start_jamming.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_start_jamming.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_start_jamming.ForeColor = System.Drawing.Color.Snow;
            this.button_start_jamming.Location = new System.Drawing.Point(54, 258);
            this.button_start_jamming.Name = "button_start_jamming";
            this.button_start_jamming.Size = new System.Drawing.Size(173, 114);
            this.button_start_jamming.TabIndex = 20;
            this.button_start_jamming.Text = "Start Jamming";
            this.button_start_jamming.UseVisualStyleBackColor = false;
            this.button_start_jamming.Click += new System.EventHandler(this.button_start_jamming_Click);
            // 
            // button_Stop_jamming
            // 
            this.button_Stop_jamming.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_Stop_jamming.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Stop_jamming.ForeColor = System.Drawing.Color.Snow;
            this.button_Stop_jamming.Location = new System.Drawing.Point(233, 258);
            this.button_Stop_jamming.Name = "button_Stop_jamming";
            this.button_Stop_jamming.Size = new System.Drawing.Size(154, 114);
            this.button_Stop_jamming.TabIndex = 21;
            this.button_Stop_jamming.Text = "Stop Jamming";
            this.button_Stop_jamming.UseVisualStyleBackColor = false;
            this.button_Stop_jamming.Click += new System.EventHandler(this.button_Stop_jamming_Click);
            // 
            // label_jam
            // 
            this.label_jam.AutoSize = true;
            this.label_jam.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_jam.ForeColor = System.Drawing.Color.Red;
            this.label_jam.Location = new System.Drawing.Point(45, 52);
            this.label_jam.Name = "label_jam";
            this.label_jam.Size = new System.Drawing.Size(397, 50);
            this.label_jam.TabIndex = 22;
            this.label_jam.Text = "JAM APPLICATION";
            // 
            // label_select_jam_songs
            // 
            this.label_select_jam_songs.AutoSize = true;
            this.label_select_jam_songs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_select_jam_songs.ForeColor = System.Drawing.Color.OliveDrab;
            this.label_select_jam_songs.Location = new System.Drawing.Point(46, 144);
            this.label_select_jam_songs.Name = "label_select_jam_songs";
            this.label_select_jam_songs.Size = new System.Drawing.Size(315, 36);
            this.label_select_jam_songs.TabIndex = 23;
            this.label_select_jam_songs.Text = "SELECT JAM SONGS";
            // 
            // button_recommend_scales
            // 
            this.button_recommend_scales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_recommend_scales.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_recommend_scales.ForeColor = System.Drawing.Color.Snow;
            this.button_recommend_scales.Location = new System.Drawing.Point(54, 407);
            this.button_recommend_scales.Name = "button_recommend_scales";
            this.button_recommend_scales.Size = new System.Drawing.Size(333, 107);
            this.button_recommend_scales.TabIndex = 24;
            this.button_recommend_scales.Text = "Instructions";
            this.button_recommend_scales.UseVisualStyleBackColor = false;
            this.button_recommend_scales.Click += new System.EventHandler(this.button_recommend_scales_Click);
            // 
            // button_scaleDiagram
            // 
            this.button_scaleDiagram.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_scaleDiagram.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_scaleDiagram.ForeColor = System.Drawing.Color.Snow;
            this.button_scaleDiagram.Location = new System.Drawing.Point(547, 292);
            this.button_scaleDiagram.Name = "button_scaleDiagram";
            this.button_scaleDiagram.Size = new System.Drawing.Size(222, 49);
            this.button_scaleDiagram.TabIndex = 25;
            this.button_scaleDiagram.Text = "See Diagram";
            this.button_scaleDiagram.UseVisualStyleBackColor = false;
            this.button_scaleDiagram.Click += new System.EventHandler(this.button_scaleDiagram_Click);
            // 
            // button_modeDiagram
            // 
            this.button_modeDiagram.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_modeDiagram.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_modeDiagram.ForeColor = System.Drawing.Color.Snow;
            this.button_modeDiagram.Location = new System.Drawing.Point(885, 292);
            this.button_modeDiagram.Name = "button_modeDiagram";
            this.button_modeDiagram.Size = new System.Drawing.Size(222, 49);
            this.button_modeDiagram.TabIndex = 26;
            this.button_modeDiagram.Text = "See Diagram";
            this.button_modeDiagram.UseVisualStyleBackColor = false;
            this.button_modeDiagram.Click += new System.EventHandler(this.button_modeDiagram_Click);
            // 
            // Jam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(1515, 812);
            this.Controls.Add(this.button_modeDiagram);
            this.Controls.Add(this.button_scaleDiagram);
            this.Controls.Add(this.button_recommend_scales);
            this.Controls.Add(this.label_select_jam_songs);
            this.Controls.Add(this.label_jam);
            this.Controls.Add(this.button_Stop_jamming);
            this.Controls.Add(this.button_start_jamming);
            this.Controls.Add(this.comboBox_list_of_jam_songs);
            this.Controls.Add(this.listBox_notes_in_mode);
            this.Controls.Add(this.label_note_in_mode);
            this.Controls.Add(this.textBox_relativeMinor);
            this.Controls.Add(this.button_relative_minor);
            this.Controls.Add(this.comboBox_chords);
            this.Controls.Add(this.label_chords);
            this.Controls.Add(this.button_chord);
            this.Controls.Add(this.listBox_notes_in_chord);
            this.Controls.Add(this.label_notes_in_chords);
            this.Controls.Add(this.combox_mode);
            this.Controls.Add(this.label_mode);
            this.Controls.Add(this.button_modes);
            this.Controls.Add(this.button_scale);
            this.Controls.Add(this.listBox_notes_in_scales);
            this.Controls.Add(this.label_list_of_notes);
            this.Controls.Add(this.comboBox_scales);
            this.Controls.Add(this.comboBox_keys);
            this.Controls.Add(this.label_scale);
            this.Controls.Add(this.label_key);
            this.ForeColor = System.Drawing.Color.Maroon;
            this.Name = "Jam";
            this.Text = "Jam Application";
            this.Load += new System.EventHandler(this.Document_view_for_music_theory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_key;
        private System.Windows.Forms.Label label_scale;
        private System.Windows.Forms.ComboBox comboBox_keys;
        private System.Windows.Forms.ComboBox comboBox_scales;
        private System.Windows.Forms.Label label_list_of_notes;
        private System.Windows.Forms.ListBox listBox_notes_in_scales;
        private System.Windows.Forms.Button button_scale;
        private System.Windows.Forms.Button button_modes;
        private System.Windows.Forms.ComboBox combox_mode;
        private System.Windows.Forms.Label label_mode;
        private System.Windows.Forms.ListBox listBox_notes_in_chord;
        private System.Windows.Forms.Label label_notes_in_chords;
        private System.Windows.Forms.ComboBox comboBox_chords;
        private System.Windows.Forms.Label label_chords;
        private System.Windows.Forms.Button button_chord;
        private System.Windows.Forms.Button button_relative_minor;
        private System.Windows.Forms.TextBox textBox_relativeMinor;
        private System.Windows.Forms.ListBox listBox_notes_in_mode;
        private System.Windows.Forms.Label label_note_in_mode;
        private System.Windows.Forms.ComboBox comboBox_list_of_jam_songs;
        private System.Windows.Forms.Button button_start_jamming;
        private System.Windows.Forms.Button button_Stop_jamming;
        private System.Windows.Forms.Label label_jam;
        private System.Windows.Forms.Label label_select_jam_songs;
        private System.Windows.Forms.Button button_recommend_scales;
        private System.Windows.Forms.Button button_scaleDiagram;
        private System.Windows.Forms.Button button_modeDiagram;
    }
}

