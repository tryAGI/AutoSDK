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
        [global::System.Runtime.Serialization.EnumMember(Value="INACTIVE")]
        INACTIVE,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ON_TRACK")]
        ONTRACK,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="AT_RISK")]
        ATRISK,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="OFF_TRACK")]
        OFFTRACK,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="COMPLETE")]
        COMPLETE,
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
                WebhookProjectsV2StatusUpdateEditedChangesStatusTo.INACTIVE => "INACTIVE",
                WebhookProjectsV2StatusUpdateEditedChangesStatusTo.ONTRACK => "ON_TRACK",
                WebhookProjectsV2StatusUpdateEditedChangesStatusTo.ATRISK => "AT_RISK",
                WebhookProjectsV2StatusUpdateEditedChangesStatusTo.OFFTRACK => "OFF_TRACK",
                WebhookProjectsV2StatusUpdateEditedChangesStatusTo.COMPLETE => "COMPLETE",
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
                "INACTIVE" => WebhookProjectsV2StatusUpdateEditedChangesStatusTo.INACTIVE,
                "ON_TRACK" => WebhookProjectsV2StatusUpdateEditedChangesStatusTo.ONTRACK,
                "AT_RISK" => WebhookProjectsV2StatusUpdateEditedChangesStatusTo.ATRISK,
                "OFF_TRACK" => WebhookProjectsV2StatusUpdateEditedChangesStatusTo.OFFTRACK,
                "COMPLETE" => WebhookProjectsV2StatusUpdateEditedChangesStatusTo.COMPLETE,
                _ => null,
            };
        }
    }
}