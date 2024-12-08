//HintName: G.Models.AuthenticationErrorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: authentication_error
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AuthenticationErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="authentication_error")]
        AuthenticationError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AuthenticationErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AuthenticationErrorType value)
        {
            return value switch
            {
                AuthenticationErrorType.AuthenticationError => "authentication_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AuthenticationErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authentication_error" => AuthenticationErrorType.AuthenticationError,
                _ => null,
            };
        }
    }
}