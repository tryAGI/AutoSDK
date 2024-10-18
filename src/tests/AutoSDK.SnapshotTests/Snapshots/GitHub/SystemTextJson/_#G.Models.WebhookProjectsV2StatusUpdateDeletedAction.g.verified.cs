//HintName: G.Models.WebhookProjectsV2StatusUpdateDeletedAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookProjectsV2StatusUpdateDeletedAction
    {
        /// <summary>
        /// 
        /// </summary>
        Deleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookProjectsV2StatusUpdateDeletedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookProjectsV2StatusUpdateDeletedAction value)
        {
            return value switch
            {
                WebhookProjectsV2StatusUpdateDeletedAction.Deleted => "deleted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookProjectsV2StatusUpdateDeletedAction? ToEnum(string value)
        {
            return value switch
            {
                "deleted" => WebhookProjectsV2StatusUpdateDeletedAction.Deleted,
                _ => null,
            };
        }
    }
}