//HintName: G.Models.OpenAiTextGeneratorOptionsType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of asset to generate - set to `text-generator` for text generation.<br/>
    /// Default Value: text-generator
    /// </summary>
    public enum OpenAiTextGeneratorOptionsType
    {
        /// <summary>
        /// 
        /// </summary>
        TextGenerator,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAiTextGeneratorOptionsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAiTextGeneratorOptionsType value)
        {
            return value switch
            {
                OpenAiTextGeneratorOptionsType.TextGenerator => "text-generator",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAiTextGeneratorOptionsType? ToEnum(string value)
        {
            return value switch
            {
                "text-generator" => OpenAiTextGeneratorOptionsType.TextGenerator,
                _ => null,
            };
        }
    }
}