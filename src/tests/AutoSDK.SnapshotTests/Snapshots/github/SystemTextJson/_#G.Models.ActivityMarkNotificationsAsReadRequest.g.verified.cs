//HintName: G.Models.ActivityMarkNotificationsAsReadRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActivityMarkNotificationsAsReadRequest
    {
        /// <summary>
        /// Describes the last point that notifications were checked. Anything updated since this time will not be marked as read. If you omit this parameter, all notifications are marked as read. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: `YYYY-MM-DDTHH:MM:SSZ`. Default: The current timestamp.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_read_at")]
        public global::System.DateTime? LastReadAt { get; set; }

        /// <summary>
        /// Whether the notification has been read.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("read")]
        public bool? Read { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityMarkNotificationsAsReadRequest" /> class.
        /// </summary>
        /// <param name="lastReadAt">
        /// Describes the last point that notifications were checked. Anything updated since this time will not be marked as read. If you omit this parameter, all notifications are marked as read. This is a timestamp in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format: `YYYY-MM-DDTHH:MM:SSZ`. Default: The current timestamp.
        /// </param>
        /// <param name="read">
        /// Whether the notification has been read.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ActivityMarkNotificationsAsReadRequest(
            global::System.DateTime? lastReadAt,
            bool? read)
        {
            this.LastReadAt = lastReadAt;
            this.Read = read;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityMarkNotificationsAsReadRequest" /> class.
        /// </summary>
        public ActivityMarkNotificationsAsReadRequest()
        {
        }
    }
}