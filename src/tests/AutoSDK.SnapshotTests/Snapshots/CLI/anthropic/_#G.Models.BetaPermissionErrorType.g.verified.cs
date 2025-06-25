//HintName: G.Models.BetaPermissionErrorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: permission_error
    /// </summary>
    public enum BetaPermissionErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        PermissionError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaPermissionErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaPermissionErrorType value)
        {
            return value switch
            {
                BetaPermissionErrorType.PermissionError => "permission_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaPermissionErrorType? ToEnum(string value)
        {
            return value switch
            {
                "permission_error" => BetaPermissionErrorType.PermissionError,
                _ => null,
            };
        }
    }
}