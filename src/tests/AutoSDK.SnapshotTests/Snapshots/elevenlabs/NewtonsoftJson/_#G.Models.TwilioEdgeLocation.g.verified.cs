//HintName: G.Models.TwilioEdgeLocation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Valid Twilio edge locations.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TwilioEdgeLocation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ashburn")]
        Ashburn,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="dublin")]
        Dublin,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="frankfurt")]
        Frankfurt,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="sao-paulo")]
        SaoPaulo,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="singapore")]
        Singapore,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="sydney")]
        Sydney,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tokyo")]
        Tokyo,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="umatilla")]
        Umatilla,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="roaming")]
        Roaming,
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
                TwilioEdgeLocation.SaoPaulo => "sao-paulo",
                TwilioEdgeLocation.Singapore => "singapore",
                TwilioEdgeLocation.Sydney => "sydney",
                TwilioEdgeLocation.Tokyo => "tokyo",
                TwilioEdgeLocation.Umatilla => "umatilla",
                TwilioEdgeLocation.Roaming => "roaming",
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
                "sao-paulo" => TwilioEdgeLocation.SaoPaulo,
                "singapore" => TwilioEdgeLocation.Singapore,
                "sydney" => TwilioEdgeLocation.Sydney,
                "tokyo" => TwilioEdgeLocation.Tokyo,
                "umatilla" => TwilioEdgeLocation.Umatilla,
                "roaming" => TwilioEdgeLocation.Roaming,
                _ => null,
            };
        }
    }
}