//HintName: G.Models.ClientSideAccessTokensCreateClientSideAccessTokenResponsePolicyDataItemDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ClientSideAccessTokensCreateClientSideAccessTokenResponsePolicyDataItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Agent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ClientSideAccessTokensCreateClientSideAccessTokenResponsePolicyDataItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClientSideAccessTokensCreateClientSideAccessTokenResponsePolicyDataItemDiscriminatorType value)
        {
            return value switch
            {
                ClientSideAccessTokensCreateClientSideAccessTokenResponsePolicyDataItemDiscriminatorType.Agent => "agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClientSideAccessTokensCreateClientSideAccessTokenResponsePolicyDataItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "agent" => ClientSideAccessTokensCreateClientSideAccessTokenResponsePolicyDataItemDiscriminatorType.Agent,
                _ => null,
            };
        }
    }
}