//HintName: G.Models.Status.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of a commit.
    /// </summary>
    public sealed partial class Status
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatar_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? AvatarUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? TargetUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Context { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UpdatedAt { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creator")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.NullableSimpleUser? Creator { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Status" /> class.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="avatarUrl"></param>
        /// <param name="id"></param>
        /// <param name="nodeId"></param>
        /// <param name="state"></param>
        /// <param name="description"></param>
        /// <param name="targetUrl"></param>
        /// <param name="context"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="creator">
        /// A GitHub user.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public Status(
            string url,
            string? avatarUrl,
            int id,
            string nodeId,
            string state,
            string? description,
            string? targetUrl,
            string context,
            string createdAt,
            string updatedAt,
            global::G.NullableSimpleUser? creator)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.AvatarUrl = avatarUrl ?? throw new global::System.ArgumentNullException(nameof(avatarUrl));
            this.Id = id;
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.State = state ?? throw new global::System.ArgumentNullException(nameof(state));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.TargetUrl = targetUrl ?? throw new global::System.ArgumentNullException(nameof(targetUrl));
            this.Context = context ?? throw new global::System.ArgumentNullException(nameof(context));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.UpdatedAt = updatedAt ?? throw new global::System.ArgumentNullException(nameof(updatedAt));
            this.Creator = creator ?? throw new global::System.ArgumentNullException(nameof(creator));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Status" /> class.
        /// </summary>
        public Status()
        {
        }
    }
}