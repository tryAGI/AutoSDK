//HintName: G.Models.LMNTVoiceVoiceId.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum LMNTVoiceVoiceId
    {
        /// <summary>
        /// 
        /// </summary>
        Amy,
        /// <summary>
        /// 
        /// </summary>
        Ansel,
        /// <summary>
        /// 
        /// </summary>
        Autumn,
        /// <summary>
        /// 
        /// </summary>
        Ava,
        /// <summary>
        /// 
        /// </summary>
        Brandon,
        /// <summary>
        /// 
        /// </summary>
        Caleb,
        /// <summary>
        /// 
        /// </summary>
        Cassian,
        /// <summary>
        /// 
        /// </summary>
        Chloe,
        /// <summary>
        /// 
        /// </summary>
        Dalton,
        /// <summary>
        /// 
        /// </summary>
        Daniel,
        /// <summary>
        /// 
        /// </summary>
        Dustin,
        /// <summary>
        /// 
        /// </summary>
        Elowen,
        /// <summary>
        /// 
        /// </summary>
        Evander,
        /// <summary>
        /// 
        /// </summary>
        Huxley,
        /// <summary>
        /// 
        /// </summary>
        James,
        /// <summary>
        /// 
        /// </summary>
        Juniper,
        /// <summary>
        /// 
        /// </summary>
        Kennedy,
        /// <summary>
        /// 
        /// </summary>
        Lauren,
        /// <summary>
        /// 
        /// </summary>
        Leah,
        /// <summary>
        /// 
        /// </summary>
        Lily,
        /// <summary>
        /// 
        /// </summary>
        Lucas,
        /// <summary>
        /// 
        /// </summary>
        Magnus,
        /// <summary>
        /// 
        /// </summary>
        Miles,
        /// <summary>
        /// 
        /// </summary>
        Morgan,
        /// <summary>
        /// 
        /// </summary>
        Natalie,
        /// <summary>
        /// 
        /// </summary>
        Nathan,
        /// <summary>
        /// 
        /// </summary>
        Noah,
        /// <summary>
        /// 
        /// </summary>
        Nyssa,
        /// <summary>
        /// 
        /// </summary>
        Oliver,
        /// <summary>
        /// 
        /// </summary>
        Paige,
        /// <summary>
        /// 
        /// </summary>
        Ryan,
        /// <summary>
        /// 
        /// </summary>
        Sadie,
        /// <summary>
        /// 
        /// </summary>
        Sophie,
        /// <summary>
        /// 
        /// </summary>
        Stella,
        /// <summary>
        /// 
        /// </summary>
        Terrence,
        /// <summary>
        /// 
        /// </summary>
        Tyler,
        /// <summary>
        /// 
        /// </summary>
        Vesper,
        /// <summary>
        /// 
        /// </summary>
        Violet,
        /// <summary>
        /// 
        /// </summary>
        Warrick,
        /// <summary>
        /// 
        /// </summary>
        Zain,
        /// <summary>
        /// 
        /// </summary>
        Zeke,
        /// <summary>
        /// 
        /// </summary>
        Zoe,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LMNTVoiceVoiceIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LMNTVoiceVoiceId value)
        {
            return value switch
            {
                LMNTVoiceVoiceId.Amy => "amy",
                LMNTVoiceVoiceId.Ansel => "ansel",
                LMNTVoiceVoiceId.Autumn => "autumn",
                LMNTVoiceVoiceId.Ava => "ava",
                LMNTVoiceVoiceId.Brandon => "brandon",
                LMNTVoiceVoiceId.Caleb => "caleb",
                LMNTVoiceVoiceId.Cassian => "cassian",
                LMNTVoiceVoiceId.Chloe => "chloe",
                LMNTVoiceVoiceId.Dalton => "dalton",
                LMNTVoiceVoiceId.Daniel => "daniel",
                LMNTVoiceVoiceId.Dustin => "dustin",
                LMNTVoiceVoiceId.Elowen => "elowen",
                LMNTVoiceVoiceId.Evander => "evander",
                LMNTVoiceVoiceId.Huxley => "huxley",
                LMNTVoiceVoiceId.James => "james",
                LMNTVoiceVoiceId.Juniper => "juniper",
                LMNTVoiceVoiceId.Kennedy => "kennedy",
                LMNTVoiceVoiceId.Lauren => "lauren",
                LMNTVoiceVoiceId.Leah => "leah",
                LMNTVoiceVoiceId.Lily => "lily",
                LMNTVoiceVoiceId.Lucas => "lucas",
                LMNTVoiceVoiceId.Magnus => "magnus",
                LMNTVoiceVoiceId.Miles => "miles",
                LMNTVoiceVoiceId.Morgan => "morgan",
                LMNTVoiceVoiceId.Natalie => "natalie",
                LMNTVoiceVoiceId.Nathan => "nathan",
                LMNTVoiceVoiceId.Noah => "noah",
                LMNTVoiceVoiceId.Nyssa => "nyssa",
                LMNTVoiceVoiceId.Oliver => "oliver",
                LMNTVoiceVoiceId.Paige => "paige",
                LMNTVoiceVoiceId.Ryan => "ryan",
                LMNTVoiceVoiceId.Sadie => "sadie",
                LMNTVoiceVoiceId.Sophie => "sophie",
                LMNTVoiceVoiceId.Stella => "stella",
                LMNTVoiceVoiceId.Terrence => "terrence",
                LMNTVoiceVoiceId.Tyler => "tyler",
                LMNTVoiceVoiceId.Vesper => "vesper",
                LMNTVoiceVoiceId.Violet => "violet",
                LMNTVoiceVoiceId.Warrick => "warrick",
                LMNTVoiceVoiceId.Zain => "zain",
                LMNTVoiceVoiceId.Zeke => "zeke",
                LMNTVoiceVoiceId.Zoe => "zoe",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LMNTVoiceVoiceId? ToEnum(string value)
        {
            return value switch
            {
                "amy" => LMNTVoiceVoiceId.Amy,
                "ansel" => LMNTVoiceVoiceId.Ansel,
                "autumn" => LMNTVoiceVoiceId.Autumn,
                "ava" => LMNTVoiceVoiceId.Ava,
                "brandon" => LMNTVoiceVoiceId.Brandon,
                "caleb" => LMNTVoiceVoiceId.Caleb,
                "cassian" => LMNTVoiceVoiceId.Cassian,
                "chloe" => LMNTVoiceVoiceId.Chloe,
                "dalton" => LMNTVoiceVoiceId.Dalton,
                "daniel" => LMNTVoiceVoiceId.Daniel,
                "dustin" => LMNTVoiceVoiceId.Dustin,
                "elowen" => LMNTVoiceVoiceId.Elowen,
                "evander" => LMNTVoiceVoiceId.Evander,
                "huxley" => LMNTVoiceVoiceId.Huxley,
                "james" => LMNTVoiceVoiceId.James,
                "juniper" => LMNTVoiceVoiceId.Juniper,
                "kennedy" => LMNTVoiceVoiceId.Kennedy,
                "lauren" => LMNTVoiceVoiceId.Lauren,
                "leah" => LMNTVoiceVoiceId.Leah,
                "lily" => LMNTVoiceVoiceId.Lily,
                "lucas" => LMNTVoiceVoiceId.Lucas,
                "magnus" => LMNTVoiceVoiceId.Magnus,
                "miles" => LMNTVoiceVoiceId.Miles,
                "morgan" => LMNTVoiceVoiceId.Morgan,
                "natalie" => LMNTVoiceVoiceId.Natalie,
                "nathan" => LMNTVoiceVoiceId.Nathan,
                "noah" => LMNTVoiceVoiceId.Noah,
                "nyssa" => LMNTVoiceVoiceId.Nyssa,
                "oliver" => LMNTVoiceVoiceId.Oliver,
                "paige" => LMNTVoiceVoiceId.Paige,
                "ryan" => LMNTVoiceVoiceId.Ryan,
                "sadie" => LMNTVoiceVoiceId.Sadie,
                "sophie" => LMNTVoiceVoiceId.Sophie,
                "stella" => LMNTVoiceVoiceId.Stella,
                "terrence" => LMNTVoiceVoiceId.Terrence,
                "tyler" => LMNTVoiceVoiceId.Tyler,
                "vesper" => LMNTVoiceVoiceId.Vesper,
                "violet" => LMNTVoiceVoiceId.Violet,
                "warrick" => LMNTVoiceVoiceId.Warrick,
                "zain" => LMNTVoiceVoiceId.Zain,
                "zeke" => LMNTVoiceVoiceId.Zeke,
                "zoe" => LMNTVoiceVoiceId.Zoe,
                _ => null,
            };
        }
    }
}