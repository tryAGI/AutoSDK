//HintName: G.Models.AgentUpdateDtoLlmGoogleProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Large Language Model provider.
    /// </summary>
    public enum AgentUpdateDtoLlmGoogleProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Google,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentUpdateDtoLlmGoogleProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentUpdateDtoLlmGoogleProvider value)
        {
            return value switch
            {
                AgentUpdateDtoLlmGoogleProvider.Google => "google",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentUpdateDtoLlmGoogleProvider? ToEnum(string value)
        {
            return value switch
            {
                "google" => AgentUpdateDtoLlmGoogleProvider.Google,
                _ => null,
            };
        }
    }
}