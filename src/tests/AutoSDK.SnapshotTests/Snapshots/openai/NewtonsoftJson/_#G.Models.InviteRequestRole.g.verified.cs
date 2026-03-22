//HintName: G.Models.InviteRequestRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// `owner` or `reader`
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum InviteRequestRole
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="owner")]
        Owner,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="reader")]
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