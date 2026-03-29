//HintName: G.Models.GetBatchTestResponseStatus3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetBatchTestResponseStatus3
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetBatchTestResponseStatus3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetBatchTestResponseStatus3 value)
        {
            return value switch
            {
                GetBatchTestResponseStatus3.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetBatchTestResponseStatus3? ToEnum(string value)
        {
            return value switch
            {
                "error" => GetBatchTestResponseStatus3.Error,
                _ => null,
            };
        }
    }
}