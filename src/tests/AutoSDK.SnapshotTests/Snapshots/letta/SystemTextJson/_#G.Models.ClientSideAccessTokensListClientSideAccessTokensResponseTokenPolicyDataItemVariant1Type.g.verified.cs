//HintName: G.Models.ClientSideAccessTokensListClientSideAccessTokensResponseTokenPolicyDataItemVariant1Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ClientSideAccessTokensListClientSideAccessTokensResponseTokenPolicyDataItemVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        Agent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ClientSideAccessTokensListClientSideAccessTokensResponseTokenPolicyDataItemVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClientSideAccessTokensListClientSideAccessTokensResponseTokenPolicyDataItemVariant1Type value)
        {
            return value switch
            {
                ClientSideAccessTokensListClientSideAccessTokensResponseTokenPolicyDataItemVariant1Type.Agent => "agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClientSideAccessTokensListClientSideAccessTokensResponseTokenPolicyDataItemVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "agent" => ClientSideAccessTokensListClientSideAccessTokensResponseTokenPolicyDataItemVariant1Type.Agent,
                _ => null,
            };
        }
    }
}