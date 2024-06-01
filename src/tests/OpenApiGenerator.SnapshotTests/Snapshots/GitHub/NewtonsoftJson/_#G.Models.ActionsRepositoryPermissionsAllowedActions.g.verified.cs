//HintName: G.Models.ActionsRepositoryPermissionsAllowedActions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The permissions policy that controls the actions and reusable workflows that are allowed to run.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ActionsRepositoryPermissionsAllowedActions
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
    public static class ActionsRepositoryPermissionsAllowedActionsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActionsRepositoryPermissionsAllowedActions value)
        {
            return value switch
            {
                ActionsRepositoryPermissionsAllowedActions.All => "all",
                ActionsRepositoryPermissionsAllowedActions.LocalOnly => "local_only",
                ActionsRepositoryPermissionsAllowedActions.Selected => "selected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActionsRepositoryPermissionsAllowedActions ToEnum(string value)
        {
            return value switch
            {
                "all" => ActionsRepositoryPermissionsAllowedActions.All,
                "local_only" => ActionsRepositoryPermissionsAllowedActions.LocalOnly,
                "selected" => ActionsRepositoryPermissionsAllowedActions.Selected,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}