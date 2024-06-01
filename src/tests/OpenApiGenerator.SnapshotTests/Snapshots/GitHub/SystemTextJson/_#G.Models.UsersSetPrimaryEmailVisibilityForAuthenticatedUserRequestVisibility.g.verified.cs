//HintName: G.Models.UsersSetPrimaryEmailVisibilityForAuthenticatedUserRequestVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Denotes whether an email is publicly visible.
    /// </summary>
    public enum UsersSetPrimaryEmailVisibilityForAuthenticatedUserRequestVisibility
    {
        /// <summary>
        /// 
        /// </summary>
        Public,
        /// <summary>
        /// 
        /// </summary>
        Private,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UsersSetPrimaryEmailVisibilityForAuthenticatedUserRequestVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UsersSetPrimaryEmailVisibilityForAuthenticatedUserRequestVisibility value)
        {
            return value switch
            {
                UsersSetPrimaryEmailVisibilityForAuthenticatedUserRequestVisibility.Public => "public",
                UsersSetPrimaryEmailVisibilityForAuthenticatedUserRequestVisibility.Private => "private",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UsersSetPrimaryEmailVisibilityForAuthenticatedUserRequestVisibility ToEnum(string value)
        {
            return value switch
            {
                "public" => UsersSetPrimaryEmailVisibilityForAuthenticatedUserRequestVisibility.Public,
                "private" => UsersSetPrimaryEmailVisibilityForAuthenticatedUserRequestVisibility.Private,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}