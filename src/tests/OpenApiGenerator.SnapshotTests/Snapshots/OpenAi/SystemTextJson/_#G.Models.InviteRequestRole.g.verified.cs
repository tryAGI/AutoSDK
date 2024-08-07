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
        Reader,
        /// <summary>
        /// 
        /// </summary>
        Owner,
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
                InviteRequestRole.Reader => "reader",
                InviteRequestRole.Owner => "owner",
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
                "reader" => InviteRequestRole.Reader,
                "owner" => InviteRequestRole.Owner,
                _ => null,
            };
        }
    }
}