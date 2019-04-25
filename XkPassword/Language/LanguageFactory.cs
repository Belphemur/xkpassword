using System.Collections.Generic;
using XkPassword.Language.Lang;

namespace XkPassword.Language
{
    /// <summary>
    /// Factory of Language
    /// </summary>
    public class LanguageFactory
    {
        private readonly Dictionary<Lang, ILanguage> _values = new Dictionary<Lang, ILanguage>()
        {
            {Lang.English, new English() },
            {Lang.French, new French() }
        };
        /// <summary>
        /// Different Language dictionaries available
        /// </summary>
        public enum Lang
        {
            /// <summary>
            /// English Dictionary
            /// </summary>
            English = 0,
            /// <summary>
            /// French Dictionary
            /// </summary>
            French
        }

        public ILanguage GetValue(Lang @enum)
        {
            this._values.TryGetValue(@enum, out var value);
            return value;
        }
    }
}