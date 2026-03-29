//HintName: G.Models.ShardCleanStatusTelemetryEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ShardCleanStatusTelemetryEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        Done,
        /// <summary>
        /// 
        /// </summary>
        Started,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ShardCleanStatusTelemetryEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ShardCleanStatusTelemetryEnum value)
        {
            return value switch
            {
                ShardCleanStatusTelemetryEnum.Cancelled => "cancelled",
                ShardCleanStatusTelemetryEnum.Done => "done",
                ShardCleanStatusTelemetryEnum.Started => "started",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ShardCleanStatusTelemetryEnum? ToEnum(string value)
        {
            return value switch
            {
                "cancelled" => ShardCleanStatusTelemetryEnum.Cancelled,
                "done" => ShardCleanStatusTelemetryEnum.Done,
                "started" => ShardCleanStatusTelemetryEnum.Started,
                _ => null,
            };
        }
    }
}