//HintName: G.Models.ActionsCreateOrUpdateOrgSecretRequestVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Which type of organization repositories have access to the organization secret. `selected` means only the repositories specified by `selected_repository_ids` can access the secret.
    /// </summary>
    public enum ActionsCreateOrUpdateOrgSecretRequestVisibility
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
    public static class ActionsCreateOrUpdateOrgSecretRequestVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActionsCreateOrUpdateOrgSecretRequestVisibility value)
        {
            return value switch
            {
                ActionsCreateOrUpdateOrgSecretRequestVisibility.All => "all",
                ActionsCreateOrUpdateOrgSecretRequestVisibility.Private => "private",
                ActionsCreateOrUpdateOrgSecretRequestVisibility.Selected => "selected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActionsCreateOrUpdateOrgSecretRequestVisibility ToEnum(string value)
        {
            return value switch
            {
                "all" => ActionsCreateOrUpdateOrgSecretRequestVisibility.All,
                "private" => ActionsCreateOrUpdateOrgSecretRequestVisibility.Private,
                "selected" => ActionsCreateOrUpdateOrgSecretRequestVisibility.Selected,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}