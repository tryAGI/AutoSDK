//HintName: G.Models.ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Agent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemDiscriminatorType value)
        {
            return value switch
            {
                ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemDiscriminatorType.Agent => "agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "agent" => ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemDiscriminatorType.Agent,
                _ => null,
            };
        }
    }
}