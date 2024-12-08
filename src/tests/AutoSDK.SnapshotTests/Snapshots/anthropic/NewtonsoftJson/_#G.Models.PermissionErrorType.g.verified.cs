//HintName: G.Models.PermissionErrorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: permission_error
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PermissionErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="permission_error")]
        PermissionError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PermissionErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PermissionErrorType value)
        {
            return value switch
            {
                PermissionErrorType.PermissionError => "permission_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PermissionErrorType? ToEnum(string value)
        {
            return value switch
            {
                "permission_error" => PermissionErrorType.PermissionError,
                _ => null,
            };
        }
    }
}