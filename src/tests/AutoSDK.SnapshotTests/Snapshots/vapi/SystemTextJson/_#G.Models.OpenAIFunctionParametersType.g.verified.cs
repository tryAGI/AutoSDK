//HintName: G.Models.OpenAIFunctionParametersType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This must be set to 'object'. It instructs the model to return a JSON object containing the function call properties.
    /// </summary>
    public enum OpenAIFunctionParametersType
    {
        /// <summary>
        /// 
        /// </summary>
        Object,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAIFunctionParametersTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAIFunctionParametersType value)
        {
            return value switch
            {
                OpenAIFunctionParametersType.Object => "object",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAIFunctionParametersType? ToEnum(string value)
        {
            return value switch
            {
                "object" => OpenAIFunctionParametersType.Object,
                _ => null,
            };
        }
    }
}