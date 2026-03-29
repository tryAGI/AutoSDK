//HintName: G.Models.CallFilterCallStatusValueItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CallFilterCallStatusValueItem
    {
        /// <summary>
        /// 
        /// </summary>
        Ended,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        NotConnected,
        /// <summary>
        /// 
        /// </summary>
        Ongoing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CallFilterCallStatusValueItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CallFilterCallStatusValueItem value)
        {
            return value switch
            {
                CallFilterCallStatusValueItem.Ended => "ended",
                CallFilterCallStatusValueItem.Error => "error",
                CallFilterCallStatusValueItem.NotConnected => "not_connected",
                CallFilterCallStatusValueItem.Ongoing => "ongoing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CallFilterCallStatusValueItem? ToEnum(string value)
        {
            return value switch
            {
                "ended" => CallFilterCallStatusValueItem.Ended,
                "error" => CallFilterCallStatusValueItem.Error,
                "not_connected" => CallFilterCallStatusValueItem.NotConnected,
                "ongoing" => CallFilterCallStatusValueItem.Ongoing,
                _ => null,
            };
        }
    }
}