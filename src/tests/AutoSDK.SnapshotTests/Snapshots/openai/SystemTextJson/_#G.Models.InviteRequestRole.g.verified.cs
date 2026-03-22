//HintName: G.Models.InviteRequestRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// `owner` or `reader`
    /// </summary>
    public enum InviteRequestRole
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
    public static class InviteRequestRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InviteRequestRole value)
        {
            return value switch
            {
                InviteRequestRole.Owner => "owner",
                InviteRequestRole.Reader => "reader",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InviteRequestRole? ToEnum(string value)
        {
            return value switch
            {
                "owner" => InviteRequestRole.Owner,
                "reader" => InviteRequestRole.Reader,
                _ => null,
            };
        }
    }
}