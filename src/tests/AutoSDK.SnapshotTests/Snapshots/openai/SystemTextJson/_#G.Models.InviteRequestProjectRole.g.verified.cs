//HintName: G.Models.InviteRequestProjectRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Project membership role
    /// </summary>
    public enum InviteRequestProjectRole
    {
        /// <summary>
        /// 
        /// </summary>
        Member,
        /// <summary>
        /// 
        /// </summary>
        Owner,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InviteRequestProjectRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InviteRequestProjectRole value)
        {
            return value switch
            {
                InviteRequestProjectRole.Member => "member",
                InviteRequestProjectRole.Owner => "owner",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InviteRequestProjectRole? ToEnum(string value)
        {
            return value switch
            {
                "member" => InviteRequestProjectRole.Member,
                "owner" => InviteRequestProjectRole.Owner,
                _ => null,
            };
        }
    }
}