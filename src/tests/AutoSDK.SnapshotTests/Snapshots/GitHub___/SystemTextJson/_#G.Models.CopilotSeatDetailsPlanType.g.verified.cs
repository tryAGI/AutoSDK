//HintName: G.Models.CopilotSeatDetailsPlanType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The Copilot plan of the organization, or the parent enterprise, when applicable.
    /// </summary>
    public enum CopilotSeatDetailsPlanType
    {
        /// <summary>
        /// 
        /// </summary>
        Business,
        /// <summary>
        /// 
        /// </summary>
        Enterprise,
        /// <summary>
        /// 
        /// </summary>
        Unknown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CopilotSeatDetailsPlanTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CopilotSeatDetailsPlanType value)
        {
            return value switch
            {
                CopilotSeatDetailsPlanType.Business => "business",
                CopilotSeatDetailsPlanType.Enterprise => "enterprise",
                CopilotSeatDetailsPlanType.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CopilotSeatDetailsPlanType? ToEnum(string value)
        {
            return value switch
            {
                "business" => CopilotSeatDetailsPlanType.Business,
                "enterprise" => CopilotSeatDetailsPlanType.Enterprise,
                "unknown" => CopilotSeatDetailsPlanType.Unknown,
                _ => null,
            };
        }
    }
}