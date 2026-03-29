//HintName: G.Models.RimeAIVoiceVoiceId.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Popular Rime AI voices across mist, mistv2, and arcana models. Any valid Rime AI voice ID is accepted, not just these suggestions.
    /// </summary>
    public enum RimeAIVoiceVoiceId
    {
        /// <summary>
        /// 
        /// </summary>
        Albion,
        /// <summary>
        /// 
        /// </summary>
        Alpine,
        /// <summary>
        /// 
        /// </summary>
        Amber,
        /// <summary>
        /// 
        /// </summary>
        Andromeda,
        /// <summary>
        /// 
        /// </summary>
        Arcade,
        /// <summary>
        /// 
        /// </summary>
        Astra,
        /// <summary>
        /// 
        /// </summary>
        Atrium,
        /// <summary>
        /// 
        /// </summary>
        Bond,
        /// <summary>
        /// 
        /// </summary>
        Breeze,
        /// <summary>
        /// 
        /// </summary>
        Cedar,
        /// <summary>
        /// 
        /// </summary>
        Celeste,
        /// <summary>
        /// 
        /// </summary>
        Colin,
        /// <summary>
        /// 
        /// </summary>
        Cove,
        /// <summary>
        /// 
        /// </summary>
        Creek,
        /// <summary>
        /// 
        /// </summary>
        Cupola,
        /// <summary>
        /// 
        /// </summary>
        Estelle,
        /// <summary>
        /// 
        /// </summary>
        Esther,
        /// <summary>
        /// 
        /// </summary>
        Eucalyptus,
        /// <summary>
        /// 
        /// </summary>
        Eva,
        /// <summary>
        /// 
        /// </summary>
        Falcon,
        /// <summary>
        /// 
        /// </summary>
        Fern,
        /// <summary>
        /// 
        /// </summary>
        Glacier,
        /// <summary>
        /// 
        /// </summary>
        Hank,
        /// <summary>
        /// 
        /// </summary>
        Helen,
        /// <summary>
        /// 
        /// </summary>
        Joy,
        /// <summary>
        /// 
        /// </summary>
        Lagoon,
        /// <summary>
        /// 
        /// </summary>
        Lintel,
        /// <summary>
        /// 
        /// </summary>
        Luna,
        /// <summary>
        /// 
        /// </summary>
        Lyra,
        /// <summary>
        /// 
        /// </summary>
        Marlu,
        /// <summary>
        /// 
        /// </summary>
        Marsh,
        /// <summary>
        /// 
        /// </summary>
        Masonry,
        /// <summary>
        /// 
        /// </summary>
        Maya,
        /// <summary>
        /// 
        /// </summary>
        MesaExtra,
        /// <summary>
        /// 
        /// </summary>
        Moon,
        /// <summary>
        /// 
        /// </summary>
        Moraine,
        /// <summary>
        /// 
        /// </summary>
        Nicholas,
        /// <summary>
        /// 
        /// </summary>
        Oculus,
        /// <summary>
        /// 
        /// </summary>
        Orion,
        /// <summary>
        /// 
        /// </summary>
        Parapet,
        /// <summary>
        /// 
        /// </summary>
        Peak,
        /// <summary>
        /// 
        /// </summary>
        Sirius,
        /// <summary>
        /// 
        /// </summary>
        Summit,
        /// <summary>
        /// 
        /// </summary>
        Talon,
        /// <summary>
        /// 
        /// </summary>
        Thunder,
        /// <summary>
        /// 
        /// </summary>
        Transom,
        /// <summary>
        /// 
        /// </summary>
        Tundra,
        /// <summary>
        /// 
        /// </summary>
        Tyler,
        /// <summary>
        /// 
        /// </summary>
        Vespera,
        /// <summary>
        /// 
        /// </summary>
        Wildflower,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RimeAIVoiceVoiceIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RimeAIVoiceVoiceId value)
        {
            return value switch
            {
                RimeAIVoiceVoiceId.Albion => "albion",
                RimeAIVoiceVoiceId.Alpine => "alpine",
                RimeAIVoiceVoiceId.Amber => "amber",
                RimeAIVoiceVoiceId.Andromeda => "andromeda",
                RimeAIVoiceVoiceId.Arcade => "arcade",
                RimeAIVoiceVoiceId.Astra => "astra",
                RimeAIVoiceVoiceId.Atrium => "atrium",
                RimeAIVoiceVoiceId.Bond => "bond",
                RimeAIVoiceVoiceId.Breeze => "breeze",
                RimeAIVoiceVoiceId.Cedar => "cedar",
                RimeAIVoiceVoiceId.Celeste => "celeste",
                RimeAIVoiceVoiceId.Colin => "colin",
                RimeAIVoiceVoiceId.Cove => "cove",
                RimeAIVoiceVoiceId.Creek => "creek",
                RimeAIVoiceVoiceId.Cupola => "cupola",
                RimeAIVoiceVoiceId.Estelle => "estelle",
                RimeAIVoiceVoiceId.Esther => "esther",
                RimeAIVoiceVoiceId.Eucalyptus => "eucalyptus",
                RimeAIVoiceVoiceId.Eva => "eva",
                RimeAIVoiceVoiceId.Falcon => "falcon",
                RimeAIVoiceVoiceId.Fern => "fern",
                RimeAIVoiceVoiceId.Glacier => "glacier",
                RimeAIVoiceVoiceId.Hank => "hank",
                RimeAIVoiceVoiceId.Helen => "helen",
                RimeAIVoiceVoiceId.Joy => "joy",
                RimeAIVoiceVoiceId.Lagoon => "lagoon",
                RimeAIVoiceVoiceId.Lintel => "lintel",
                RimeAIVoiceVoiceId.Luna => "luna",
                RimeAIVoiceVoiceId.Lyra => "lyra",
                RimeAIVoiceVoiceId.Marlu => "marlu",
                RimeAIVoiceVoiceId.Marsh => "marsh",
                RimeAIVoiceVoiceId.Masonry => "masonry",
                RimeAIVoiceVoiceId.Maya => "maya",
                RimeAIVoiceVoiceId.MesaExtra => "mesa_extra",
                RimeAIVoiceVoiceId.Moon => "moon",
                RimeAIVoiceVoiceId.Moraine => "moraine",
                RimeAIVoiceVoiceId.Nicholas => "nicholas",
                RimeAIVoiceVoiceId.Oculus => "oculus",
                RimeAIVoiceVoiceId.Orion => "orion",
                RimeAIVoiceVoiceId.Parapet => "parapet",
                RimeAIVoiceVoiceId.Peak => "peak",
                RimeAIVoiceVoiceId.Sirius => "sirius",
                RimeAIVoiceVoiceId.Summit => "summit",
                RimeAIVoiceVoiceId.Talon => "talon",
                RimeAIVoiceVoiceId.Thunder => "thunder",
                RimeAIVoiceVoiceId.Transom => "transom",
                RimeAIVoiceVoiceId.Tundra => "tundra",
                RimeAIVoiceVoiceId.Tyler => "tyler",
                RimeAIVoiceVoiceId.Vespera => "vespera",
                RimeAIVoiceVoiceId.Wildflower => "wildflower",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RimeAIVoiceVoiceId? ToEnum(string value)
        {
            return value switch
            {
                "albion" => RimeAIVoiceVoiceId.Albion,
                "alpine" => RimeAIVoiceVoiceId.Alpine,
                "amber" => RimeAIVoiceVoiceId.Amber,
                "andromeda" => RimeAIVoiceVoiceId.Andromeda,
                "arcade" => RimeAIVoiceVoiceId.Arcade,
                "astra" => RimeAIVoiceVoiceId.Astra,
                "atrium" => RimeAIVoiceVoiceId.Atrium,
                "bond" => RimeAIVoiceVoiceId.Bond,
                "breeze" => RimeAIVoiceVoiceId.Breeze,
                "cedar" => RimeAIVoiceVoiceId.Cedar,
                "celeste" => RimeAIVoiceVoiceId.Celeste,
                "colin" => RimeAIVoiceVoiceId.Colin,
                "cove" => RimeAIVoiceVoiceId.Cove,
                "creek" => RimeAIVoiceVoiceId.Creek,
                "cupola" => RimeAIVoiceVoiceId.Cupola,
                "estelle" => RimeAIVoiceVoiceId.Estelle,
                "esther" => RimeAIVoiceVoiceId.Esther,
                "eucalyptus" => RimeAIVoiceVoiceId.Eucalyptus,
                "eva" => RimeAIVoiceVoiceId.Eva,
                "falcon" => RimeAIVoiceVoiceId.Falcon,
                "fern" => RimeAIVoiceVoiceId.Fern,
                "glacier" => RimeAIVoiceVoiceId.Glacier,
                "hank" => RimeAIVoiceVoiceId.Hank,
                "helen" => RimeAIVoiceVoiceId.Helen,
                "joy" => RimeAIVoiceVoiceId.Joy,
                "lagoon" => RimeAIVoiceVoiceId.Lagoon,
                "lintel" => RimeAIVoiceVoiceId.Lintel,
                "luna" => RimeAIVoiceVoiceId.Luna,
                "lyra" => RimeAIVoiceVoiceId.Lyra,
                "marlu" => RimeAIVoiceVoiceId.Marlu,
                "marsh" => RimeAIVoiceVoiceId.Marsh,
                "masonry" => RimeAIVoiceVoiceId.Masonry,
                "maya" => RimeAIVoiceVoiceId.Maya,
                "mesa_extra" => RimeAIVoiceVoiceId.MesaExtra,
                "moon" => RimeAIVoiceVoiceId.Moon,
                "moraine" => RimeAIVoiceVoiceId.Moraine,
                "nicholas" => RimeAIVoiceVoiceId.Nicholas,
                "oculus" => RimeAIVoiceVoiceId.Oculus,
                "orion" => RimeAIVoiceVoiceId.Orion,
                "parapet" => RimeAIVoiceVoiceId.Parapet,
                "peak" => RimeAIVoiceVoiceId.Peak,
                "sirius" => RimeAIVoiceVoiceId.Sirius,
                "summit" => RimeAIVoiceVoiceId.Summit,
                "talon" => RimeAIVoiceVoiceId.Talon,
                "thunder" => RimeAIVoiceVoiceId.Thunder,
                "transom" => RimeAIVoiceVoiceId.Transom,
                "tundra" => RimeAIVoiceVoiceId.Tundra,
                "tyler" => RimeAIVoiceVoiceId.Tyler,
                "vespera" => RimeAIVoiceVoiceId.Vespera,
                "wildflower" => RimeAIVoiceVoiceId.Wildflower,
                _ => null,
            };
        }
    }
}