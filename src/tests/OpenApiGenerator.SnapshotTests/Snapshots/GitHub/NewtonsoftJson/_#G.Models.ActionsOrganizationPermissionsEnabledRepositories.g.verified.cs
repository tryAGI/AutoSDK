//HintName: G.Models.ActionsOrganizationPermissionsEnabledRepositories.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The policy that controls the repositories in the organization that are allowed to run GitHub Actions.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ActionsOrganizationPermissionsEnabledRepositories
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
    public static class ActionsOrganizationPermissionsEnabledRepositoriesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActionsOrganizationPermissionsEnabledRepositories value)
        {
            return value switch
            {
                ActionsOrganizationPermissionsEnabledRepositories.All => "all",
                ActionsOrganizationPermissionsEnabledRepositories.None => "none",
                ActionsOrganizationPermissionsEnabledRepositories.Selected => "selected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActionsOrganizationPermissionsEnabledRepositories ToEnum(string value)
        {
            return value switch
            {
                "all" => ActionsOrganizationPermissionsEnabledRepositories.All,
                "none" => ActionsOrganizationPermissionsEnabledRepositories.None,
                "selected" => ActionsOrganizationPermissionsEnabledRepositories.Selected,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}