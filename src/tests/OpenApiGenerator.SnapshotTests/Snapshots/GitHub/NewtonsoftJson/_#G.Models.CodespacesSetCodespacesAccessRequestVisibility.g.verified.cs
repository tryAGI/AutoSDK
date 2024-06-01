//HintName: G.Models.CodespacesSetCodespacesAccessRequestVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Which users can access codespaces in the organization. `disabled` means that no users can access codespaces in the organization.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CodespacesSetCodespacesAccessRequestVisibility
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="disabled")]
        Disabled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="selected_members")]
        SelectedMembers,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="all_members")]
        AllMembers,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="all_members_and_outside_collaborators")]
        AllMembersAndOutsideCollaborators,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodespacesSetCodespacesAccessRequestVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodespacesSetCodespacesAccessRequestVisibility value)
        {
            return value switch
            {
                CodespacesSetCodespacesAccessRequestVisibility.Disabled => "disabled",
                CodespacesSetCodespacesAccessRequestVisibility.SelectedMembers => "selected_members",
                CodespacesSetCodespacesAccessRequestVisibility.AllMembers => "all_members",
                CodespacesSetCodespacesAccessRequestVisibility.AllMembersAndOutsideCollaborators => "all_members_and_outside_collaborators",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodespacesSetCodespacesAccessRequestVisibility ToEnum(string value)
        {
            return value switch
            {
                "disabled" => CodespacesSetCodespacesAccessRequestVisibility.Disabled,
                "selected_members" => CodespacesSetCodespacesAccessRequestVisibility.SelectedMembers,
                "all_members" => CodespacesSetCodespacesAccessRequestVisibility.AllMembers,
                "all_members_and_outside_collaborators" => CodespacesSetCodespacesAccessRequestVisibility.AllMembersAndOutsideCollaborators,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}