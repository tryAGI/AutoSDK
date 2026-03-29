//HintName: G.Models.GetTestRunResponseStatus4.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetTestRunResponseStatus4
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetTestRunResponseStatus4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetTestRunResponseStatus4 value)
        {
            return value switch
            {
                GetTestRunResponseStatus4.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetTestRunResponseStatus4? ToEnum(string value)
        {
            return value switch
            {
                "error" => GetTestRunResponseStatus4.Error,
                _ => null,
            };
        }
    }
}