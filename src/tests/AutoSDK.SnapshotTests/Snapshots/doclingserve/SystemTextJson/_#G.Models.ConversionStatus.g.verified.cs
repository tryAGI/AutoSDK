//HintName: G.Models.ConversionStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ConversionStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Failure,
        /// <summary>
        /// 
        /// </summary>
        PartialSuccess,
        /// <summary>
        /// 
        /// </summary>
        Pending,
        /// <summary>
        /// 
        /// </summary>
        Skipped,
        /// <summary>
        /// 
        /// </summary>
        Started,
        /// <summary>
        /// 
        /// </summary>
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConversionStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConversionStatus value)
        {
            return value switch
            {
                ConversionStatus.Failure => "failure",
                ConversionStatus.PartialSuccess => "partial_success",
                ConversionStatus.Pending => "pending",
                ConversionStatus.Skipped => "skipped",
                ConversionStatus.Started => "started",
                ConversionStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConversionStatus? ToEnum(string value)
        {
            return value switch
            {
                "failure" => ConversionStatus.Failure,
                "partial_success" => ConversionStatus.PartialSuccess,
                "pending" => ConversionStatus.Pending,
                "skipped" => ConversionStatus.Skipped,
                "started" => ConversionStatus.Started,
                "success" => ConversionStatus.Success,
                _ => null,
            };
        }
    }
}