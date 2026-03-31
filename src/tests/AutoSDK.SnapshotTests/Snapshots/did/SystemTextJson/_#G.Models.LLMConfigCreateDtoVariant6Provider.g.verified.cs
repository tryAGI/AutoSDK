//HintName: G.Models.LLMConfigCreateDtoVariant6Provider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Large Language Model provider.
    /// </summary>
    public enum LLMConfigCreateDtoVariant6Provider
    {
        /// <summary>
        /// 
        /// </summary>
        Google,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LLMConfigCreateDtoVariant6ProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LLMConfigCreateDtoVariant6Provider value)
        {
            return value switch
            {
                LLMConfigCreateDtoVariant6Provider.Google => "google",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LLMConfigCreateDtoVariant6Provider? ToEnum(string value)
        {
            return value switch
            {
                "google" => LLMConfigCreateDtoVariant6Provider.Google,
                _ => null,
            };
        }
    }
}