//HintName: G.Models.ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemVariant1Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="agent")]
        Agent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemVariant1Type value)
        {
            return value switch
            {
                ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemVariant1Type.Agent => "agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "agent" => ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemVariant1Type.Agent,
                _ => null,
            };
        }
    }
}