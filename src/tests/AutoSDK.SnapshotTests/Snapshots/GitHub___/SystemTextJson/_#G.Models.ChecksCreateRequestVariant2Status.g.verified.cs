//HintName: G.Models.ChecksCreateRequestVariant2Status.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChecksCreateRequestVariant2Status
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
    public static class ChecksCreateRequestVariant2StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChecksCreateRequestVariant2Status value)
        {
            return value switch
            {
                ChecksCreateRequestVariant2Status.Queued => "queued",
                ChecksCreateRequestVariant2Status.InProgress => "in_progress",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChecksCreateRequestVariant2Status? ToEnum(string value)
        {
            return value switch
            {
                "queued" => ChecksCreateRequestVariant2Status.Queued,
                "in_progress" => ChecksCreateRequestVariant2Status.InProgress,
                _ => null,
            };
        }
    }
}