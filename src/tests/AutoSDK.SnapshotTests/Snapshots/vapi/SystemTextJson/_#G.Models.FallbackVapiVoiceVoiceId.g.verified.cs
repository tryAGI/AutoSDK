//HintName: G.Models.FallbackVapiVoiceVoiceId.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The voices provided by Vapi
    /// </summary>
    public enum FallbackVapiVoiceVoiceId
    {
        /// <summary>
        /// 
        /// </summary>
        Clara,
        /// <summary>
        /// 
        /// </summary>
        Cole,
        /// <summary>
        /// 
        /// </summary>
        Dan,
        /// <summary>
        /// 
        /// </summary>
        Elliot,
        /// <summary>
        /// 
        /// </summary>
        Emma,
        /// <summary>
        /// 
        /// </summary>
        Godfrey,
        /// <summary>
        /// 
        /// </summary>
        Hana,
        /// <summary>
        /// 
        /// </summary>
        Harry,
        /// <summary>
        /// 
        /// </summary>
        Jess,
        /// <summary>
        /// 
        /// </summary>
        Kai,
        /// <summary>
        /// 
        /// </summary>
        Kylie,
        /// <summary>
        /// 
        /// </summary>
        Leah,
        /// <summary>
        /// 
        /// </summary>
        Leo,
        /// <summary>
        /// 
        /// </summary>
        Lily,
        /// <summary>
        /// 
        /// </summary>
        Mia,
        /// <summary>
        /// 
        /// </summary>
        Naina,
        /// <summary>
        /// 
        /// </summary>
        Neha,
        /// <summary>
        /// 
        /// </summary>
        Neil,
        /// <summary>
        /// 
        /// </summary>
        Nico,
        /// <summary>
        /// 
        /// </summary>
        Paige,
        /// <summary>
        /// 
        /// </summary>
        Rohan,
        /// <summary>
        /// 
        /// </summary>
        Sagar,
        /// <summary>
        /// 
        /// </summary>
        Savannah,
        /// <summary>
        /// 
        /// </summary>
        Spencer,
        /// <summary>
        /// 
        /// </summary>
        Tara,
        /// <summary>
        /// 
        /// </summary>
        Zac,
        /// <summary>
        /// 
        /// </summary>
        Zoe,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FallbackVapiVoiceVoiceIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FallbackVapiVoiceVoiceId value)
        {
            return value switch
            {
                FallbackVapiVoiceVoiceId.Clara => "Clara",
                FallbackVapiVoiceVoiceId.Cole => "Cole",
                FallbackVapiVoiceVoiceId.Dan => "Dan",
                FallbackVapiVoiceVoiceId.Elliot => "Elliot",
                FallbackVapiVoiceVoiceId.Emma => "Emma",
                FallbackVapiVoiceVoiceId.Godfrey => "Godfrey",
                FallbackVapiVoiceVoiceId.Hana => "Hana",
                FallbackVapiVoiceVoiceId.Harry => "Harry",
                FallbackVapiVoiceVoiceId.Jess => "Jess",
                FallbackVapiVoiceVoiceId.Kai => "Kai",
                FallbackVapiVoiceVoiceId.Kylie => "Kylie",
                FallbackVapiVoiceVoiceId.Leah => "Leah",
                FallbackVapiVoiceVoiceId.Leo => "Leo",
                FallbackVapiVoiceVoiceId.Lily => "Lily",
                FallbackVapiVoiceVoiceId.Mia => "Mia",
                FallbackVapiVoiceVoiceId.Naina => "Naina",
                FallbackVapiVoiceVoiceId.Neha => "Neha",
                FallbackVapiVoiceVoiceId.Neil => "Neil",
                FallbackVapiVoiceVoiceId.Nico => "Nico",
                FallbackVapiVoiceVoiceId.Paige => "Paige",
                FallbackVapiVoiceVoiceId.Rohan => "Rohan",
                FallbackVapiVoiceVoiceId.Sagar => "Sagar",
                FallbackVapiVoiceVoiceId.Savannah => "Savannah",
                FallbackVapiVoiceVoiceId.Spencer => "Spencer",
                FallbackVapiVoiceVoiceId.Tara => "Tara",
                FallbackVapiVoiceVoiceId.Zac => "Zac",
                FallbackVapiVoiceVoiceId.Zoe => "Zoe",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FallbackVapiVoiceVoiceId? ToEnum(string value)
        {
            return value switch
            {
                "Clara" => FallbackVapiVoiceVoiceId.Clara,
                "Cole" => FallbackVapiVoiceVoiceId.Cole,
                "Dan" => FallbackVapiVoiceVoiceId.Dan,
                "Elliot" => FallbackVapiVoiceVoiceId.Elliot,
                "Emma" => FallbackVapiVoiceVoiceId.Emma,
                "Godfrey" => FallbackVapiVoiceVoiceId.Godfrey,
                "Hana" => FallbackVapiVoiceVoiceId.Hana,
                "Harry" => FallbackVapiVoiceVoiceId.Harry,
                "Jess" => FallbackVapiVoiceVoiceId.Jess,
                "Kai" => FallbackVapiVoiceVoiceId.Kai,
                "Kylie" => FallbackVapiVoiceVoiceId.Kylie,
                "Leah" => FallbackVapiVoiceVoiceId.Leah,
                "Leo" => FallbackVapiVoiceVoiceId.Leo,
                "Lily" => FallbackVapiVoiceVoiceId.Lily,
                "Mia" => FallbackVapiVoiceVoiceId.Mia,
                "Naina" => FallbackVapiVoiceVoiceId.Naina,
                "Neha" => FallbackVapiVoiceVoiceId.Neha,
                "Neil" => FallbackVapiVoiceVoiceId.Neil,
                "Nico" => FallbackVapiVoiceVoiceId.Nico,
                "Paige" => FallbackVapiVoiceVoiceId.Paige,
                "Rohan" => FallbackVapiVoiceVoiceId.Rohan,
                "Sagar" => FallbackVapiVoiceVoiceId.Sagar,
                "Savannah" => FallbackVapiVoiceVoiceId.Savannah,
                "Spencer" => FallbackVapiVoiceVoiceId.Spencer,
                "Tara" => FallbackVapiVoiceVoiceId.Tara,
                "Zac" => FallbackVapiVoiceVoiceId.Zac,
                "Zoe" => FallbackVapiVoiceVoiceId.Zoe,
                _ => null,
            };
        }
    }
}