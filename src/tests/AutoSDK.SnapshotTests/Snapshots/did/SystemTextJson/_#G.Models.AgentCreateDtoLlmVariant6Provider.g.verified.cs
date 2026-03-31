//HintName: G.Models.AgentCreateDtoLlmVariant6Provider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Large Language Model provider.
    /// </summary>
    public enum AgentCreateDtoLlmVariant6Provider
    {
        /// <summary>
        /// 
        /// </summary>
        Google,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentCreateDtoLlmVariant6ProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentCreateDtoLlmVariant6Provider value)
        {
            return value switch
            {
                AgentCreateDtoLlmVariant6Provider.Google => "google",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentCreateDtoLlmVariant6Provider? ToEnum(string value)
        {
            return value switch
            {
                "google" => AgentCreateDtoLlmVariant6Provider.Google,
                _ => null,
            };
        }
    }
}