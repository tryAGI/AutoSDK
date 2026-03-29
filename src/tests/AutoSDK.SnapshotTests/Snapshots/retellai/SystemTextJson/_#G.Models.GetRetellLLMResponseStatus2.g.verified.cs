//HintName: G.Models.GetRetellLLMResponseStatus2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetRetellLLMResponseStatus2
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetRetellLLMResponseStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetRetellLLMResponseStatus2 value)
        {
            return value switch
            {
                GetRetellLLMResponseStatus2.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetRetellLLMResponseStatus2? ToEnum(string value)
        {
            return value switch
            {
                "error" => GetRetellLLMResponseStatus2.Error,
                _ => null,
            };
        }
    }
}