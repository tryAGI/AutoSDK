//HintName: G.Models.WorkspaceInviteType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WorkspaceInviteType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="add")]
        Add,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="remove")]
        Remove,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="update")]
        Update,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkspaceInviteTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkspaceInviteType value)
        {
            return value switch
            {
                WorkspaceInviteType.Add => "add",
                WorkspaceInviteType.Remove => "remove",
                WorkspaceInviteType.Update => "update",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkspaceInviteType? ToEnum(string value)
        {
            return value switch
            {
                "add" => WorkspaceInviteType.Add,
                "remove" => WorkspaceInviteType.Remove,
                "update" => WorkspaceInviteType.Update,
                _ => null,
            };
        }
    }
}