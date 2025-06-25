//HintName: G.Models.UserRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// `owner` or `reader`
    /// </summary>
    public enum UserRole
    {
        /// <summary>
        /// 
        /// </summary>
        Owner,
        /// <summary>
        /// 
        /// </summary>
        Reader,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserRole value)
        {
            return value switch
            {
                UserRole.Owner => "owner",
                UserRole.Reader => "reader",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserRole? ToEnum(string value)
        {
            return value switch
            {
                "owner" => UserRole.Owner,
                "reader" => UserRole.Reader,
                _ => null,
            };
        }
    }
}