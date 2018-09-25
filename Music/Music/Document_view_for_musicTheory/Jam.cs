using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MusicTheory;
using System.Media; //this is to play music for wave
using WMPLib;
namespace Document_view_for_musicTheory
{
    public partial class Jam : Form,IMusicTheory
    {
        WindowsMediaPlayer play = new WindowsMediaPlayer();
        public Jam()
        {
            InitializeComponent();
        }

        public event Action<string, string> GetScale;
        public event Action<string, string> GetMode;
        public event Action<string, string> GetChord;
        public event Action<string> GetRelativeMinor;

        private void Document_view_for_music_theory_Load(object sender, EventArgs e)
        {

        }

        private void button_scale_Click(object sender, EventArgs e)
        {
            listBox_notes_in_scales.Items.Clear();
            GetScale(comboBox_keys.Text, comboBox_scales.Text);
            

        }
  
        private void button_modes_Click(object sender, EventArgs e)
        {
            listBox_notes_in_mode.Items.Clear();
            GetMode(comboBox_keys.Text,combox_mode.Text);
            
            
            
        }
  
  
        public void ShowScale(List<Note> scale)
        {
            foreach (var item in scale)
            {
                listBox_notes_in_scales.Items.Add(item.name);
            }
        }

        public void ShowMode(List<Note> mode)
        {
            foreach (var item in mode)
            {
                listBox_notes_in_mode.Items.Add(item.name);
            }
        }

        private void comboBox_keys_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox_relativeMinor.Text = null;
            listBox_notes_in_scales.Items.Clear();
            listBox_notes_in_mode.Items.Clear();
            listBox_notes_in_chord.Items.Clear();
        }

        private void combox_mode_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            listBox_notes_in_mode.Items.Clear();
        }

        private void comboBox_scales_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox_notes_in_scales.Items.Clear();
        }

        public void ShowChord(List<Note> chord)
        {
            foreach (var item in chord)
            {
                listBox_notes_in_chord.Items.Add(item.name);
            }
        }

        public void ShowRelativeMinor(string key)
        {
            textBox_relativeMinor.Text = key;
        }

        private void button_relative_minor_Click(object sender, EventArgs e)
        {
            GetRelativeMinor(comboBox_keys.Text);
        }

        private void comboBox_chords_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox_notes_in_chord.Items.Clear();
        }

        private void button_chord_Click(object sender, EventArgs e)
        {
            listBox_notes_in_chord.Items.Clear();
            GetChord(comboBox_keys.Text,comboBox_chords.Text);
        }

        private void button_start_jamming_Click(object sender, EventArgs e)
        {
 
            switch(comboBox_list_of_jam_songs.Text)
            {
                case "Blues in C (90 BPM)":
                    play.URL = "C:\\Users\\tom\\Documents\\Visual Studio 2017\\Projects\\Music\\Document_view_for_musicTheory\\jam songs\\Blues in C (90).mp3";
                    play.controls.play();
                    break;

                case "Blues in C (120 BPM)":
                    play.URL = "C:\\Users\\tom\\Documents\\Visual Studio 2017\\Projects\\Music\\Document_view_for_musicTheory\\jam songs\\Blues in C (120).mp3";
                    play.controls.play();
                    break;
                case "Blues in C (160 BPM)":
                    play.URL = "C:\\Users\\tom\\Documents\\Visual Studio 2017\\Projects\\Music\\Document_view_for_musicTheory\\jam songs\\Blues in C (160).mp3";
                    play.controls.play();
                    break;
                case "Blues in G (90 BPM)":
                    play.URL = "C:\\Users\\tom\\Documents\\Visual Studio 2017\\Projects\\Music\\Document_view_for_musicTheory\\jam songs\\blues in G (bpm 90).mp3";
                    play.controls.play();
                    break;
                case "Blues in G (120 BPM)":
                    play.URL = "C:\\Users\\tom\\Documents\\Visual Studio 2017\\Projects\\Music\\Document_view_for_musicTheory\\jam songs\\blues in G (bpm 120).mp3";
                    play.controls.play();
                    break;
                case "Blues in G (160 BPM)":
                    play.URL = "C:\\Users\\tom\\Documents\\Visual Studio 2017\\Projects\\Music\\Document_view_for_musicTheory\\jam songs\\blues in G (bpm 160).mp3";
                    play.controls.play();
                    break;
                case "2-5-1 in C":
                    play.URL = "C:\\Users\\tom\\Documents\\Visual Studio 2017\\Projects\\Music\\Document_view_for_musicTheory\\jam songs\\2-5-1.mp3";
                    play.controls.play();
                    break;
                case "Regea 1-4 in C":
                    play.URL = "C:\\Users\\tom\\Documents\\Visual Studio 2017\\Projects\\Music\\Document_view_for_musicTheory\\jam songs\\raggae 1-4.mp3";
                    play.controls.play();
                    break;
                case "Practice for CMaj7":
                    play.URL = "C:\\Users\\tom\\Documents\\Visual Studio 2017\\Projects\\Music\\Document_view_for_musicTheory\\jam songs\\CMaj7ForPratice.mp3";
                    play.controls.play();
                    break;
                case "Disco (1-2 in Eb, 110 BPM)":
                    play.URL = "C:\\Users\\tom\\Documents\\Visual Studio 2017\\Projects\\Music\\Document_view_for_musicTheory\\jam songs\\Disco (1-2 in Eb) 110 Bpm.mp3";
                    play.controls.play();
                    break;
                case "Funk on E9":
                    play.URL = "C:\\Users\\tom\\Documents\\Visual Studio 2017\\Projects\\Music\\Document_view_for_musicTheory\\jam songs\\Funky on E9.mp3";
                    play.controls.play();
                    break;
                case "Hip (Bassline A, Bb, F, E, 95 BPM)":
                    play.URL = "C:\\Users\\tom\\Documents\\Visual Studio 2017\\Projects\\Music\\Document_view_for_musicTheory\\jam songs\\Hip (bassLine A,Bb,F,E) 95 Bpm.mp3";
                    play.controls.play();
                    break;
                case "Dance (1-6-2-5 in F, 128 BPM)":
                    play.URL = "C:\\Users\\tom\\Documents\\Visual Studio 2017\\Projects\\Music\\Document_view_for_musicTheory\\jam songs\\Dance (1-6-2-5 in F) 128 Bpm.mp3";
                    play.controls.play();
                    break;

            }
        }

        private void button_Stop_jamming_Click(object sender, EventArgs e)
        {
            play.controls.stop();
        }

        private void comboBox_list_of_jam_songs_SelectedIndexChanged(object sender, EventArgs e)
        {
            play.controls.stop();
        }

        private void button_recommend_scales_Click(object sender, EventArgs e)
        {
            string chordUsed;
            List<string> scaleList = new List<string>();
            switch(comboBox_list_of_jam_songs.Text)
            {
                case "Blues in C (90 BPM)":
                    chordUsed = "This Jam song used 12 bar blues in C (C7, F7 and G7) which is 1-4-5";
                    chordUsed = "This Jam song used 12 bar blues in C (C7, F7 and G7) which is 1-4-5";

                    scaleList.Add("C Blues Scale");
                    scaleList.Add("C Pentatonic Major Scale");
                    scaleList.Add("A Pentatonic Minor Scale");
                    scaleList.Add("A Blues");
                    scaleList.Add("Mix of C Bebops");

                    Songs_Documentary BluesInC = new Songs_Documentary(chordUsed, scaleList);
                    BluesInC.Show();

                    break;
                case "Blues in C (120 BPM)":
                    chordUsed = "This Jam song used 12 bar blues in C (C7, F7 and G7) which is 1-4-5";
                    chordUsed = "This Jam song used 12 bar blues in C (C7, F7 and G7) which is 1-4-5";

                    scaleList.Add("C Blues Scale");
                    scaleList.Add("C Pentatonic Major Scale");
                    scaleList.Add("A Pentatonic Minor Scale");
                    scaleList.Add("A Blues");
                    scaleList.Add("Mix of C Bebops");

                    Songs_Documentary BluesInC120 = new Songs_Documentary(chordUsed, scaleList);
                    BluesInC120.Show();

                    break;
                case "Blues in C (160 BPM)":
                    chordUsed = "This Jam song used 12 bar blues in C (C7, F7 and G7) which is 1-4-5";
                    chordUsed = "This Jam song used 12 bar blues in C (C7, F7 and G7) which is 1-4-5";

                    scaleList.Add("C Blues Scale");
                    scaleList.Add("C Pentatonic Major Scale");
                    scaleList.Add("A Pentatonic Minor Scale");
                    scaleList.Add("A Blues");
                    scaleList.Add("Mix of C Bebops");

                    Songs_Documentary BluesInC160 = new Songs_Documentary(chordUsed, scaleList);
                    BluesInC160.Show();

                    break;
                case "Blues in G (90 BPM)":
                    chordUsed = "This Jam song used 12 bar blues in G (G7, C7, and D7) which is 1-4-5";

                    scaleList.Add("G Blues Scale");
                    scaleList.Add("G Pentatonic Major Scale");
                    scaleList.Add("E Pentatonic Minor Scale");
                    scaleList.Add("E Blues");
                    scaleList.Add("Mix of G Bebops");

                    Songs_Documentary BluesInG90 = new Songs_Documentary(chordUsed, scaleList);
                    BluesInG90.Show();

                    break;
                case "Blues in G (120 BPM)":
                    chordUsed = "This Jam song used 12 bar blues in G (G7, C7, and D7) which is 1-4-5";

                    scaleList.Add("G Blues Scale");
                    scaleList.Add("G Pentatonic Major Scale");
                    scaleList.Add("E Pentatonic Minor Scale");
                    scaleList.Add("E Blues");
                    scaleList.Add("Mix of G Bebops");

                    Songs_Documentary BluesInG120 = new Songs_Documentary(chordUsed, scaleList);
                    BluesInG120.Show();

                    break;
                case "Blues in G (160 BPM)":
                    chordUsed = "This Jam song used 12 bar blues in G (G7, C7, and D7) which is 1-4-5";

                    scaleList.Add("G Blues Scale");
                    scaleList.Add("G Pentatonic Major Scale");
                    scaleList.Add("E Pentatonic Minor Scale");
                    scaleList.Add("E Blues");
                    scaleList.Add("Mix of G Bebops");      

                    Songs_Documentary BluesInG = new Songs_Documentary(chordUsed, scaleList);
                    BluesInG.Show();

                    break;
                case "2-5-1 in C":
                    chordUsed = "This Jam song used Dm7, G7 and CMaj7 which is 2-5-1";

                    scaleList.Add("C Major Scale");
                    scaleList.Add("C Pentatonic Major Scale");
                    scaleList.Add("A Pentatonic Minor Scale");
                    scaleList.Add("A Blues");
                    scaleList.Add("C Major Scale");
                    scaleList.Add("Mix of C Bebops");
                    scaleList.Add("D Dorian, G Mixolydian, and C Ionion");

                    Songs_Documentary swing = new Songs_Documentary(chordUsed, scaleList);
                    swing.Show();

                    break;
                case "Regea 1-4 in C":
                    chordUsed = "This Jam song used CMaj7 and FMaj7 which is 1 and 4";

                    scaleList.Add("C Major Scale");
                    scaleList.Add("C Pentatonic Major Scale");
                    scaleList.Add("A Pentatonic Minor Scale");
                    scaleList.Add("A Blues");
                    scaleList.Add("C Major Scale");
                    scaleList.Add("Mix of C Bebops");
                    scaleList.Add("C Ionion and F Lydian");

                    Songs_Documentary regea14 = new Songs_Documentary(chordUsed, scaleList);
                    regea14.Show();

                    break;
                case "Practice for CMaj7":
                    //MessageBox.Show("Suggestions\nMajor scale or Ionion Mode in Key C\nPentatonic Major in Key C, etc");
                    chordUsed = "This Jam song only used CMaj7 chord";

                    scaleList.Add("C Major Scale");
                    scaleList.Add("C Pentatonic Major Scale");
                    scaleList.Add("A Pentatonic Minor Scale");
                    scaleList.Add("A Blues");
                    scaleList.Add("C Major Scale");
                    scaleList.Add("Mix of C Bebops");

                    Songs_Documentary sd = new Songs_Documentary(chordUsed,scaleList);
                    sd.Show();
                    break;
                
                case "Disco (1-2 in Eb, 110 BPM)":
                    chordUsed = "This Jam song used Eb Major7 and F Minor7 which is 1 and 2";

                    scaleList.Add("Eb Major Scale");
                    scaleList.Add("C Pentatonic Major Scale");
                    scaleList.Add("C Blues");
                    scaleList.Add("Mix of Eb Bebops");
                    scaleList.Add("Eb Ionion and F Dorian");

                    Songs_Documentary disco = new Songs_Documentary(chordUsed, scaleList);
                    disco.Show();

                    break;
                case "Funk on E9":
                    chordUsed = "This Jam song Only used E Dominent 9";

                    scaleList.Add("E Mixolydian in Mode");
                    scaleList.Add("E Blues");
                    scaleList.Add("E Dominent Bebop");
                    scaleList.Add("C# Pentatonic Major Scale");
                    scaleList.Add("C# Blues");
                    scaleList.Add("Mix of E Bebops");

                    Songs_Documentary funk = new Songs_Documentary(chordUsed, scaleList);
                    funk.Show();

                    break;
                case "Hip (Bassline A, Bb, F, E, 95 BPM)":
                    chordUsed = "The Bassline of the jam song contains note A, Bb, F, E";

                    scaleList.Add("A Japanese (Sen)");
                    scaleList.Add("A Japanese (Hirajoshi)");
                    scaleList.Add("A Phrygian Mode");

                    Songs_Documentary hip = new Songs_Documentary(chordUsed, scaleList);
                    hip.Show();

                    break;
                
                case "Dance (1-6-2-5 in F, 128 BPM)":
                    chordUsed = "This Jam song used FMaj7, Dm7, Gm7, C7 which is 1-6-2-5 in F major scale";

                    scaleList.Add("F Major Scale");
                    scaleList.Add("D Pentatonic");
                    scaleList.Add("D Blues");
                    scaleList.Add("Mix of F Bebops");
                    Songs_Documentary dance = new Songs_Documentary(chordUsed, scaleList);
                    dance.Show();

                    break;
            }
        }

        private void button_scaleDiagram_Click(object sender, EventArgs e)
        {
            listBox_notes_in_scales.Items.Clear();
            GetScale(comboBox_keys.Text, comboBox_scales.Text);
            DiagramScale DS = new DiagramScale(comboBox_keys.Text, comboBox_scales.Text);
            DS.Text = comboBox_keys.Text + " " + comboBox_scales.Text;
            DS.Show();
        }

        private void button_modeDiagram_Click(object sender, EventArgs e)
        {
            listBox_notes_in_mode.Items.Clear();
            GetMode(comboBox_keys.Text, combox_mode.Text);
            DiagramMode DM = new DiagramMode(comboBox_keys.Text, combox_mode.Text);
            DM.Text = comboBox_keys.Text + " " + combox_mode.Text;
            DM.Show();
        }
    }
}
