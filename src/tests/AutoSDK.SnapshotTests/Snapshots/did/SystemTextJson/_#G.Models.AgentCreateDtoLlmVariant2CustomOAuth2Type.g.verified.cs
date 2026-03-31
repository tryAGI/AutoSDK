//HintName: G.Models.AgentCreateDtoLlmVariant2CustomOAuth2Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentCreateDtoLlmVariant2CustomOAuth2Type
    {
        /// <summary>
        /// 
        /// </summary>
        Oauth2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentCreateDtoLlmVariant2CustomOAuth2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentCreateDtoLlmVariant2CustomOAuth2Type value)
        {
            return value switch
            {
                AgentCreateDtoLlmVariant2CustomOAuth2Type.Oauth2 => "oauth2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentCreateDtoLlmVariant2CustomOAuth2Type? ToEnum(string value)
        {
            return value switch
            {
                "oauth2" => AgentCreateDtoLlmVariant2CustomOAuth2Type.Oauth2,
                _ => null,
            };
        }
    }
}