//HintName: G.Models.PostTrainingResponseItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostTrainingResponseItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Lifecycle status of an avatar training workflow.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PostTrainingResponseItemStatus Status { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("avatar_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string AvatarName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("slack_updates_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string SlackUpdatesUrl { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostTrainingResponseItem" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="status">
        /// Lifecycle status of an avatar training workflow.
        /// </param>
        /// <param name="avatarName"></param>
        /// <param name="createdAt"></param>
        /// <param name="slackUpdatesUrl"></param>
        public PostTrainingResponseItem(
            string id,
            global::G.PostTrainingResponseItemStatus status,
            string avatarName,
            string createdAt,
            string slackUpdatesUrl)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Status = status;
            this.AvatarName = avatarName ?? throw new global::System.ArgumentNullException(nameof(avatarName));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.SlackUpdatesUrl = slackUpdatesUrl ?? throw new global::System.ArgumentNullException(nameof(slackUpdatesUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostTrainingResponseItem" /> class.
        /// </summary>
        public PostTrainingResponseItem()
        {
        }
    }
}