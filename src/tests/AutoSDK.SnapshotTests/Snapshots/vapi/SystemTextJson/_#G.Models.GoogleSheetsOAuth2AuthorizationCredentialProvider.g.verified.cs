//HintName: G.Models.GoogleSheetsOAuth2AuthorizationCredentialProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GoogleSheetsOAuth2AuthorizationCredentialProvider
    {
        /// <summary>
        /// 
        /// </summary>
        GoogleSheetsOauth2Authorization,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GoogleSheetsOAuth2AuthorizationCredentialProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GoogleSheetsOAuth2AuthorizationCredentialProvider value)
        {
            return value switch
            {
                GoogleSheetsOAuth2AuthorizationCredentialProvider.GoogleSheetsOauth2Authorization => "google.sheets.oauth2-authorization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GoogleSheetsOAuth2AuthorizationCredentialProvider? ToEnum(string value)
        {
            return value switch
            {
                "google.sheets.oauth2-authorization" => GoogleSheetsOAuth2AuthorizationCredentialProvider.GoogleSheetsOauth2Authorization,
                _ => null,
            };
        }
    }
}