//HintName: G.Models.ActivityMarkRepoNotificationsAsReadRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActivityMarkRepoNotificationsAsReadRequest
    {
        /// <summary>
        /// Describes the last point that notifications were checked. Anything updated since this time will not be marked as read. If you omit this parameter, all notifications are marked as read. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: `YYYY-MM-DDTHH:MM:SSZ`. Default: The current timestamp.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_read_at")]
        public global::System.DateTime? LastReadAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityMarkRepoNotificationsAsReadRequest" /> class.
        /// </summary>
        /// <param name="lastReadAt">
        /// Describes the last point that notifications were checked. Anything updated since this time will not be marked as read. If you omit this parameter, all notifications are marked as read. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: `YYYY-MM-DDTHH:MM:SSZ`. Default: The current timestamp.
        /// </param>
        public ActivityMarkRepoNotificationsAsReadRequest(
            global::System.DateTime? lastReadAt)
        {
            this.LastReadAt = lastReadAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityMarkRepoNotificationsAsReadRequest" /> class.
        /// </summary>
        public ActivityMarkRepoNotificationsAsReadRequest()
        {
        }
    }
}