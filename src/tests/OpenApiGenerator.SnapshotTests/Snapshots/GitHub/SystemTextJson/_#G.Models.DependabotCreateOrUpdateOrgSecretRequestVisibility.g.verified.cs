//HintName: G.Models.DependabotCreateOrUpdateOrgSecretRequestVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Which type of organization repositories have access to the organization secret. `selected` means only the repositories specified by `selected_repository_ids` can access the secret.
    /// </summary>
    public enum DependabotCreateOrUpdateOrgSecretRequestVisibility
    {
        /// <summary>
        /// 
        /// </summary>
        All,
        /// <summary>
        /// 
        /// </summary>
        Private,
        /// <summary>
        /// 
        /// </summary>
        Selected,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DependabotCreateOrUpdateOrgSecretRequestVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DependabotCreateOrUpdateOrgSecretRequestVisibility value)
        {
            return value switch
            {
                DependabotCreateOrUpdateOrgSecretRequestVisibility.All => "all",
                DependabotCreateOrUpdateOrgSecretRequestVisibility.Private => "private",
                DependabotCreateOrUpdateOrgSecretRequestVisibility.Selected => "selected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DependabotCreateOrUpdateOrgSecretRequestVisibility ToEnum(string value)
        {
            return value switch
            {
                "all" => DependabotCreateOrUpdateOrgSecretRequestVisibility.All,
                "private" => DependabotCreateOrUpdateOrgSecretRequestVisibility.Private,
                "selected" => DependabotCreateOrUpdateOrgSecretRequestVisibility.Selected,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}