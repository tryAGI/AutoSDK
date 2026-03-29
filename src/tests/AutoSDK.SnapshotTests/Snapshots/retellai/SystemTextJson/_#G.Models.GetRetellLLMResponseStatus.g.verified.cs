//HintName: G.Models.GetRetellLLMResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetRetellLLMResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetRetellLLMResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetRetellLLMResponseStatus value)
        {
            return value switch
            {
                GetRetellLLMResponseStatus.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetRetellLLMResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => GetRetellLLMResponseStatus.Error,
                _ => null,
            };
        }
    }
}