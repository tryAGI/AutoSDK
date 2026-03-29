//HintName: G.Models.GetOrgOwnerProjectListResponseDataItemWebhookVersion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Payload format version for Pusher real-time events only. For webhook configuration, use GET /api/v3/webhook_subscriptions.<br/>
    /// Example: V2
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetOrgOwnerProjectListResponseDataItemWebhookVersion
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="V1")]
        V1,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="V2")]
        V2,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="V3")]
        V3,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetOrgOwnerProjectListResponseDataItemWebhookVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrgOwnerProjectListResponseDataItemWebhookVersion value)
        {
            return value switch
            {
                GetOrgOwnerProjectListResponseDataItemWebhookVersion.V1 => "V1",
                GetOrgOwnerProjectListResponseDataItemWebhookVersion.V2 => "V2",
                GetOrgOwnerProjectListResponseDataItemWebhookVersion.V3 => "V3",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrgOwnerProjectListResponseDataItemWebhookVersion? ToEnum(string value)
        {
            return value switch
            {
                "V1" => GetOrgOwnerProjectListResponseDataItemWebhookVersion.V1,
                "V2" => GetOrgOwnerProjectListResponseDataItemWebhookVersion.V2,
                "V3" => GetOrgOwnerProjectListResponseDataItemWebhookVersion.V3,
                _ => null,
            };
        }
    }
}