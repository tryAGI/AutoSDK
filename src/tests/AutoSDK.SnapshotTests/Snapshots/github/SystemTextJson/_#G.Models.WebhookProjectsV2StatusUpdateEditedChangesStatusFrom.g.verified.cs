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
        AtRisk,
        /// <summary>
        /// 
        /// </summary>
        Complete,
        /// <summary>
        /// 
        /// </summary>
        Inactive,
        /// <summary>
        /// 
        /// </summary>
        OffTrack,
        /// <summary>
        /// 
        /// </summary>
        OnTrack,
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
                WebhookProjectsV2StatusUpdateEditedChangesStatusFrom.AtRisk => "AT_RISK",
                WebhookProjectsV2StatusUpdateEditedChangesStatusFrom.Complete => "COMPLETE",
                WebhookProjectsV2StatusUpdateEditedChangesStatusFrom.Inactive => "INACTIVE",
                WebhookProjectsV2StatusUpdateEditedChangesStatusFrom.OffTrack => "OFF_TRACK",
                WebhookProjectsV2StatusUpdateEditedChangesStatusFrom.OnTrack => "ON_TRACK",
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
                "AT_RISK" => WebhookProjectsV2StatusUpdateEditedChangesStatusFrom.AtRisk,
                "COMPLETE" => WebhookProjectsV2StatusUpdateEditedChangesStatusFrom.Complete,
                "INACTIVE" => WebhookProjectsV2StatusUpdateEditedChangesStatusFrom.Inactive,
                "OFF_TRACK" => WebhookProjectsV2StatusUpdateEditedChangesStatusFrom.OffTrack,
                "ON_TRACK" => WebhookProjectsV2StatusUpdateEditedChangesStatusFrom.OnTrack,
                _ => null,
            };
        }
    }
}