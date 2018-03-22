using Kbg.NppPluginNET.PluginInfrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarkdownTableGenerator
{
    internal class Scintilla
    {
        private readonly IScintillaGateway scintilla;
        public Scintilla(IScintillaGateway scintilla)
        {
            this.scintilla = scintilla;
        }
        public void Insert(string output)
        {
            var pos = scintilla.GetCurrentPos();
            scintilla.InsertText(pos, output);
        }
        public string Fill()
        {
            var selection = scintilla.GetSelText();
            return selection;
        }
    }
}
