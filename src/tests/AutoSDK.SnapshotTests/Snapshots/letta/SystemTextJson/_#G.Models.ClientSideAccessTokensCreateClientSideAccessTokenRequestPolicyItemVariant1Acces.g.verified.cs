//HintName: G.Models.ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemVariant1Acces.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemVariant1Acces
    {
        /// <summary>
        /// 
        /// </summary>
        ReadAgent,
        /// <summary>
        /// 
        /// </summary>
        ReadMessages,
        /// <summary>
        /// 
        /// </summary>
        WriteAgent,
        /// <summary>
        /// 
        /// </summary>
        WriteMessages,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemVariant1AccesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemVariant1Acces value)
        {
            return value switch
            {
                ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemVariant1Acces.ReadAgent => "read_agent",
                ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemVariant1Acces.ReadMessages => "read_messages",
                ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemVariant1Acces.WriteAgent => "write_agent",
                ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemVariant1Acces.WriteMessages => "write_messages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemVariant1Acces? ToEnum(string value)
        {
            return value switch
            {
                "read_agent" => ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemVariant1Acces.ReadAgent,
                "read_messages" => ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemVariant1Acces.ReadMessages,
                "write_agent" => ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemVariant1Acces.WriteAgent,
                "write_messages" => ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemVariant1Acces.WriteMessages,
                _ => null,
            };
        }
    }
}