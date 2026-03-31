//HintName: G.Models.LLMConfigCreateDtoVariant2Provider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Large Language Model provider.
    /// </summary>
    public enum LLMConfigCreateDtoVariant2Provider
    {
        /// <summary>
        /// 
        /// </summary>
        Custom,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LLMConfigCreateDtoVariant2ProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LLMConfigCreateDtoVariant2Provider value)
        {
            return value switch
            {
                LLMConfigCreateDtoVariant2Provider.Custom => "custom",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LLMConfigCreateDtoVariant2Provider? ToEnum(string value)
        {
            return value switch
            {
                "custom" => LLMConfigCreateDtoVariant2Provider.Custom,
                _ => null,
            };
        }
    }
}