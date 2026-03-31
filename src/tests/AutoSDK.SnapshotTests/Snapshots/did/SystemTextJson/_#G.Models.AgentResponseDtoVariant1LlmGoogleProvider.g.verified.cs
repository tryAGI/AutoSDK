//HintName: G.Models.AgentResponseDtoVariant1LlmGoogleProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Large Language Model provider.
    /// </summary>
    public enum AgentResponseDtoVariant1LlmGoogleProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Google,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentResponseDtoVariant1LlmGoogleProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentResponseDtoVariant1LlmGoogleProvider value)
        {
            return value switch
            {
                AgentResponseDtoVariant1LlmGoogleProvider.Google => "google",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentResponseDtoVariant1LlmGoogleProvider? ToEnum(string value)
        {
            return value switch
            {
                "google" => AgentResponseDtoVariant1LlmGoogleProvider.Google,
                _ => null,
            };
        }
    }
}