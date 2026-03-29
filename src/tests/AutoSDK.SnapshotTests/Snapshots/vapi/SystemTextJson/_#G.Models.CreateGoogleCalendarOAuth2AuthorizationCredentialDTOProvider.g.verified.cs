//HintName: G.Models.CreateGoogleCalendarOAuth2AuthorizationCredentialDTOProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateGoogleCalendarOAuth2AuthorizationCredentialDTOProvider
    {
        /// <summary>
        /// 
        /// </summary>
        GoogleCalendarOauth2Authorization,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateGoogleCalendarOAuth2AuthorizationCredentialDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateGoogleCalendarOAuth2AuthorizationCredentialDTOProvider value)
        {
            return value switch
            {
                CreateGoogleCalendarOAuth2AuthorizationCredentialDTOProvider.GoogleCalendarOauth2Authorization => "google.calendar.oauth2-authorization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateGoogleCalendarOAuth2AuthorizationCredentialDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "google.calendar.oauth2-authorization" => CreateGoogleCalendarOAuth2AuthorizationCredentialDTOProvider.GoogleCalendarOauth2Authorization,
                _ => null,
            };
        }
    }
}