//HintName: G.Models.TwilioRegionId.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Valid Twilio region IDs.
    /// </summary>
    public enum TwilioRegionId
    {
        /// <summary>
        /// 
        /// </summary>
        Au1,
        /// <summary>
        /// 
        /// </summary>
        Ie1,
        /// <summary>
        /// 
        /// </summary>
        Us1,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TwilioRegionIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TwilioRegionId value)
        {
            return value switch
            {
                TwilioRegionId.Au1 => "au1",
                TwilioRegionId.Ie1 => "ie1",
                TwilioRegionId.Us1 => "us1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TwilioRegionId? ToEnum(string value)
        {
            return value switch
            {
                "au1" => TwilioRegionId.Au1,
                "ie1" => TwilioRegionId.Ie1,
                "us1" => TwilioRegionId.Us1,
                _ => null,
            };
        }
    }
}