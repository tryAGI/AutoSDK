//HintName: G.Models.CustomAuthOauth2ConfigType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CustomAuthOauth2ConfigType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="oauth2")]
        Oauth2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CustomAuthOauth2ConfigTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomAuthOauth2ConfigType value)
        {
            return value switch
            {
                CustomAuthOauth2ConfigType.Oauth2 => "oauth2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomAuthOauth2ConfigType? ToEnum(string value)
        {
            return value switch
            {
                "oauth2" => CustomAuthOauth2ConfigType.Oauth2,
                _ => null,
            };
        }
    }
}