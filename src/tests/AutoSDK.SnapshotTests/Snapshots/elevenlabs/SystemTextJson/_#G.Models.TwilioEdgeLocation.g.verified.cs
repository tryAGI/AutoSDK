//HintName: G.Models.TwilioEdgeLocation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Valid Twilio edge locations.
    /// </summary>
    public enum TwilioEdgeLocation
    {
        /// <summary>
        /// 
        /// </summary>
        Ashburn,
        /// <summary>
        /// 
        /// </summary>
        Dublin,
        /// <summary>
        /// 
        /// </summary>
        Frankfurt,
        /// <summary>
        /// 
        /// </summary>
        Roaming,
        /// <summary>
        /// 
        /// </summary>
        SaoPaulo,
        /// <summary>
        /// 
        /// </summary>
        Singapore,
        /// <summary>
        /// 
        /// </summary>
        Sydney,
        /// <summary>
        /// 
        /// </summary>
        Tokyo,
        /// <summary>
        /// 
        /// </summary>
        Umatilla,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TwilioEdgeLocationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TwilioEdgeLocation value)
        {
            return value switch
            {
                TwilioEdgeLocation.Ashburn => "ashburn",
                TwilioEdgeLocation.Dublin => "dublin",
                TwilioEdgeLocation.Frankfurt => "frankfurt",
                TwilioEdgeLocation.Roaming => "roaming",
                TwilioEdgeLocation.SaoPaulo => "sao-paulo",
                TwilioEdgeLocation.Singapore => "singapore",
                TwilioEdgeLocation.Sydney => "sydney",
                TwilioEdgeLocation.Tokyo => "tokyo",
                TwilioEdgeLocation.Umatilla => "umatilla",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TwilioEdgeLocation? ToEnum(string value)
        {
            return value switch
            {
                "ashburn" => TwilioEdgeLocation.Ashburn,
                "dublin" => TwilioEdgeLocation.Dublin,
                "frankfurt" => TwilioEdgeLocation.Frankfurt,
                "roaming" => TwilioEdgeLocation.Roaming,
                "sao-paulo" => TwilioEdgeLocation.SaoPaulo,
                "singapore" => TwilioEdgeLocation.Singapore,
                "sydney" => TwilioEdgeLocation.Sydney,
                "tokyo" => TwilioEdgeLocation.Tokyo,
                "umatilla" => TwilioEdgeLocation.Umatilla,
                _ => null,
            };
        }
    }
}