//HintName: G.Models.Language.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Languages that the Vectara platform supports.<br/>
    /// Default Value: auto
    /// </summary>
    public enum Language
    {
        /// <summary>
        /// 
        /// </summary>
        Ara,
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        Ben,
        /// <summary>
        /// 
        /// </summary>
        Ces,
        /// <summary>
        /// 
        /// </summary>
        Deu,
        /// <summary>
        /// 
        /// </summary>
        Ell,
        /// <summary>
        /// 
        /// </summary>
        Eng,
        /// <summary>
        /// 
        /// </summary>
        Fas,
        /// <summary>
        /// 
        /// </summary>
        Fra,
        /// <summary>
        /// 
        /// </summary>
        Heb,
        /// <summary>
        /// 
        /// </summary>
        Hin,
        /// <summary>
        /// 
        /// </summary>
        Ind,
        /// <summary>
        /// 
        /// </summary>
        Ita,
        /// <summary>
        /// 
        /// </summary>
        Jpn,
        /// <summary>
        /// 
        /// </summary>
        Kor,
        /// <summary>
        /// 
        /// </summary>
        Msa,
        /// <summary>
        /// 
        /// </summary>
        Nld,
        /// <summary>
        /// 
        /// </summary>
        Pol,
        /// <summary>
        /// 
        /// </summary>
        Por,
        /// <summary>
        /// 
        /// </summary>
        Ron,
        /// <summary>
        /// 
        /// </summary>
        Rus,
        /// <summary>
        /// 
        /// </summary>
        Spa,
        /// <summary>
        /// 
        /// </summary>
        Swe,
        /// <summary>
        /// 
        /// </summary>
        Tha,
        /// <summary>
        /// 
        /// </summary>
        Tur,
        /// <summary>
        /// 
        /// </summary>
        Ukr,
        /// <summary>
        /// 
        /// </summary>
        Urd,
        /// <summary>
        /// 
        /// </summary>
        Vie,
        /// <summary>
        /// 
        /// </summary>
        Zho,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Language value)
        {
            return value switch
            {
                Language.Ara => "ara",
                Language.Auto => "auto",
                Language.Ben => "ben",
                Language.Ces => "ces",
                Language.Deu => "deu",
                Language.Ell => "ell",
                Language.Eng => "eng",
                Language.Fas => "fas",
                Language.Fra => "fra",
                Language.Heb => "heb",
                Language.Hin => "hin",
                Language.Ind => "ind",
                Language.Ita => "ita",
                Language.Jpn => "jpn",
                Language.Kor => "kor",
                Language.Msa => "msa",
                Language.Nld => "nld",
                Language.Pol => "pol",
                Language.Por => "por",
                Language.Ron => "ron",
                Language.Rus => "rus",
                Language.Spa => "spa",
                Language.Swe => "swe",
                Language.Tha => "tha",
                Language.Tur => "tur",
                Language.Ukr => "ukr",
                Language.Urd => "urd",
                Language.Vie => "vie",
                Language.Zho => "zho",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Language? ToEnum(string value)
        {
            return value switch
            {
                "ara" => Language.Ara,
                "auto" => Language.Auto,
                "ben" => Language.Ben,
                "ces" => Language.Ces,
                "deu" => Language.Deu,
                "ell" => Language.Ell,
                "eng" => Language.Eng,
                "fas" => Language.Fas,
                "fra" => Language.Fra,
                "heb" => Language.Heb,
                "hin" => Language.Hin,
                "ind" => Language.Ind,
                "ita" => Language.Ita,
                "jpn" => Language.Jpn,
                "kor" => Language.Kor,
                "msa" => Language.Msa,
                "nld" => Language.Nld,
                "pol" => Language.Pol,
                "por" => Language.Por,
                "ron" => Language.Ron,
                "rus" => Language.Rus,
                "spa" => Language.Spa,
                "swe" => Language.Swe,
                "tha" => Language.Tha,
                "tur" => Language.Tur,
                "ukr" => Language.Ukr,
                "urd" => Language.Urd,
                "vie" => Language.Vie,
                "zho" => Language.Zho,
                _ => null,
            };
        }
    }
}