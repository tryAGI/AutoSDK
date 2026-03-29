//HintName: G.Models.GoogleCalendarOAuth2ClientCredentialProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GoogleCalendarOAuth2ClientCredentialProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="google.calendar.oauth2-client")]
        GoogleCalendarOauth2Client,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GoogleCalendarOAuth2ClientCredentialProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GoogleCalendarOAuth2ClientCredentialProvider value)
        {
            return value switch
            {
                GoogleCalendarOAuth2ClientCredentialProvider.GoogleCalendarOauth2Client => "google.calendar.oauth2-client",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GoogleCalendarOAuth2ClientCredentialProvider? ToEnum(string value)
        {
            return value switch
            {
                "google.calendar.oauth2-client" => GoogleCalendarOAuth2ClientCredentialProvider.GoogleCalendarOauth2Client,
                _ => null,
            };
        }
    }
}