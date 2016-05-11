using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Data.Linq;

namespace Testcontrol
{
    
    public class TestScript
    {
        private IList<Instruction> mInstructions = new List<Instruction>();

        public IList<Instruction> Instructions
        {
            get
            {
                return mInstructions;
            }
        }

        public void LoadScript(string fileName)
        {
            var lines = System.IO.File.ReadAllLines(fileName);
            foreach (var line in lines)
            {
                mInstructions.Add(new Instruction(line));
            }

        }
    }

    public class Instruction
    {
        private String msript;
        private String mSearchableStepName;
        private IList<String> parameters;

        public Instruction(String script)
        {
            msript = script;
            mSearchableStepName = script;
        }

        private void parse()
        {
            if (parameters !=null)
                return;

            parameters = new List<String>();
            MatchCollection matches = Regex.Matches(msript, "\\\"(.*?)\\\"");

            for (int i = 0; i < matches.Count;i++)
            {
                var match = matches[i];
                parameters.Add(match.Value.Replace("\"", ""));
                mSearchableStepName = mSearchableStepName.Replace(match.Value, "{"+i+"}");
            }
        }

        public IList<String> Parameters
        {
            get
            {
                parse();
                return parameters;
            }
        }

        public String getSetpName()
        {
            parse();
            return mSearchableStepName;
        }
    }

}
