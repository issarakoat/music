using MusicTheory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicTheory
{
    public class Chord
    {
        public Note Root { get; set; }
        public Note Third { get; set; }
        public Note Fifth { get; set; }
        public Note Seventh { get; set; }

        public List<Note> Major(string note)
        {
            MajorScale Mj = new MajorScale();
            List<Note> t = Mj.GetNotesInMajorScale(note);
            List<Note> list = new List<Note>();
            list.Add(t[0]);
            list.Add(t[2]);
            list.Add(t[4]);
            list.Add(t[6]);
            list.Add(t[1]);
            list.Add(t[3]);
            list.Add(t[5]);
            return list;

        }
        public List<Note> Minor(string note)
        {
            Mode mode = new Mode();
            List<Note> t = mode.Aeolian(note);
            List<Note> list = new List<Note>();
            list.Add(t[0]);
            list.Add(t[2]);
            list.Add(t[4]);
            list.Add(t[6]);
            list.Add(t[1]);
            list.Add(t[3]);
            list.Add(t[5]);
            return list;
        }
        public List<Note> Minor_flat_five(string note)
        {
            Mode mode = new Mode();
            List<Note> t = mode.Aeolian(note);
            List<Note> tt = mode.Aeolian(t[2].name);
            List<Note> list = new List<Note>();
            list.Add(t[0]);
            list.Add(t[2]);
            list.Add(tt[2]);
            list.Add(t[6]);
            list.Add(t[1]);
            list.Add(t[3]);
            list.Add(t[5]);
            return list;
        }
        public List<Note> Dominant(string note)
        {
            Mode mode = new Mode();
            List<Note> t = mode.Mixolydian(note);
            List<Note> list = new List<Note>();
            list.Add(t[0]);
            list.Add(t[2]);
            list.Add(t[4]);
            list.Add(t[6]);
            list.Add(t[1]);
            list.Add(t[3]);
            list.Add(t[5]);
            return list;
        }

    }
}
