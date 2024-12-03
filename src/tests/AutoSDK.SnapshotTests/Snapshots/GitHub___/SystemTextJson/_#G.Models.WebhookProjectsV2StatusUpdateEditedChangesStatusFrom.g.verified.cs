//HintName: G.Models.WebhookProjectsV2StatusUpdateEditedChangesStatusFrom.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookProjectsV2StatusUpdateEditedChangesStatusFrom
    {
        /// <summary>
        /// 
        /// </summary>
        INACTIVE,
        /// <summary>
        /// 
        /// </summary>
        ONTRACK,
        /// <summary>
        /// 
        /// </summary>
        ATRISK,
        /// <summary>
        /// 
        /// </summary>
        OFFTRACK,
        /// <summary>
        /// 
        /// </summary>
        COMPLETE,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookProjectsV2StatusUpdateEditedChangesStatusFromExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookProjectsV2StatusUpdateEditedChangesStatusFrom value)
        {
            return value switch
            {
                WebhookProjectsV2StatusUpdateEditedChangesStatusFrom.INACTIVE => "INACTIVE",
                WebhookProjectsV2StatusUpdateEditedChangesStatusFrom.ONTRACK => "ON_TRACK",
                WebhookProjectsV2StatusUpdateEditedChangesStatusFrom.ATRISK => "AT_RISK",
                WebhookProjectsV2StatusUpdateEditedChangesStatusFrom.OFFTRACK => "OFF_TRACK",
                WebhookProjectsV2StatusUpdateEditedChangesStatusFrom.COMPLETE => "COMPLETE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookProjectsV2StatusUpdateEditedChangesStatusFrom? ToEnum(string value)
        {
            return value switch
            {
                "INACTIVE" => WebhookProjectsV2StatusUpdateEditedChangesStatusFrom.INACTIVE,
                "ON_TRACK" => WebhookProjectsV2StatusUpdateEditedChangesStatusFrom.ONTRACK,
                "AT_RISK" => WebhookProjectsV2StatusUpdateEditedChangesStatusFrom.ATRISK,
                "OFF_TRACK" => WebhookProjectsV2StatusUpdateEditedChangesStatusFrom.OFFTRACK,
                "COMPLETE" => WebhookProjectsV2StatusUpdateEditedChangesStatusFrom.COMPLETE,
                _ => null,
            };
        }
    }
}