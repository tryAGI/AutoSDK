//HintName: G.Models.ParserLanguages.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Enum for representing the languages supported by the parser.
    /// </summary>
    public enum ParserLanguages
    {
        /// <summary>
        /// 
        /// </summary>
        Abq,
        /// <summary>
        /// 
        /// </summary>
        Ady,
        /// <summary>
        /// 
        /// </summary>
        Af,
        /// <summary>
        /// 
        /// </summary>
        Ang,
        /// <summary>
        /// 
        /// </summary>
        Ar,
        /// <summary>
        /// 
        /// </summary>
        As,
        /// <summary>
        /// 
        /// </summary>
        Ava,
        /// <summary>
        /// 
        /// </summary>
        Az,
        /// <summary>
        /// 
        /// </summary>
        Be,
        /// <summary>
        /// 
        /// </summary>
        Bg,
        /// <summary>
        /// 
        /// </summary>
        Bgc,
        /// <summary>
        /// 
        /// </summary>
        Bh,
        /// <summary>
        /// 
        /// </summary>
        Bho,
        /// <summary>
        /// 
        /// </summary>
        Bn,
        /// <summary>
        /// 
        /// </summary>
        Bs,
        /// <summary>
        /// 
        /// </summary>
        ChSim,
        /// <summary>
        /// 
        /// </summary>
        ChTra,
        /// <summary>
        /// 
        /// </summary>
        Che,
        /// <summary>
        /// 
        /// </summary>
        Cs,
        /// <summary>
        /// 
        /// </summary>
        Cy,
        /// <summary>
        /// 
        /// </summary>
        Da,
        /// <summary>
        /// 
        /// </summary>
        Dar,
        /// <summary>
        /// 
        /// </summary>
        De,
        /// <summary>
        /// 
        /// </summary>
        En,
        /// <summary>
        /// 
        /// </summary>
        Es,
        /// <summary>
        /// 
        /// </summary>
        Et,
        /// <summary>
        /// 
        /// </summary>
        Fa,
        /// <summary>
        /// 
        /// </summary>
        Fr,
        /// <summary>
        /// 
        /// </summary>
        Ga,
        /// <summary>
        /// 
        /// </summary>
        Gom,
        /// <summary>
        /// 
        /// </summary>
        Hi,
        /// <summary>
        /// 
        /// </summary>
        Hr,
        /// <summary>
        /// 
        /// </summary>
        Hu,
        /// <summary>
        /// 
        /// </summary>
        Id,
        /// <summary>
        /// 
        /// </summary>
        Inh,
        /// <summary>
        /// 
        /// </summary>
        Is,
        /// <summary>
        /// 
        /// </summary>
        It,
        /// <summary>
        /// 
        /// </summary>
        Ja,
        /// <summary>
        /// 
        /// </summary>
        Kbd,
        /// <summary>
        /// 
        /// </summary>
        Kn,
        /// <summary>
        /// 
        /// </summary>
        Ko,
        /// <summary>
        /// 
        /// </summary>
        Ku,
        /// <summary>
        /// 
        /// </summary>
        La,
        /// <summary>
        /// 
        /// </summary>
        Lbe,
        /// <summary>
        /// 
        /// </summary>
        Lez,
        /// <summary>
        /// 
        /// </summary>
        Lt,
        /// <summary>
        /// 
        /// </summary>
        Lv,
        /// <summary>
        /// 
        /// </summary>
        Mah,
        /// <summary>
        /// 
        /// </summary>
        Mai,
        /// <summary>
        /// 
        /// </summary>
        Mi,
        /// <summary>
        /// 
        /// </summary>
        Mn,
        /// <summary>
        /// 
        /// </summary>
        Mni,
        /// <summary>
        /// 
        /// </summary>
        Mr,
        /// <summary>
        /// 
        /// </summary>
        Ms,
        /// <summary>
        /// 
        /// </summary>
        Mt,
        /// <summary>
        /// 
        /// </summary>
        Ne,
        /// <summary>
        /// 
        /// </summary>
        New,
        /// <summary>
        /// 
        /// </summary>
        Nl,
        /// <summary>
        /// 
        /// </summary>
        No,
        /// <summary>
        /// 
        /// </summary>
        Oc,
        /// <summary>
        /// 
        /// </summary>
        Pi,
        /// <summary>
        /// 
        /// </summary>
        Pl,
        /// <summary>
        /// 
        /// </summary>
        Pt,
        /// <summary>
        /// 
        /// </summary>
        Ro,
        /// <summary>
        /// 
        /// </summary>
        RsCyrillic,
        /// <summary>
        /// 
        /// </summary>
        RsLatin,
        /// <summary>
        /// 
        /// </summary>
        Ru,
        /// <summary>
        /// 
        /// </summary>
        Sa,
        /// <summary>
        /// 
        /// </summary>
        Sck,
        /// <summary>
        /// 
        /// </summary>
        Sk,
        /// <summary>
        /// 
        /// </summary>
        Sl,
        /// <summary>
        /// 
        /// </summary>
        Sq,
        /// <summary>
        /// 
        /// </summary>
        Sv,
        /// <summary>
        /// 
        /// </summary>
        Sw,
        /// <summary>
        /// 
        /// </summary>
        Ta,
        /// <summary>
        /// 
        /// </summary>
        Tab,
        /// <summary>
        /// 
        /// </summary>
        Te,
        /// <summary>
        /// 
        /// </summary>
        Th,
        /// <summary>
        /// 
        /// </summary>
        Tjk,
        /// <summary>
        /// 
        /// </summary>
        Tl,
        /// <summary>
        /// 
        /// </summary>
        Tr,
        /// <summary>
        /// 
        /// </summary>
        Ug,
        /// <summary>
        /// 
        /// </summary>
        Uk,
        /// <summary>
        /// 
        /// </summary>
        Ur,
        /// <summary>
        /// 
        /// </summary>
        Uz,
        /// <summary>
        /// 
        /// </summary>
        Vi,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ParserLanguagesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ParserLanguages value)
        {
            return value switch
            {
                ParserLanguages.Abq => "abq",
                ParserLanguages.Ady => "ady",
                ParserLanguages.Af => "af",
                ParserLanguages.Ang => "ang",
                ParserLanguages.Ar => "ar",
                ParserLanguages.As => "as",
                ParserLanguages.Ava => "ava",
                ParserLanguages.Az => "az",
                ParserLanguages.Be => "be",
                ParserLanguages.Bg => "bg",
                ParserLanguages.Bgc => "bgc",
                ParserLanguages.Bh => "bh",
                ParserLanguages.Bho => "bho",
                ParserLanguages.Bn => "bn",
                ParserLanguages.Bs => "bs",
                ParserLanguages.ChSim => "ch_sim",
                ParserLanguages.ChTra => "ch_tra",
                ParserLanguages.Che => "che",
                ParserLanguages.Cs => "cs",
                ParserLanguages.Cy => "cy",
                ParserLanguages.Da => "da",
                ParserLanguages.Dar => "dar",
                ParserLanguages.De => "de",
                ParserLanguages.En => "en",
                ParserLanguages.Es => "es",
                ParserLanguages.Et => "et",
                ParserLanguages.Fa => "fa",
                ParserLanguages.Fr => "fr",
                ParserLanguages.Ga => "ga",
                ParserLanguages.Gom => "gom",
                ParserLanguages.Hi => "hi",
                ParserLanguages.Hr => "hr",
                ParserLanguages.Hu => "hu",
                ParserLanguages.Id => "id",
                ParserLanguages.Inh => "inh",
                ParserLanguages.Is => "is",
                ParserLanguages.It => "it",
                ParserLanguages.Ja => "ja",
                ParserLanguages.Kbd => "kbd",
                ParserLanguages.Kn => "kn",
                ParserLanguages.Ko => "ko",
                ParserLanguages.Ku => "ku",
                ParserLanguages.La => "la",
                ParserLanguages.Lbe => "lbe",
                ParserLanguages.Lez => "lez",
                ParserLanguages.Lt => "lt",
                ParserLanguages.Lv => "lv",
                ParserLanguages.Mah => "mah",
                ParserLanguages.Mai => "mai",
                ParserLanguages.Mi => "mi",
                ParserLanguages.Mn => "mn",
                ParserLanguages.Mni => "mni",
                ParserLanguages.Mr => "mr",
                ParserLanguages.Ms => "ms",
                ParserLanguages.Mt => "mt",
                ParserLanguages.Ne => "ne",
                ParserLanguages.New => "new",
                ParserLanguages.Nl => "nl",
                ParserLanguages.No => "no",
                ParserLanguages.Oc => "oc",
                ParserLanguages.Pi => "pi",
                ParserLanguages.Pl => "pl",
                ParserLanguages.Pt => "pt",
                ParserLanguages.Ro => "ro",
                ParserLanguages.RsCyrillic => "rs_cyrillic",
                ParserLanguages.RsLatin => "rs_latin",
                ParserLanguages.Ru => "ru",
                ParserLanguages.Sa => "sa",
                ParserLanguages.Sck => "sck",
                ParserLanguages.Sk => "sk",
                ParserLanguages.Sl => "sl",
                ParserLanguages.Sq => "sq",
                ParserLanguages.Sv => "sv",
                ParserLanguages.Sw => "sw",
                ParserLanguages.Ta => "ta",
                ParserLanguages.Tab => "tab",
                ParserLanguages.Te => "te",
                ParserLanguages.Th => "th",
                ParserLanguages.Tjk => "tjk",
                ParserLanguages.Tl => "tl",
                ParserLanguages.Tr => "tr",
                ParserLanguages.Ug => "ug",
                ParserLanguages.Uk => "uk",
                ParserLanguages.Ur => "ur",
                ParserLanguages.Uz => "uz",
                ParserLanguages.Vi => "vi",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ParserLanguages? ToEnum(string value)
        {
            return value switch
            {
                "abq" => ParserLanguages.Abq,
                "ady" => ParserLanguages.Ady,
                "af" => ParserLanguages.Af,
                "ang" => ParserLanguages.Ang,
                "ar" => ParserLanguages.Ar,
                "as" => ParserLanguages.As,
                "ava" => ParserLanguages.Ava,
                "az" => ParserLanguages.Az,
                "be" => ParserLanguages.Be,
                "bg" => ParserLanguages.Bg,
                "bgc" => ParserLanguages.Bgc,
                "bh" => ParserLanguages.Bh,
                "bho" => ParserLanguages.Bho,
                "bn" => ParserLanguages.Bn,
                "bs" => ParserLanguages.Bs,
                "ch_sim" => ParserLanguages.ChSim,
                "ch_tra" => ParserLanguages.ChTra,
                "che" => ParserLanguages.Che,
                "cs" => ParserLanguages.Cs,
                "cy" => ParserLanguages.Cy,
                "da" => ParserLanguages.Da,
                "dar" => ParserLanguages.Dar,
                "de" => ParserLanguages.De,
                "en" => ParserLanguages.En,
                "es" => ParserLanguages.Es,
                "et" => ParserLanguages.Et,
                "fa" => ParserLanguages.Fa,
                "fr" => ParserLanguages.Fr,
                "ga" => ParserLanguages.Ga,
                "gom" => ParserLanguages.Gom,
                "hi" => ParserLanguages.Hi,
                "hr" => ParserLanguages.Hr,
                "hu" => ParserLanguages.Hu,
                "id" => ParserLanguages.Id,
                "inh" => ParserLanguages.Inh,
                "is" => ParserLanguages.Is,
                "it" => ParserLanguages.It,
                "ja" => ParserLanguages.Ja,
                "kbd" => ParserLanguages.Kbd,
                "kn" => ParserLanguages.Kn,
                "ko" => ParserLanguages.Ko,
                "ku" => ParserLanguages.Ku,
                "la" => ParserLanguages.La,
                "lbe" => ParserLanguages.Lbe,
                "lez" => ParserLanguages.Lez,
                "lt" => ParserLanguages.Lt,
                "lv" => ParserLanguages.Lv,
                "mah" => ParserLanguages.Mah,
                "mai" => ParserLanguages.Mai,
                "mi" => ParserLanguages.Mi,
                "mn" => ParserLanguages.Mn,
                "mni" => ParserLanguages.Mni,
                "mr" => ParserLanguages.Mr,
                "ms" => ParserLanguages.Ms,
                "mt" => ParserLanguages.Mt,
                "ne" => ParserLanguages.Ne,
                "new" => ParserLanguages.New,
                "nl" => ParserLanguages.Nl,
                "no" => ParserLanguages.No,
                "oc" => ParserLanguages.Oc,
                "pi" => ParserLanguages.Pi,
                "pl" => ParserLanguages.Pl,
                "pt" => ParserLanguages.Pt,
                "ro" => ParserLanguages.Ro,
                "rs_cyrillic" => ParserLanguages.RsCyrillic,
                "rs_latin" => ParserLanguages.RsLatin,
                "ru" => ParserLanguages.Ru,
                "sa" => ParserLanguages.Sa,
                "sck" => ParserLanguages.Sck,
                "sk" => ParserLanguages.Sk,
                "sl" => ParserLanguages.Sl,
                "sq" => ParserLanguages.Sq,
                "sv" => ParserLanguages.Sv,
                "sw" => ParserLanguages.Sw,
                "ta" => ParserLanguages.Ta,
                "tab" => ParserLanguages.Tab,
                "te" => ParserLanguages.Te,
                "th" => ParserLanguages.Th,
                "tjk" => ParserLanguages.Tjk,
                "tl" => ParserLanguages.Tl,
                "tr" => ParserLanguages.Tr,
                "ug" => ParserLanguages.Ug,
                "uk" => ParserLanguages.Uk,
                "ur" => ParserLanguages.Ur,
                "uz" => ParserLanguages.Uz,
                "vi" => ParserLanguages.Vi,
                _ => null,
            };
        }
    }
}