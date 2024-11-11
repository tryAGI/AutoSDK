//HintName: G.Models.BanUserResponseDataItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BanUserResponseDataItem
    {
        /// <summary>
        /// The broadcaster whose chat room the user was banned from chatting in.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("broadcaster_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string BroadcasterId { get; set; } = default!;

        /// <summary>
        /// The moderator that banned or put the user in the timeout.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("moderator_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ModeratorId { get; set; } = default!;

        /// <summary>
        /// The user that was banned or put in a timeout.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string UserId { get; set; } = default!;

        /// <summary>
        /// The UTC date and time (in RFC3339 format) that the ban or timeout was placed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// The UTC date and time (in RFC3339 format) that the timeout will end. Is **null** if the user was banned instead of being put in a timeout.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_time", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime? EndTime { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BanUserResponseDataItem" /> class.
        /// </summary>
        /// <param name="broadcasterId">
        /// The broadcaster whose chat room the user was banned from chatting in.
        /// </param>
        /// <param name="moderatorId">
        /// The moderator that banned or put the user in the timeout.
        /// </param>
        /// <param name="userId">
        /// The user that was banned or put in a timeout.
        /// </param>
        /// <param name="createdAt">
        /// The UTC date and time (in RFC3339 format) that the ban or timeout was placed.
        /// </param>
        /// <param name="endTime">
        /// The UTC date and time (in RFC3339 format) that the timeout will end. Is **null** if the user was banned instead of being put in a timeout.
        /// </param>
        public BanUserResponseDataItem(
            string broadcasterId,
            string moderatorId,
            string userId,
            global::System.DateTime createdAt,
            global::System.DateTime? endTime)
        {
            this.BroadcasterId = broadcasterId ?? throw new global::System.ArgumentNullException(nameof(broadcasterId));
            this.ModeratorId = moderatorId ?? throw new global::System.ArgumentNullException(nameof(moderatorId));
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.CreatedAt = createdAt;
            this.EndTime = endTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BanUserResponseDataItem" /> class.
        /// </summary>
        public BanUserResponseDataItem()
        {
        }
    }
}