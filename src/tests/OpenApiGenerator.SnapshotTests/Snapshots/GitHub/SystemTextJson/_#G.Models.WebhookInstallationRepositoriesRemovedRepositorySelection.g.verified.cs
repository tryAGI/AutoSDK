//HintName: G.Models.WebhookInstallationRepositoriesRemovedRepositorySelection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Describe whether all repositories have been selected or there's a selection involved
    /// </summary>
    public enum WebhookInstallationRepositoriesRemovedRepositorySelection
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
    public static class WebhookInstallationRepositoriesRemovedRepositorySelectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookInstallationRepositoriesRemovedRepositorySelection value)
        {
            return value switch
            {
                WebhookInstallationRepositoriesRemovedRepositorySelection.All => "all",
                WebhookInstallationRepositoriesRemovedRepositorySelection.Selected => "selected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookInstallationRepositoriesRemovedRepositorySelection ToEnum(string value)
        {
            return value switch
            {
                "all" => WebhookInstallationRepositoriesRemovedRepositorySelection.All,
                "selected" => WebhookInstallationRepositoriesRemovedRepositorySelection.Selected,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}