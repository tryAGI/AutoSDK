//HintName: G.Models.ResponseEngineCustomLmType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// type of the Response Engine.
    /// </summary>
    public enum ResponseEngineCustomLmType
    {
        /// <summary>
        /// 
        /// </summary>
        CustomLlm,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseEngineCustomLmTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseEngineCustomLmType value)
        {
            return value switch
            {
                ResponseEngineCustomLmType.CustomLlm => "custom-llm",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseEngineCustomLmType? ToEnum(string value)
        {
            return value switch
            {
                "custom-llm" => ResponseEngineCustomLmType.CustomLlm,
                _ => null,
            };
        }
    }
}