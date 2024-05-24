//HintName: G.Models.ActionsWorkflowAccessToRepositoryAccessLevel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Defines the level of access that workflows outside of the repository have to actions and reusable workflows within the
    /// repository.
    /// `none` means the access is only possible from workflows in this repository. `user` level access allows sharing across user owned private repositories only. `organization` level access allows sharing across the organization.
    /// </summary>
    public abstract class ActionsWorkflowAccessToRepositoryAccessLevel
    {
        /// <summary>
        /// 
        /// </summary>
        public const string None = "none";
        /// <summary>
        /// 
        /// </summary>
        public const string User = "user";
        /// <summary>
        /// 
        /// </summary>
        public const string Organization = "organization";
    }
}