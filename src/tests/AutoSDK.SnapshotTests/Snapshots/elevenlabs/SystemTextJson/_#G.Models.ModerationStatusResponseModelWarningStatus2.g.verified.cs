//HintName: G.Models.ModerationStatusResponseModelWarningStatus2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ModerationStatusResponseModelWarningStatus2
    {
        /// <summary>
        /// 
        /// </summary>
        Warning,
        /// <summary>
        /// 
        /// </summary>
        WarningCleared,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModerationStatusResponseModelWarningStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModerationStatusResponseModelWarningStatus2 value)
        {
            return value switch
            {
                ModerationStatusResponseModelWarningStatus2.Warning => "warning",
                ModerationStatusResponseModelWarningStatus2.WarningCleared => "warning_cleared",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModerationStatusResponseModelWarningStatus2? ToEnum(string value)
        {
            return value switch
            {
                "warning" => ModerationStatusResponseModelWarningStatus2.Warning,
                "warning_cleared" => ModerationStatusResponseModelWarningStatus2.WarningCleared,
                _ => null,
            };
        }
    }
}