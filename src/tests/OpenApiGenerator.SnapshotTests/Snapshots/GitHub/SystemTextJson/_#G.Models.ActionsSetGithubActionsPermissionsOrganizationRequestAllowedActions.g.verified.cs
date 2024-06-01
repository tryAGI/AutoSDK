//HintName: G.Models.ActionsSetGithubActionsPermissionsOrganizationRequestAllowedActions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The permissions policy that controls the actions and reusable workflows that are allowed to run.
    /// </summary>
    public enum ActionsSetGithubActionsPermissionsOrganizationRequestAllowedActions
    {
        /// <summary>
        /// 
        /// </summary>
        All,
        /// <summary>
        /// 
        /// </summary>
        LocalOnly,
        /// <summary>
        /// 
        /// </summary>
        Selected,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ActionsSetGithubActionsPermissionsOrganizationRequestAllowedActionsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActionsSetGithubActionsPermissionsOrganizationRequestAllowedActions value)
        {
            return value switch
            {
                ActionsSetGithubActionsPermissionsOrganizationRequestAllowedActions.All => "all",
                ActionsSetGithubActionsPermissionsOrganizationRequestAllowedActions.LocalOnly => "local_only",
                ActionsSetGithubActionsPermissionsOrganizationRequestAllowedActions.Selected => "selected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActionsSetGithubActionsPermissionsOrganizationRequestAllowedActions ToEnum(string value)
        {
            return value switch
            {
                "all" => ActionsSetGithubActionsPermissionsOrganizationRequestAllowedActions.All,
                "local_only" => ActionsSetGithubActionsPermissionsOrganizationRequestAllowedActions.LocalOnly,
                "selected" => ActionsSetGithubActionsPermissionsOrganizationRequestAllowedActions.Selected,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}