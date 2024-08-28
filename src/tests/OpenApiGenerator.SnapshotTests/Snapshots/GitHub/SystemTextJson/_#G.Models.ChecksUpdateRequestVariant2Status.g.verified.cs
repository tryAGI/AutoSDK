//HintName: G.Models.ChecksUpdateRequestVariant2Status.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChecksUpdateRequestVariant2Status
    {
        /// <summary>
        /// 
        /// </summary>
        Queued,
        /// <summary>
        /// 
        /// </summary>
        InProgress,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChecksUpdateRequestVariant2StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChecksUpdateRequestVariant2Status value)
        {
            return value switch
            {
                ChecksUpdateRequestVariant2Status.Queued => "queued",
                ChecksUpdateRequestVariant2Status.InProgress => "in_progress",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChecksUpdateRequestVariant2Status? ToEnum(string value)
        {
            return value switch
            {
                "queued" => ChecksUpdateRequestVariant2Status.Queued,
                "in_progress" => ChecksUpdateRequestVariant2Status.InProgress,
                _ => null,
            };
        }
    }
}