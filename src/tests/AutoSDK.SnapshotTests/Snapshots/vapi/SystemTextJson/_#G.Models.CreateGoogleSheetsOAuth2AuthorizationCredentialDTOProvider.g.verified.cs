//HintName: G.Models.CreateGoogleSheetsOAuth2AuthorizationCredentialDTOProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateGoogleSheetsOAuth2AuthorizationCredentialDTOProvider
    {
        /// <summary>
        /// 
        /// </summary>
        GoogleSheetsOauth2Authorization,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateGoogleSheetsOAuth2AuthorizationCredentialDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateGoogleSheetsOAuth2AuthorizationCredentialDTOProvider value)
        {
            return value switch
            {
                CreateGoogleSheetsOAuth2AuthorizationCredentialDTOProvider.GoogleSheetsOauth2Authorization => "google.sheets.oauth2-authorization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateGoogleSheetsOAuth2AuthorizationCredentialDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "google.sheets.oauth2-authorization" => CreateGoogleSheetsOAuth2AuthorizationCredentialDTOProvider.GoogleSheetsOauth2Authorization,
                _ => null,
            };
        }
    }
}