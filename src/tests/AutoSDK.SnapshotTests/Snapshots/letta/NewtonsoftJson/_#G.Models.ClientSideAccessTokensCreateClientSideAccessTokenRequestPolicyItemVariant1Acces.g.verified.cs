//HintName: G.Models.ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemVariant1Acces.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemVariant1Acces
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="read_agent")]
        ReadAgent,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="read_messages")]
        ReadMessages,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="write_agent")]
        WriteAgent,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="write_messages")]
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