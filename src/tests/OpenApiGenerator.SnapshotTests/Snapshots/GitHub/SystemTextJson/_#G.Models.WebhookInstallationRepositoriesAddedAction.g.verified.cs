//HintName: G.Models.WebhookInstallationRepositoriesAddedAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookInstallationRepositoriesAddedAction
    {
        /// <summary>
        /// 
        /// </summary>
        Added,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookInstallationRepositoriesAddedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookInstallationRepositoriesAddedAction value)
        {
            return value switch
            {
                WebhookInstallationRepositoriesAddedAction.Added => "added",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookInstallationRepositoriesAddedAction ToEnum(string value)
        {
            return value switch
            {
                "added" => WebhookInstallationRepositoriesAddedAction.Added,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}