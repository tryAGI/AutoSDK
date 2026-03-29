//HintName: G.Models.GoogleCalendarOAuth2AuthorizationCredentialProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GoogleCalendarOAuth2AuthorizationCredentialProvider
    {
        /// <summary>
        /// 
        /// </summary>
        GoogleCalendarOauth2Authorization,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GoogleCalendarOAuth2AuthorizationCredentialProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GoogleCalendarOAuth2AuthorizationCredentialProvider value)
        {
            return value switch
            {
                GoogleCalendarOAuth2AuthorizationCredentialProvider.GoogleCalendarOauth2Authorization => "google.calendar.oauth2-authorization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GoogleCalendarOAuth2AuthorizationCredentialProvider? ToEnum(string value)
        {
            return value switch
            {
                "google.calendar.oauth2-authorization" => GoogleCalendarOAuth2AuthorizationCredentialProvider.GoogleCalendarOauth2Authorization,
                _ => null,
            };
        }
    }
}