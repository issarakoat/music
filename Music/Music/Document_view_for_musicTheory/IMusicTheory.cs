using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicTheory;

namespace Document_view_for_musicTheory
{
    public interface IMusicTheory
    {
        event Action<string, string> GetScale;
        event Action<string, string> GetMode;
        event Action<string, string> GetChord;
        event Action<string> GetRelativeMinor;
        void ShowScale(List<Note> scale);
        void ShowMode(List<Note> mode);
        void ShowChord(List<Note> chord);
        void ShowRelativeMinor(string key);
      
    }
}
