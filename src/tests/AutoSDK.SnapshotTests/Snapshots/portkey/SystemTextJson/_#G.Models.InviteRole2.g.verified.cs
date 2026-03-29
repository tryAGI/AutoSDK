//HintName: G.Models.InviteRole2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum InviteRole2
    {
        /// <summary>
        /// 
        /// </summary>
        Admin,
        /// <summary>
        /// 
        /// </summary>
        Member,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InviteRole2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InviteRole2 value)
        {
            return value switch
            {
                InviteRole2.Admin => "admin",
                InviteRole2.Member => "member",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InviteRole2? ToEnum(string value)
        {
            return value switch
            {
                "admin" => InviteRole2.Admin,
                "member" => InviteRole2.Member,
                _ => null,
            };
        }
    }
}