//HintName: G.Models.ClientSideAccessTokensCreateClientSideAccessTokenResponsePolicyDataItemVariant1Acces.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ClientSideAccessTokensCreateClientSideAccessTokenResponsePolicyDataItemVariant1Acces
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
    public static class ClientSideAccessTokensCreateClientSideAccessTokenResponsePolicyDataItemVariant1AccesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClientSideAccessTokensCreateClientSideAccessTokenResponsePolicyDataItemVariant1Acces value)
        {
            return value switch
            {
                ClientSideAccessTokensCreateClientSideAccessTokenResponsePolicyDataItemVariant1Acces.ReadAgent => "read_agent",
                ClientSideAccessTokensCreateClientSideAccessTokenResponsePolicyDataItemVariant1Acces.ReadMessages => "read_messages",
                ClientSideAccessTokensCreateClientSideAccessTokenResponsePolicyDataItemVariant1Acces.WriteAgent => "write_agent",
                ClientSideAccessTokensCreateClientSideAccessTokenResponsePolicyDataItemVariant1Acces.WriteMessages => "write_messages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClientSideAccessTokensCreateClientSideAccessTokenResponsePolicyDataItemVariant1Acces? ToEnum(string value)
        {
            return value switch
            {
                "read_agent" => ClientSideAccessTokensCreateClientSideAccessTokenResponsePolicyDataItemVariant1Acces.ReadAgent,
                "read_messages" => ClientSideAccessTokensCreateClientSideAccessTokenResponsePolicyDataItemVariant1Acces.ReadMessages,
                "write_agent" => ClientSideAccessTokensCreateClientSideAccessTokenResponsePolicyDataItemVariant1Acces.WriteAgent,
                "write_messages" => ClientSideAccessTokensCreateClientSideAccessTokenResponsePolicyDataItemVariant1Acces.WriteMessages,
                _ => null,
            };
        }
    }
}