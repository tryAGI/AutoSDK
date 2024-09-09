//HintName: G.Models.ChecksUpdateRequestVariant1Status.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChecksUpdateRequestVariant1Status
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChecksUpdateRequestVariant1StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChecksUpdateRequestVariant1Status value)
        {
            return value switch
            {
                ChecksUpdateRequestVariant1Status.Completed => "completed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChecksUpdateRequestVariant1Status? ToEnum(string value)
        {
            return value switch
            {
                "completed" => ChecksUpdateRequestVariant1Status.Completed,
                _ => null,
            };
        }
    }
}