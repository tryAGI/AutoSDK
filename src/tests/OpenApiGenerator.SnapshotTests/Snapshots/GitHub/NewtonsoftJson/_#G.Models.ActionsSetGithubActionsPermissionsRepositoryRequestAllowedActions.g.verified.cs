//HintName: G.Models.ActionsSetGithubActionsPermissionsRepositoryRequestAllowedActions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The permissions policy that controls the actions and reusable workflows that are allowed to run.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ActionsSetGithubActionsPermissionsRepositoryRequestAllowedActions
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="all")]
        All,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="local_only")]
        LocalOnly,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="selected")]
        Selected,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ActionsSetGithubActionsPermissionsRepositoryRequestAllowedActionsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActionsSetGithubActionsPermissionsRepositoryRequestAllowedActions value)
        {
            return value switch
            {
                ActionsSetGithubActionsPermissionsRepositoryRequestAllowedActions.All => "all",
                ActionsSetGithubActionsPermissionsRepositoryRequestAllowedActions.LocalOnly => "local_only",
                ActionsSetGithubActionsPermissionsRepositoryRequestAllowedActions.Selected => "selected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActionsSetGithubActionsPermissionsRepositoryRequestAllowedActions ToEnum(string value)
        {
            return value switch
            {
                "all" => ActionsSetGithubActionsPermissionsRepositoryRequestAllowedActions.All,
                "local_only" => ActionsSetGithubActionsPermissionsRepositoryRequestAllowedActions.LocalOnly,
                "selected" => ActionsSetGithubActionsPermissionsRepositoryRequestAllowedActions.Selected,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}