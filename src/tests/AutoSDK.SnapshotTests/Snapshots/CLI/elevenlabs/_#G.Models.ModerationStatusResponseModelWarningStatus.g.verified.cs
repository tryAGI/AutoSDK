//HintName: G.Models.ModerationStatusResponseModelWarningStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The warning status of the user.
    /// </summary>
    public enum ModerationStatusResponseModelWarningStatus
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
    public static class ModerationStatusResponseModelWarningStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModerationStatusResponseModelWarningStatus value)
        {
            return value switch
            {
                ModerationStatusResponseModelWarningStatus.Warning => "warning",
                ModerationStatusResponseModelWarningStatus.WarningCleared => "warning_cleared",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModerationStatusResponseModelWarningStatus? ToEnum(string value)
        {
            return value switch
            {
                "warning" => ModerationStatusResponseModelWarningStatus.Warning,
                "warning_cleared" => ModerationStatusResponseModelWarningStatus.WarningCleared,
                _ => null,
            };
        }
    }
}