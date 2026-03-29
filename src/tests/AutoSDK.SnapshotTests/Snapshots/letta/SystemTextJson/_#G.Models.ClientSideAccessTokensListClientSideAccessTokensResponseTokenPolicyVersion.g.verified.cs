//HintName: G.Models.ClientSideAccessTokensListClientSideAccessTokensResponseTokenPolicyVersion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ClientSideAccessTokensListClientSideAccessTokensResponseTokenPolicyVersion
    {
        /// <summary>
        /// 
        /// </summary>
        x1,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ClientSideAccessTokensListClientSideAccessTokensResponseTokenPolicyVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClientSideAccessTokensListClientSideAccessTokensResponseTokenPolicyVersion value)
        {
            return value switch
            {
                ClientSideAccessTokensListClientSideAccessTokensResponseTokenPolicyVersion.x1 => "1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClientSideAccessTokensListClientSideAccessTokensResponseTokenPolicyVersion? ToEnum(string value)
        {
            return value switch
            {
                "1" => ClientSideAccessTokensListClientSideAccessTokensResponseTokenPolicyVersion.x1,
                _ => null,
            };
        }
    }
}