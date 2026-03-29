//HintName: G.Models.ClientSideAccessTokensListClientSideAccessTokensResponseTokenPolicyDataItemVariant1Acces.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ClientSideAccessTokensListClientSideAccessTokensResponseTokenPolicyDataItemVariant1Acces
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
    public static class ClientSideAccessTokensListClientSideAccessTokensResponseTokenPolicyDataItemVariant1AccesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClientSideAccessTokensListClientSideAccessTokensResponseTokenPolicyDataItemVariant1Acces value)
        {
            return value switch
            {
                ClientSideAccessTokensListClientSideAccessTokensResponseTokenPolicyDataItemVariant1Acces.ReadAgent => "read_agent",
                ClientSideAccessTokensListClientSideAccessTokensResponseTokenPolicyDataItemVariant1Acces.ReadMessages => "read_messages",
                ClientSideAccessTokensListClientSideAccessTokensResponseTokenPolicyDataItemVariant1Acces.WriteAgent => "write_agent",
                ClientSideAccessTokensListClientSideAccessTokensResponseTokenPolicyDataItemVariant1Acces.WriteMessages => "write_messages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClientSideAccessTokensListClientSideAccessTokensResponseTokenPolicyDataItemVariant1Acces? ToEnum(string value)
        {
            return value switch
            {
                "read_agent" => ClientSideAccessTokensListClientSideAccessTokensResponseTokenPolicyDataItemVariant1Acces.ReadAgent,
                "read_messages" => ClientSideAccessTokensListClientSideAccessTokensResponseTokenPolicyDataItemVariant1Acces.ReadMessages,
                "write_agent" => ClientSideAccessTokensListClientSideAccessTokensResponseTokenPolicyDataItemVariant1Acces.WriteAgent,
                "write_messages" => ClientSideAccessTokensListClientSideAccessTokensResponseTokenPolicyDataItemVariant1Acces.WriteMessages,
                _ => null,
            };
        }
    }
}