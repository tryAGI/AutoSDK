//HintName: G.Models.BetaAuthenticationErrorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: authentication_error
    /// </summary>
    public enum BetaAuthenticationErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        AuthenticationError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaAuthenticationErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaAuthenticationErrorType value)
        {
            return value switch
            {
                BetaAuthenticationErrorType.AuthenticationError => "authentication_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaAuthenticationErrorType? ToEnum(string value)
        {
            return value switch
            {
                "authentication_error" => BetaAuthenticationErrorType.AuthenticationError,
                _ => null,
            };
        }
    }
}