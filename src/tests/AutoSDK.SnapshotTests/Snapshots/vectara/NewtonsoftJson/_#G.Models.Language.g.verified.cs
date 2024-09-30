//HintName: G.Models.Language.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Languages that the Vectara platform supports.<br/>
    /// Default Value: auto
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum Language
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="auto")]
        Auto,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="eng")]
        Eng,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="deu")]
        Deu,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fra")]
        Fra,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="zho")]
        Zho,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="kor")]
        Kor,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ara")]
        Ara,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="rus")]
        Rus,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tha")]
        Tha,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="nld")]
        Nld,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ita")]
        Ita,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="por")]
        Por,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="spa")]
        Spa,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="jpn")]
        Jpn,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pol")]
        Pol,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tur")]
        Tur,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="vie")]
        Vie,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ind")]
        Ind,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ces")]
        Ces,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ukr")]
        Ukr,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ell")]
        Ell,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="heb")]
        Heb,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fas")]
        Fas,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="hin")]
        Hin,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="urd")]
        Urd,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="swe")]
        Swe,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ben")]
        Ben,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="msa")]
        Msa,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ron")]
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