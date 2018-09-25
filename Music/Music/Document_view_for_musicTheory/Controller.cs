using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicTheory;

namespace Document_view_for_musicTheory
{
    public class Controller
    {
        private IMusicTheory window;
        private Bebop bebop;
        private Chord chords;
        private MajorScale major;
        private MinorScale minor;
        private Mode mode;
        private Pentatonic pentatonic;
        private Spanish spanish;
   

        public Controller(IMusicTheory window)
        {
            this.window = window;

            this.bebop = new Bebop();
            this.chords = new Chord();
            this.major = new MajorScale();
            this.minor = new MinorScale();
            this.mode = new Mode();
            this.pentatonic = new Pentatonic();
            this.spanish = new Spanish();

            window.GetScale += Handler_scale;
            window.GetMode += Handler_mode;
            window.GetRelativeMinor += Handler_relativeMinor;
            window.GetChord += Handler_GetChord;
        }

        private void Handler_GetChord(string key, string chord)
        {
            List<Note> list = new List<Note>();
            switch(chord)
            {
                case "Major":
                    for (int i = 0; i < 3; i++)
                    {
                        list.Add(chords.Major(key)[i]);
                    }
                    window.ShowChord(list);
                    break;
                case "Major7":
                    for (int i = 0; i < 4; i++)
                    {
                        list.Add(chords.Major(key)[i]);
                    }
                    window.ShowChord(list);
                    break;
                case "Major9":
                    for (int i = 0; i < 5; i++)
                    {
                        list.Add(chords.Major(key)[i]);
                    }
                    window.ShowChord(list);
                    break;
                case "Minor":
                    for (int i = 0; i < 3; i++)
                    {
                        list.Add(chords.Minor(key)[i]);
                    }
                    window.ShowChord(list);
                    break;
                case "Minor7":
                    for (int i = 0; i < 4; i++)
                    {
                        list.Add(chords.Minor(key)[i]);
                    }
                    window.ShowChord(list);
                    break;
                case "Minor7b5":
                    for (int i = 0; i < 4; i++)
                    {
                        list.Add(chords.Minor_flat_five(key)[i]);
                    }
                    window.ShowChord(list);
                    break;
                case "Minor9":
                    for (int i = 0; i < 5; i++)
                    {
                        list.Add(chords.Minor(key)[i]);
                    }
                    window.ShowChord(list);
                    break;
                case "Dominant":
                    for (int i = 0; i < 4; i++)
                    {
                        list.Add(chords.Dominant(key)[i]);
                    }
                    window.ShowChord(list);
                    break;
                case "Dominant9":
                    for (int i = 0; i < 5; i++)
                    {
                        list.Add(chords.Dominant(key)[i]);
                    }
                    window.ShowChord(list);
                    break;
                case "Dominant11":
                    for (int i = 0; i < 6; i++)
                    {
                        list.Add(chords.Dominant(key)[i]);
                    }
                    window.ShowChord(list);
                    break;
                case "Dominant13":
                    for (int i = 0; i < 7; i++)
                    {
                        list.Add(chords.Dominant(key)[i]);
                    }
                    window.ShowChord(list);
                    break;
            }
        }

        private void Handler_relativeMinor(string obj)
        {
            major.GetNotesInMajorScale(obj);
            window.ShowRelativeMinor(major.RelativeMinor.name);
        }

        private void Handler_mode(string key, string scale)
        {
            List<Note> t = new List<Note>();
            switch (scale)
            {
                case "Ionian (I)":
                    for (int i = 0; i < 8; i++)
                    {
                        t.Add(mode.Ionion(key)[i]);
                    }
                    window.ShowMode(t);
                    break;
                case "Dorian (II)":
                    window.ShowMode(mode.Dorian(key));
                    break;
                case "Phrygian (III)":
                    window.ShowMode(mode.Phrygian(key));
                    break;
                case "Lydian (IV)":
                    window.ShowMode(mode.Lydian(key));
                    break;
                case "Mixolydian (V)":
                    window.ShowMode(mode.Mixolydian(key));
                    break;
                case "Aeolian (VI)":
                    window.ShowMode(mode.Aeolian(key));
                    break;
                case "Locrian (VII)":
                    window.ShowMode(mode.Locrian(key));
                    break;
            }
        }
        private void Handler_scale(string key, string scale)
        {
            List<Note> t = new List<Note>();
            switch (scale)
            {
                case "Major Scale":
                    for (int i = 0; i < 8; i++)
                    {
                        t.Add(mode.Ionion(key)[i]);
                    }
                    window.ShowScale(t);
                    break;
                case "Minor (Natural) Scale":
                    window.ShowScale(minor.Natural(key));
                    break;
                case "Harmonic Minor Scale":
                    window.ShowScale(minor.Harmonic(key));
                    break;
                case "Melodic Minor Scale":
                    window.ShowScale(minor.Melodic(key));
                    break;
                case "Pentatonic Major":
                    window.ShowScale(pentatonic.Major(key));
                    break;
                case "Pentatonic Minor":
                    window.ShowScale(pentatonic.Minor(key));
                    break;
                case "Japanese (Sen)":
                    window.ShowScale(pentatonic.Sen(key));
                    break;
                case "Japanese (Hirajoshi)":
                    window.ShowScale(pentatonic.Hirajoshi(key));
                    break;
                case "Bebop (Mixolydian)":
                    window.ShowScale(bebop.Mixolydian(key));
                    break;
                case "Bebop (Dorian)":
                    window.ShowScale(bebop.Dorian(key));
                    break;
                case "Bebop (Major)":
                    window.ShowScale(bebop.Major(key));
                    break;
                case "Blues":
                    window.ShowScale(pentatonic.Blues(key));
                    break;
                case "Spanish Scale":
                    window.ShowScale(spanish.SpanishScale(key));
                    break;


            }
        }
    }
}
