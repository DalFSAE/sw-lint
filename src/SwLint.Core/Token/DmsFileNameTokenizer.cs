using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwLint.Core.Token
{
    public class DmsFileNameTokenizer
    {
        public static DmsFileNameToken Parse(string fileName)
        {

            string[] tokens = fileName.Split('-');

            // #todo write tokenizer

            return new DmsFileNameToken
            {

            };
        }
    }
}
