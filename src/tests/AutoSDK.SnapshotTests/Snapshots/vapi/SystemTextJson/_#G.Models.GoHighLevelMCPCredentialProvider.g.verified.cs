//HintName: G.Models.GoHighLevelMCPCredentialProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GoHighLevelMCPCredentialProvider
    {
        /// <summary>
        /// 
        /// </summary>
        GhlOauth2Authorization,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GoHighLevelMCPCredentialProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GoHighLevelMCPCredentialProvider value)
        {
            return value switch
            {
                GoHighLevelMCPCredentialProvider.GhlOauth2Authorization => "ghl.oauth2-authorization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GoHighLevelMCPCredentialProvider? ToEnum(string value)
        {
            return value switch
            {
                "ghl.oauth2-authorization" => GoHighLevelMCPCredentialProvider.GhlOauth2Authorization,
                _ => null,
            };
        }
    }
}