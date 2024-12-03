//HintName: G.Models.AuthTokenType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The token_type specifies the way the token is passed in the Authorization header. Valid values are "bearer", "basic", and "noscheme".<br/>
    /// Default Value: noscheme
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AuthTokenType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="bearer")]
        Bearer,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="basic")]
        Basic,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="noscheme")]
        Noscheme,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AuthTokenTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AuthTokenType value)
        {
            return value switch
            {
                AuthTokenType.Bearer => "bearer",
                AuthTokenType.Basic => "basic",
                AuthTokenType.Noscheme => "noscheme",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AuthTokenType? ToEnum(string value)
        {
            return value switch
            {
                "bearer" => AuthTokenType.Bearer,
                "basic" => AuthTokenType.Basic,
                "noscheme" => AuthTokenType.Noscheme,
                _ => null,
            };
        }
    }
}