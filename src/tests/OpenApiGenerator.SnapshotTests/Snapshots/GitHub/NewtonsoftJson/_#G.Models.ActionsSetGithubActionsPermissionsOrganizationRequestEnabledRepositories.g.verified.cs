//HintName: G.Models.ActionsSetGithubActionsPermissionsOrganizationRequestEnabledRepositories.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The policy that controls the repositories in the organization that are allowed to run GitHub Actions.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ActionsSetGithubActionsPermissionsOrganizationRequestEnabledRepositories
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="all")]
        All,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="none")]
        None,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="selected")]
        Selected,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ActionsSetGithubActionsPermissionsOrganizationRequestEnabledRepositoriesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActionsSetGithubActionsPermissionsOrganizationRequestEnabledRepositories value)
        {
            return value switch
            {
                ActionsSetGithubActionsPermissionsOrganizationRequestEnabledRepositories.All => "all",
                ActionsSetGithubActionsPermissionsOrganizationRequestEnabledRepositories.None => "none",
                ActionsSetGithubActionsPermissionsOrganizationRequestEnabledRepositories.Selected => "selected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActionsSetGithubActionsPermissionsOrganizationRequestEnabledRepositories ToEnum(string value)
        {
            return value switch
            {
                "all" => ActionsSetGithubActionsPermissionsOrganizationRequestEnabledRepositories.All,
                "none" => ActionsSetGithubActionsPermissionsOrganizationRequestEnabledRepositories.None,
                "selected" => ActionsSetGithubActionsPermissionsOrganizationRequestEnabledRepositories.Selected,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}