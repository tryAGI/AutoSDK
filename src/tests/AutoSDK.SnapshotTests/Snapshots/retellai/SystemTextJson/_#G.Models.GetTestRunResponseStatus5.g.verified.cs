//HintName: G.Models.GetTestRunResponseStatus5.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetTestRunResponseStatus5
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetTestRunResponseStatus5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetTestRunResponseStatus5 value)
        {
            return value switch
            {
                GetTestRunResponseStatus5.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetTestRunResponseStatus5? ToEnum(string value)
        {
            return value switch
            {
                "error" => GetTestRunResponseStatus5.Error,
                _ => null,
            };
        }
    }
}