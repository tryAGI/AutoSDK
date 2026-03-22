//HintName: G.Models.WebhookProjectsV2StatusUpdateEditedChangesStatusTo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookProjectsV2StatusUpdateEditedChangesStatusTo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="AT_RISK")]
        AtRisk,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="COMPLETE")]
        Complete,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="INACTIVE")]
        Inactive,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="OFF_TRACK")]
        OffTrack,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ON_TRACK")]
        OnTrack,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookProjectsV2StatusUpdateEditedChangesStatusToExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookProjectsV2StatusUpdateEditedChangesStatusTo value)
        {
            return value switch
            {
                WebhookProjectsV2StatusUpdateEditedChangesStatusTo.AtRisk => "AT_RISK",
                WebhookProjectsV2StatusUpdateEditedChangesStatusTo.Complete => "COMPLETE",
                WebhookProjectsV2StatusUpdateEditedChangesStatusTo.Inactive => "INACTIVE",
                WebhookProjectsV2StatusUpdateEditedChangesStatusTo.OffTrack => "OFF_TRACK",
                WebhookProjectsV2StatusUpdateEditedChangesStatusTo.OnTrack => "ON_TRACK",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookProjectsV2StatusUpdateEditedChangesStatusTo? ToEnum(string value)
        {
            return value switch
            {
                "AT_RISK" => WebhookProjectsV2StatusUpdateEditedChangesStatusTo.AtRisk,
                "COMPLETE" => WebhookProjectsV2StatusUpdateEditedChangesStatusTo.Complete,
                "INACTIVE" => WebhookProjectsV2StatusUpdateEditedChangesStatusTo.Inactive,
                "OFF_TRACK" => WebhookProjectsV2StatusUpdateEditedChangesStatusTo.OffTrack,
                "ON_TRACK" => WebhookProjectsV2StatusUpdateEditedChangesStatusTo.OnTrack,
                _ => null,
            };
        }
    }
}