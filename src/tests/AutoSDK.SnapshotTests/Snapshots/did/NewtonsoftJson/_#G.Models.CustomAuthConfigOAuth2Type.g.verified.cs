//HintName: G.Models.CustomAuthConfigOAuth2Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CustomAuthConfigOAuth2Type
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
    public static class CustomAuthConfigOAuth2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomAuthConfigOAuth2Type value)
        {
            return value switch
            {
                CustomAuthConfigOAuth2Type.Oauth2 => "oauth2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomAuthConfigOAuth2Type? ToEnum(string value)
        {
            return value switch
            {
                "oauth2" => CustomAuthConfigOAuth2Type.Oauth2,
                _ => null,
            };
        }
    }
}