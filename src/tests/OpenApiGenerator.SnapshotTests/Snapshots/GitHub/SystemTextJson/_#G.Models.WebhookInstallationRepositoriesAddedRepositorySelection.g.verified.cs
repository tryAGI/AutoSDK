//HintName: G.Models.WebhookInstallationRepositoriesAddedRepositorySelection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Describe whether all repositories have been selected or there's a selection involved
    /// </summary>
    public enum WebhookInstallationRepositoriesAddedRepositorySelection
    {
        /// <summary>
        /// 
        /// </summary>
        All,
        /// <summary>
        /// 
        /// </summary>
        Selected,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookInstallationRepositoriesAddedRepositorySelectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookInstallationRepositoriesAddedRepositorySelection value)
        {
            return value switch
            {
                WebhookInstallationRepositoriesAddedRepositorySelection.All => "all",
                WebhookInstallationRepositoriesAddedRepositorySelection.Selected => "selected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookInstallationRepositoriesAddedRepositorySelection ToEnum(string value)
        {
            return value switch
            {
                "all" => WebhookInstallationRepositoriesAddedRepositorySelection.All,
                "selected" => WebhookInstallationRepositoriesAddedRepositorySelection.Selected,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}