//HintName: G.Models.ActionsWorkflowAccessToRepositoryAccessLevel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Defines the level of access that workflows outside of the repository have to actions and reusable workflows within the<br/>
    /// repository.<br/>
    /// `none` means the access is only possible from workflows in this repository. `user` level access allows sharing across user owned private repositories only. `organization` level access allows sharing across the organization.
    /// </summary>
    public enum ActionsWorkflowAccessToRepositoryAccessLevel
    {
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        User,
        /// <summary>
        /// 
        /// </summary>
        Organization,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ActionsWorkflowAccessToRepositoryAccessLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActionsWorkflowAccessToRepositoryAccessLevel value)
        {
            return value switch
            {
                ActionsWorkflowAccessToRepositoryAccessLevel.None => "none",
                ActionsWorkflowAccessToRepositoryAccessLevel.User => "user",
                ActionsWorkflowAccessToRepositoryAccessLevel.Organization => "organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActionsWorkflowAccessToRepositoryAccessLevel? ToEnum(string value)
        {
            return value switch
            {
                "none" => ActionsWorkflowAccessToRepositoryAccessLevel.None,
                "user" => ActionsWorkflowAccessToRepositoryAccessLevel.User,
                "organization" => ActionsWorkflowAccessToRepositoryAccessLevel.Organization,
                _ => null,
            };
        }
    }
}