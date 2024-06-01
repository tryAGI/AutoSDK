//HintName: G.Models.WebhookDeployKeyDeletedAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookDeployKeyDeletedAction
    {
        /// <summary>
        /// 
        /// </summary>
        Deleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookDeployKeyDeletedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookDeployKeyDeletedAction value)
        {
            return value switch
            {
                WebhookDeployKeyDeletedAction.Deleted => "deleted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDeployKeyDeletedAction ToEnum(string value)
        {
            return value switch
            {
                "deleted" => WebhookDeployKeyDeletedAction.Deleted,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}