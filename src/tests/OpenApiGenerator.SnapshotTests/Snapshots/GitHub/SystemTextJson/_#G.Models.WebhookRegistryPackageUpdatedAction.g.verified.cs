//HintName: G.Models.WebhookRegistryPackageUpdatedAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookRegistryPackageUpdatedAction
    {
        /// <summary>
        /// 
        /// </summary>
        Updated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookRegistryPackageUpdatedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookRegistryPackageUpdatedAction value)
        {
            return value switch
            {
                WebhookRegistryPackageUpdatedAction.Updated => "updated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookRegistryPackageUpdatedAction ToEnum(string value)
        {
            return value switch
            {
                "updated" => WebhookRegistryPackageUpdatedAction.Updated,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}