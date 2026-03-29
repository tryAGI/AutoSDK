//HintName: G.Models.TraceStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum TraceStatus
    {
        /// <summary>
        /// 
        /// </summary>
        DescendantError,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Running,
        /// <summary>
        /// 
        /// </summary>
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TraceStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TraceStatus value)
        {
            return value switch
            {
                TraceStatus.DescendantError => "descendant_error",
                TraceStatus.Error => "error",
                TraceStatus.Running => "running",
                TraceStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TraceStatus? ToEnum(string value)
        {
            return value switch
            {
                "descendant_error" => TraceStatus.DescendantError,
                "error" => TraceStatus.Error,
                "running" => TraceStatus.Running,
                "success" => TraceStatus.Success,
                _ => null,
            };
        }
    }
}