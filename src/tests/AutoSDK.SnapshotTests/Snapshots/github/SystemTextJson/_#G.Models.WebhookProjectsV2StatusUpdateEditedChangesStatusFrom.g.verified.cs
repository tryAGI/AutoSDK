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
        Inactive,
        /// <summary>
        /// 
        /// </summary>
        OnTrack,
        /// <summary>
        /// 
        /// </summary>
        AtRisk,
        /// <summary>
        /// 
        /// </summary>
        OffTrack,
        /// <summary>
        /// 
        /// </summary>
        Complete,
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
                WebhookProjectsV2StatusUpdateEditedChangesStatusFrom.Inactive => "INACTIVE",
                WebhookProjectsV2StatusUpdateEditedChangesStatusFrom.OnTrack => "ON_TRACK",
                WebhookProjectsV2StatusUpdateEditedChangesStatusFrom.AtRisk => "AT_RISK",
                WebhookProjectsV2StatusUpdateEditedChangesStatusFrom.OffTrack => "OFF_TRACK",
                WebhookProjectsV2StatusUpdateEditedChangesStatusFrom.Complete => "COMPLETE",
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
                "INACTIVE" => WebhookProjectsV2StatusUpdateEditedChangesStatusFrom.Inactive,
                "ON_TRACK" => WebhookProjectsV2StatusUpdateEditedChangesStatusFrom.OnTrack,
                "AT_RISK" => WebhookProjectsV2StatusUpdateEditedChangesStatusFrom.AtRisk,
                "OFF_TRACK" => WebhookProjectsV2StatusUpdateEditedChangesStatusFrom.OffTrack,
                "COMPLETE" => WebhookProjectsV2StatusUpdateEditedChangesStatusFrom.Complete,
                _ => null,
            };
        }
    }
}