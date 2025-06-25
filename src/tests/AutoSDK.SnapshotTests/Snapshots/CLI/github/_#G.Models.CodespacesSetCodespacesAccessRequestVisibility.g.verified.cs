//HintName: G.Models.CodespacesSetCodespacesAccessRequestVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Which users can access codespaces in the organization. `disabled` means that no users can access codespaces in the organization.
    /// </summary>
    public enum CodespacesSetCodespacesAccessRequestVisibility
    {
        /// <summary>
        /// 
        /// </summary>
        Disabled,
        /// <summary>
        /// 
        /// </summary>
        SelectedMembers,
        /// <summary>
        /// 
        /// </summary>
        AllMembers,
        /// <summary>
        /// 
        /// </summary>
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
        public static CodespacesSetCodespacesAccessRequestVisibility? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => CodespacesSetCodespacesAccessRequestVisibility.Disabled,
                "selected_members" => CodespacesSetCodespacesAccessRequestVisibility.SelectedMembers,
                "all_members" => CodespacesSetCodespacesAccessRequestVisibility.AllMembers,
                "all_members_and_outside_collaborators" => CodespacesSetCodespacesAccessRequestVisibility.AllMembersAndOutsideCollaborators,
                _ => null,
            };
        }
    }
}