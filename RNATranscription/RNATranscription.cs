using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Text;

namespace RNATranscriptionModule
{
    public static class RnaTranscription
    {
        public static string ToRna(string nucleotide)
        {
            Dictionary<char, char> rna = new Dictionary<char, char>();
            StringBuilder sb = new StringBuilder();
            rna.Add('C', 'G');
            rna.Add('G','C');
            rna.Add('T', 'A');
            rna.Add('A', 'U');
            foreach(char c in nucleotide)
            {
                sb.Append(rna[c]);
            }
            return sb.ToString();
            throw new NotImplementedException("You need to implement this function.");

        }
    }
}
