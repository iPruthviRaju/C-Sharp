///----------------------------------------------------------------------
/// <File>StringUtil</File>
/// <Author>Pruthvi</Author>
/// <Date>August 8th, 2018</Date>
/// <Summary></Summary>
///-----------------------------------------------------------------------

namespace StringUtil
{
    using System;
    using System.Text.RegularExpressions;

    class StringUtil
    {
        private StringUtil() { }

        private static readonly Lazy<StringUtil> _instance = new Lazy<StringUtil>(() => new StringUtil());

        public static StringUtil Instance
        {
            get { return _instance.Value; }
        }

        public string RemoveAllSpecialCharacters(string input)
        {            
            return Regex.Replace(input, "[^a-zA-Z0-9]", string.Empty);
        }

        public string GetOnlyAlphanumeric(string input)
        {
            return Regex.Replace(input, "[^a-zA-Z0-9]", string.Empty);
        }
    }
}