//HintName: G.Models.OverloadedErrorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: overloaded_error
    /// </summary>
    public enum OverloadedErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        OverloadedError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OverloadedErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OverloadedErrorType value)
        {
            return value switch
            {
                OverloadedErrorType.OverloadedError => "overloaded_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OverloadedErrorType? ToEnum(string value)
        {
            return value switch
            {
                "overloaded_error" => OverloadedErrorType.OverloadedError,
                _ => null,
            };
        }
    }
}