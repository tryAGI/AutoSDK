//HintName: G.Models.VapiVoiceVoiceId.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The voices provided by Vapi
    /// </summary>
    public enum VapiVoiceVoiceId
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
    public static class VapiVoiceVoiceIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VapiVoiceVoiceId value)
        {
            return value switch
            {
                VapiVoiceVoiceId.Clara => "Clara",
                VapiVoiceVoiceId.Cole => "Cole",
                VapiVoiceVoiceId.Dan => "Dan",
                VapiVoiceVoiceId.Elliot => "Elliot",
                VapiVoiceVoiceId.Emma => "Emma",
                VapiVoiceVoiceId.Godfrey => "Godfrey",
                VapiVoiceVoiceId.Hana => "Hana",
                VapiVoiceVoiceId.Harry => "Harry",
                VapiVoiceVoiceId.Jess => "Jess",
                VapiVoiceVoiceId.Kai => "Kai",
                VapiVoiceVoiceId.Kylie => "Kylie",
                VapiVoiceVoiceId.Leah => "Leah",
                VapiVoiceVoiceId.Leo => "Leo",
                VapiVoiceVoiceId.Lily => "Lily",
                VapiVoiceVoiceId.Mia => "Mia",
                VapiVoiceVoiceId.Naina => "Naina",
                VapiVoiceVoiceId.Neha => "Neha",
                VapiVoiceVoiceId.Neil => "Neil",
                VapiVoiceVoiceId.Nico => "Nico",
                VapiVoiceVoiceId.Paige => "Paige",
                VapiVoiceVoiceId.Rohan => "Rohan",
                VapiVoiceVoiceId.Sagar => "Sagar",
                VapiVoiceVoiceId.Savannah => "Savannah",
                VapiVoiceVoiceId.Spencer => "Spencer",
                VapiVoiceVoiceId.Tara => "Tara",
                VapiVoiceVoiceId.Zac => "Zac",
                VapiVoiceVoiceId.Zoe => "Zoe",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VapiVoiceVoiceId? ToEnum(string value)
        {
            return value switch
            {
                "Clara" => VapiVoiceVoiceId.Clara,
                "Cole" => VapiVoiceVoiceId.Cole,
                "Dan" => VapiVoiceVoiceId.Dan,
                "Elliot" => VapiVoiceVoiceId.Elliot,
                "Emma" => VapiVoiceVoiceId.Emma,
                "Godfrey" => VapiVoiceVoiceId.Godfrey,
                "Hana" => VapiVoiceVoiceId.Hana,
                "Harry" => VapiVoiceVoiceId.Harry,
                "Jess" => VapiVoiceVoiceId.Jess,
                "Kai" => VapiVoiceVoiceId.Kai,
                "Kylie" => VapiVoiceVoiceId.Kylie,
                "Leah" => VapiVoiceVoiceId.Leah,
                "Leo" => VapiVoiceVoiceId.Leo,
                "Lily" => VapiVoiceVoiceId.Lily,
                "Mia" => VapiVoiceVoiceId.Mia,
                "Naina" => VapiVoiceVoiceId.Naina,
                "Neha" => VapiVoiceVoiceId.Neha,
                "Neil" => VapiVoiceVoiceId.Neil,
                "Nico" => VapiVoiceVoiceId.Nico,
                "Paige" => VapiVoiceVoiceId.Paige,
                "Rohan" => VapiVoiceVoiceId.Rohan,
                "Sagar" => VapiVoiceVoiceId.Sagar,
                "Savannah" => VapiVoiceVoiceId.Savannah,
                "Spencer" => VapiVoiceVoiceId.Spencer,
                "Tara" => VapiVoiceVoiceId.Tara,
                "Zac" => VapiVoiceVoiceId.Zac,
                "Zoe" => VapiVoiceVoiceId.Zoe,
                _ => null,
            };
        }
    }
}