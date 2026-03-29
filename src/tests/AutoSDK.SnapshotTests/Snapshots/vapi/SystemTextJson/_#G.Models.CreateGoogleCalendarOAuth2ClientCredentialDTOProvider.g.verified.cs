//HintName: G.Models.CreateGoogleCalendarOAuth2ClientCredentialDTOProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateGoogleCalendarOAuth2ClientCredentialDTOProvider
    {
        /// <summary>
        /// 
        /// </summary>
        GoogleCalendarOauth2Client,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateGoogleCalendarOAuth2ClientCredentialDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateGoogleCalendarOAuth2ClientCredentialDTOProvider value)
        {
            return value switch
            {
                CreateGoogleCalendarOAuth2ClientCredentialDTOProvider.GoogleCalendarOauth2Client => "google.calendar.oauth2-client",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateGoogleCalendarOAuth2ClientCredentialDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "google.calendar.oauth2-client" => CreateGoogleCalendarOAuth2ClientCredentialDTOProvider.GoogleCalendarOauth2Client,
                _ => null,
            };
        }
    }
}