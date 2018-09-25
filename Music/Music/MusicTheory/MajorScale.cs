using System;
using System.Collections.Generic;

namespace MusicTheory
{
    public class MajorScale
    {
        
        #region all the simple ones
        Note C, C_sharp, D_flat, D, D_sharp, E_flat, E, E_sharp,
            F_flat, F, F_sharp, G_flat, G, G_sharp, A_flat, A, A_sharp,
            B_flat, B, B_sharp, C_flat, C_double_sharp, F_double_sharp,G_double_sharp,D_double_sharp,
            A_double_sharp,B_double_flat,E_double_flat,A_double_flat,D_double_flat,G_double_flat,
            C_double_flat,F_double_flat;

        #endregion
        public string root { get; set; } //the first notes of the scale
        public Note RelativeMinor { get; set; }
        //note name
        //tonic, supertonic, mediant, subdominant, dominant, submediant, leading note
        public Note tonic { get; set; }
        public Note supertonic { get; set; }
        public Note mediant { get; set; }
        public Note subdominant { get; set; }
        public Note dominant { get; set; }
        public Note submediant { get; set; }
        public Note leading_note { get; set; }
        private List<Note> notes_list;
        public MajorScale()
        {
            C = new Note("C");
            C_sharp = new Note("C#");
            D_flat = new Note("Db");
            D = new Note("D");
            D_sharp = new Note("D#");
            E_flat = new Note("Eb");
            E = new Note("E");
            E_sharp = new Note("E#");
            F_flat = new Note("Fb");
            F = new Note("F");
            F_sharp = new Note("F#");
            G_flat = new Note("Gb");
            G = new Note("G");
            G_sharp = new Note("G#");
            A_flat = new Note("Ab");
            A = new Note("A");
            A_sharp = new Note("A#");
            B_flat = new Note("Bb");
            B = new Note("B");
            B_sharp = new Note("B#");
            C_flat = new Note("Cb");
            F_double_sharp = new Note("F##");
            C_double_sharp = new Note("C##");            
            G_double_sharp = new Note("G##");
            D_double_sharp = new Note("D##");
            A_double_sharp = new Note("A##");
            B_double_flat = new Note("Bbb");
            E_double_flat = new Note("Ebb");
            A_double_flat = new Note("Abb");
            D_double_flat = new Note("Dbb");
            G_double_flat = new Note("Gbb");
            C_double_flat = new Note("Cbb");
            F_double_flat = new Note("Fbb");



        }
        private void GetNoteName(List<Note> list)
        {
            tonic = list[0];
            supertonic = list[1];
            mediant = list[2];
            subdominant = list[3];
            dominant = list[4];
            subdominant = list[5];
            leading_note = list[6];
        }
        /// <summary>
        /// return a list of notes in MajorScale
        /// </summary>
        /// <returns></returns>
        public List<Note> GetNotesInMajorScale(string root)
        {
            this.root = root;

            if (root == "C")
            {
                notes_list = new List<Note> { C, D, E, F, G, A, B, C, D, E, F, G, A, B };
                RelativeMinor = notes_list[5];
                GetNoteName(notes_list);
                return notes_list;
            }
            else if (root == "G")
            {
                notes_list = new List<Note> { G, A, B, C, D, E, F_sharp, G, A, B, C, D, E, F_sharp };
                RelativeMinor = notes_list[5];
                GetNoteName(notes_list);
                return notes_list;
            }
            else if (root == "A")
            {
                notes_list = new List<Note> { A, B, C_sharp, D, E, F_sharp, G_sharp, A, B, C_sharp, D, E, F_sharp, G_sharp };
                RelativeMinor = notes_list[5];
                GetNoteName(notes_list);
                return notes_list;
            }
            else if (root == "E")
            {
                notes_list = new List<Note> { E, F_sharp, G_sharp, A, B, C_sharp, D_sharp, E, F_sharp, G_sharp, A, B, C_sharp, D_sharp };
                RelativeMinor = notes_list[5];
                GetNoteName(notes_list);
                return notes_list;
            }
            else if (root == "C#")
            {
                notes_list = new List<Note> { C_sharp, D_sharp, E_sharp, F_sharp, G_sharp, A_sharp, B_sharp, C_sharp, D_sharp, E_sharp, F_sharp, G_sharp, A_sharp, B_sharp };
                GetNoteName(notes_list);
                RelativeMinor = notes_list[5];
                return notes_list;
            }
            else if (root == "F#")
            {
                notes_list = new List<Note> { F_sharp, G_sharp, A_sharp, B, C_sharp, D_sharp, E_sharp, F_sharp, G_sharp, A_sharp, B, C_sharp, D_sharp, E_sharp };
                GetNoteName(notes_list);
                RelativeMinor = notes_list[5];
                return notes_list;
            }
            else if (root == "B")
            {
                notes_list = new List<Note> { B, C_sharp, D_sharp, E, F_sharp, G_sharp, A_sharp, B, C_sharp, D_sharp, E, F_sharp, G_sharp, A_sharp };
                GetNoteName(notes_list);
                RelativeMinor = notes_list[5];
                return notes_list;
            }
            else if (root == "G#")
            {
                notes_list = new List<Note> { G_sharp, A_sharp, B_sharp, C_sharp, D_sharp, E_sharp, F_double_sharp, G_sharp, A_sharp, B_sharp, C_sharp, D_sharp, E_sharp, F_double_sharp };
                GetNoteName(notes_list);
                RelativeMinor = notes_list[5];
                return notes_list;
            }
            else if (root == "A#")
            {
                notes_list = new List<Note> { A_sharp, B_sharp, C_double_sharp, D_sharp, E_sharp, F_double_sharp, G_double_sharp, A_sharp, B_sharp, C_double_sharp, D_sharp, E_sharp, F_double_sharp, G_double_sharp };
                GetNoteName(notes_list);
                RelativeMinor = notes_list[5];
                return notes_list;
            }
            else if (root == "E#")
            {
                notes_list = new List<Note> { E_sharp, F_double_sharp, G_double_sharp, A_sharp,B_sharp,C_double_sharp,D_double_sharp, E_sharp, F_double_sharp, G_double_sharp, A_sharp, D_double_sharp };
                GetNoteName(notes_list);
                RelativeMinor = notes_list[5];
                return notes_list;
            }
            else if (root == "B#")
            {
                notes_list = new List<Note> { B_sharp, C_double_sharp, D_double_sharp, E_sharp, F_double_sharp, G_double_sharp, A_double_sharp, B_sharp, C_double_sharp, D_double_sharp, E_sharp, F_double_sharp, G_double_sharp, A_double_sharp };
                GetNoteName(notes_list);
                RelativeMinor = notes_list[5];
                return notes_list;
            }
            else if (root == "Db")
            {
                notes_list = new List<Note> { D_flat, E_flat, F, G_flat, A_flat, B_flat, C, D_flat, E_flat, F, G_flat, A_flat, B_flat, C };
                GetNoteName(notes_list);
                RelativeMinor = notes_list[5];
                return notes_list;
            }
            else if (root == "D")
            {
                notes_list = new List<Note> { D, E, F_sharp, G, A, B, C_sharp, D, E, F_sharp, G, A, B, C_sharp };
                GetNoteName(notes_list);
                RelativeMinor = notes_list[5];
                return notes_list;
            }
            else if (root == "D#")
            {
                notes_list = new List<Note> { D_sharp, E_sharp, F_double_sharp, G_sharp, A_sharp, B_sharp, C_double_sharp, D_sharp, E_sharp, F_double_sharp, G_sharp, A_sharp, B_sharp, C_double_sharp };
                GetNoteName(notes_list);
                RelativeMinor = notes_list[5];
                return notes_list;
            }
            else if (root == "F")
            {
                notes_list = new List<Note> { F, G, A, B_flat, C, D, E, F, G, A, B_flat, C, D, E };
                GetNoteName(notes_list);
                RelativeMinor = notes_list[5];
                return notes_list;
            }
            else if (root == "Bb")
            {
                notes_list = new List<Note> { B_flat, C, D, E_flat, F, G, A, B_flat, C, D, E_flat, F, G, A };
                GetNoteName(notes_list);
                RelativeMinor = notes_list[5];
                return notes_list;
            }
            else if (root == "Eb")
            {
                notes_list = new List<Note> { E_flat, F, G, A_flat, B_flat, C, D, E_flat, F, G, A_flat, B_flat, C, D };
                GetNoteName(notes_list);
                RelativeMinor = notes_list[5];
                return notes_list;
            }
            else if (root == "Ab")
            {
                notes_list = new List<Note> { A_flat, B_flat, C, D_flat, E_flat, F, G, A_flat, B_flat, C, D_flat, E_flat, F, G };
                GetNoteName(notes_list);
                RelativeMinor = notes_list[5];
                return notes_list;
            }
            else if (root == "Fb")
            {
                notes_list = new List<Note> { F_flat, G_flat, A_flat, B_double_flat, C_flat, D_flat, E_flat, F_flat, G_flat, A_flat, B_double_flat, C_flat, D_flat, E_flat };
                GetNoteName(notes_list);
                RelativeMinor = notes_list[5];
                return notes_list;
            }
            else if (root == "Bbb")
            {
                notes_list = new List<Note> { B_double_flat, C_flat, D_flat, E_double_flat, F_flat, G_flat, A_flat, B_double_flat, C_flat, D_flat, E_double_flat, F_flat, G_flat, A_flat };
                GetNoteName(notes_list);
                RelativeMinor = notes_list[5];
                return notes_list;
            }
            else if (root == "Ebb")
            {
                notes_list = new List<Note> { E_double_flat, F_flat, G_flat, A_double_flat, B_double_flat, C_flat, D_flat, E_double_flat, F_flat, G_flat, A_double_flat, B_double_flat, C_flat, D_flat };
                GetNoteName(notes_list);
                RelativeMinor = notes_list[5];
                return notes_list;
            }
            else if (root == "Abb")
            {
                notes_list = new List<Note> { A_double_flat, B_double_flat, C_flat, D_flat, E_double_flat, F_flat, G_flat, A_double_flat, B_double_flat, C_flat, D_flat, E_double_flat, F_flat, G_flat };
                GetNoteName(notes_list);
                RelativeMinor = notes_list[5];
                return notes_list;
            }
            else if (root == "Dbb")
            {
                notes_list = new List<Note> { D_double_flat,E_double_flat,F_flat,G_double_flat,A_double_flat,B_double_flat,C_flat, D_double_flat, E_double_flat, F_flat, G_double_flat, A_double_flat, B_double_flat, C_flat };
                GetNoteName(notes_list);
                RelativeMinor = notes_list[5];
                return notes_list;
            }
            else if (root == "Gbb")
            {
                notes_list = new List<Note> {G_double_flat, A_double_flat, B_double_flat, C_double_flat,D_double_flat,E_double_flat,F_flat, G_double_flat, A_double_flat, B_double_flat, C_double_flat, D_double_flat, E_double_flat, F_flat };
                GetNoteName(notes_list);
                RelativeMinor = notes_list[5];
                return notes_list;
            }
            else if (root == "Cbb")
            {
                notes_list = new List<Note> {C_double_flat, D_double_flat, E_double_flat, F_flat,G_double_flat,A_double_flat,B_double_flat, C_double_flat, D_double_flat, E_double_flat, F_flat, G_double_flat, A_double_flat, B_double_flat };
                GetNoteName(notes_list);
                RelativeMinor = notes_list[5];
                return notes_list;
            }
            else if (root == "Gb")
            {
                notes_list = new List<Note> { G_flat, A_flat, B_flat, C_flat, D_flat, E_flat, F, G_flat, A_flat, B_flat, C_flat, D_flat, E_flat, F };
                GetNoteName(notes_list);
                RelativeMinor = notes_list[5];
                return notes_list;
            }
            else if (root == "Cb")
            {
                notes_list = new List<Note> { C_flat, D_flat, E_flat, F_flat, G_flat, A_flat, B_flat, C_flat, D_flat, E_flat, F_flat, G_flat, A_flat, B_flat };
                GetNoteName(notes_list);
                RelativeMinor = notes_list[5];
                return notes_list;
            }
            throw new Exception("not included in this scales model list");
        }

    }

}
