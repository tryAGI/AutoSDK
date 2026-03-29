//HintName: G.Models.InflectionAICredentialProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the api key for Pi in InflectionAI's console. Get it from here: https://developers.inflection.ai/keys, billing will need to be setup
    /// </summary>
    public enum InflectionAICredentialProvider
    {
        /// <summary>
        /// 
        /// </summary>
        InflectionAi,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InflectionAICredentialProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InflectionAICredentialProvider value)
        {
            return value switch
            {
                InflectionAICredentialProvider.InflectionAi => "inflection-ai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InflectionAICredentialProvider? ToEnum(string value)
        {
            return value switch
            {
                "inflection-ai" => InflectionAICredentialProvider.InflectionAi,
                _ => null,
            };
        }
    }
}