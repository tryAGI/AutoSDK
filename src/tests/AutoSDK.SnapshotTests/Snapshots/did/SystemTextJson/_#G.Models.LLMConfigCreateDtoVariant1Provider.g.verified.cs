//HintName: G.Models.LLMConfigCreateDtoVariant1Provider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Large Language Model provider.
    /// </summary>
    public enum LLMConfigCreateDtoVariant1Provider
    {
        /// <summary>
        /// 
        /// </summary>
        Openai,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LLMConfigCreateDtoVariant1ProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LLMConfigCreateDtoVariant1Provider value)
        {
            return value switch
            {
                LLMConfigCreateDtoVariant1Provider.Openai => "openai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LLMConfigCreateDtoVariant1Provider? ToEnum(string value)
        {
            return value switch
            {
                "openai" => LLMConfigCreateDtoVariant1Provider.Openai,
                _ => null,
            };
        }
    }
}