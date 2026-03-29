//HintName: G.Models.GetTestRunResponseStatus2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetTestRunResponseStatus2
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetTestRunResponseStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetTestRunResponseStatus2 value)
        {
            return value switch
            {
                GetTestRunResponseStatus2.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetTestRunResponseStatus2? ToEnum(string value)
        {
            return value switch
            {
                "error" => GetTestRunResponseStatus2.Error,
                _ => null,
            };
        }
    }
}