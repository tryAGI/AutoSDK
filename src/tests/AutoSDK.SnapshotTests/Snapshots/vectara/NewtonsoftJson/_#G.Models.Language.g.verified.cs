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
        [global::System.Runtime.Serialization.EnumMember(Value="ara")]
        Ara,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="auto")]
        Auto,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ben")]
        Ben,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ces")]
        Ces,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="deu")]
        Deu,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ell")]
        Ell,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="eng")]
        Eng,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fas")]
        Fas,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fra")]
        Fra,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="heb")]
        Heb,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="hin")]
        Hin,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ind")]
        Ind,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ita")]
        Ita,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="jpn")]
        Jpn,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="kor")]
        Kor,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="msa")]
        Msa,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="nld")]
        Nld,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pol")]
        Pol,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="por")]
        Por,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ron")]
        Ron,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="rus")]
        Rus,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="spa")]
        Spa,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="swe")]
        Swe,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tha")]
        Tha,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tur")]
        Tur,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ukr")]
        Ukr,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="urd")]
        Urd,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="vie")]
        Vie,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="zho")]
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