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
        Auto,
        /// <summary>
        /// 
        /// </summary>
        Eng,
        /// <summary>
        /// 
        /// </summary>
        Deu,
        /// <summary>
        /// 
        /// </summary>
        Fra,
        /// <summary>
        /// 
        /// </summary>
        Zho,
        /// <summary>
        /// 
        /// </summary>
        Kor,
        /// <summary>
        /// 
        /// </summary>
        Ara,
        /// <summary>
        /// 
        /// </summary>
        Rus,
        /// <summary>
        /// 
        /// </summary>
        Tha,
        /// <summary>
        /// 
        /// </summary>
        Nld,
        /// <summary>
        /// 
        /// </summary>
        Ita,
        /// <summary>
        /// 
        /// </summary>
        Por,
        /// <summary>
        /// 
        /// </summary>
        Spa,
        /// <summary>
        /// 
        /// </summary>
        Jpn,
        /// <summary>
        /// 
        /// </summary>
        Pol,
        /// <summary>
        /// 
        /// </summary>
        Tur,
        /// <summary>
        /// 
        /// </summary>
        Vie,
        /// <summary>
        /// 
        /// </summary>
        Ind,
        /// <summary>
        /// 
        /// </summary>
        Ces,
        /// <summary>
        /// 
        /// </summary>
        Ukr,
        /// <summary>
        /// 
        /// </summary>
        Ell,
        /// <summary>
        /// 
        /// </summary>
        Heb,
        /// <summary>
        /// 
        /// </summary>
        Fas,
        /// <summary>
        /// 
        /// </summary>
        Hin,
        /// <summary>
        /// 
        /// </summary>
        Urd,
        /// <summary>
        /// 
        /// </summary>
        Swe,
        /// <summary>
        /// 
        /// </summary>
        Ben,
        /// <summary>
        /// 
        /// </summary>
        Msa,
        /// <summary>
        /// 
        /// </summary>
        Ron,
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
                Language.Auto => "auto",
                Language.Eng => "eng",
                Language.Deu => "deu",
                Language.Fra => "fra",
                Language.Zho => "zho",
                Language.Kor => "kor",
                Language.Ara => "ara",
                Language.Rus => "rus",
                Language.Tha => "tha",
                Language.Nld => "nld",
                Language.Ita => "ita",
                Language.Por => "por",
                Language.Spa => "spa",
                Language.Jpn => "jpn",
                Language.Pol => "pol",
                Language.Tur => "tur",
                Language.Vie => "vie",
                Language.Ind => "ind",
                Language.Ces => "ces",
                Language.Ukr => "ukr",
                Language.Ell => "ell",
                Language.Heb => "heb",
                Language.Fas => "fas",
                Language.Hin => "hin",
                Language.Urd => "urd",
                Language.Swe => "swe",
                Language.Ben => "ben",
                Language.Msa => "msa",
                Language.Ron => "ron",
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
                "auto" => Language.Auto,
                "eng" => Language.Eng,
                "deu" => Language.Deu,
                "fra" => Language.Fra,
                "zho" => Language.Zho,
                "kor" => Language.Kor,
                "ara" => Language.Ara,
                "rus" => Language.Rus,
                "tha" => Language.Tha,
                "nld" => Language.Nld,
                "ita" => Language.Ita,
                "por" => Language.Por,
                "spa" => Language.Spa,
                "jpn" => Language.Jpn,
                "pol" => Language.Pol,
                "tur" => Language.Tur,
                "vie" => Language.Vie,
                "ind" => Language.Ind,
                "ces" => Language.Ces,
                "ukr" => Language.Ukr,
                "ell" => Language.Ell,
                "heb" => Language.Heb,
                "fas" => Language.Fas,
                "hin" => Language.Hin,
                "urd" => Language.Urd,
                "swe" => Language.Swe,
                "ben" => Language.Ben,
                "msa" => Language.Msa,
                "ron" => Language.Ron,
                _ => null,
            };
        }
    }
}