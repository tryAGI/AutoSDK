//HintName: G.Models.GetOrgOwnerProjectByNanoIdResponseWebhookVersion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Payload format version for Pusher real-time events only. For webhook configuration, use GET /api/v3/webhook_subscriptions.<br/>
    /// Example: V2
    /// </summary>
    public enum GetOrgOwnerProjectByNanoIdResponseWebhookVersion
    {
        /// <summary>
        /// 
        /// </summary>
        V1,
        /// <summary>
        /// 
        /// </summary>
        V2,
        /// <summary>
        /// 
        /// </summary>
        V3,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetOrgOwnerProjectByNanoIdResponseWebhookVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrgOwnerProjectByNanoIdResponseWebhookVersion value)
        {
            return value switch
            {
                GetOrgOwnerProjectByNanoIdResponseWebhookVersion.V1 => "V1",
                GetOrgOwnerProjectByNanoIdResponseWebhookVersion.V2 => "V2",
                GetOrgOwnerProjectByNanoIdResponseWebhookVersion.V3 => "V3",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrgOwnerProjectByNanoIdResponseWebhookVersion? ToEnum(string value)
        {
            return value switch
            {
                "V1" => GetOrgOwnerProjectByNanoIdResponseWebhookVersion.V1,
                "V2" => GetOrgOwnerProjectByNanoIdResponseWebhookVersion.V2,
                "V3" => GetOrgOwnerProjectByNanoIdResponseWebhookVersion.V3,
                _ => null,
            };
        }
    }
}