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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Lifecycle status of an avatar training workflow.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PostTrainingResponseItemStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PostTrainingResponseItemStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatar_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AvatarName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slack_updates_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SlackUpdatesUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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