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
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("avatar_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string? AvatarUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("state", Required = global::Newtonsoft.Json.Required.Always)]
        public string State { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Description { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("target_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string? TargetUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("context", Required = global::Newtonsoft.Json.Required.Always)]
        public string Context { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string UpdatedAt { get; set; } = default!;

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("creator", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.NullableSimpleUser? Creator { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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