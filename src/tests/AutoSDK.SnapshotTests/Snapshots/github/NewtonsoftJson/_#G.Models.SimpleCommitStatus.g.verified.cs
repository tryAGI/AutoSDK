//HintName: G.Models.SimpleCommitStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SimpleCommitStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

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
        [global::Newtonsoft.Json.JsonProperty("context", Required = global::Newtonsoft.Json.Required.Always)]
        public string Context { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("target_url")]
        public string? TargetUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("required")]
        public bool? Required { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("avatar_url")]
        public string? AvatarUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleCommitStatus" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nodeId"></param>
        /// <param name="state"></param>
        /// <param name="context"></param>
        /// <param name="url"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="description"></param>
        /// <param name="targetUrl"></param>
        /// <param name="required"></param>
        /// <param name="avatarUrl"></param>
        public SimpleCommitStatus(
            int id,
            string nodeId,
            string state,
            string context,
            string url,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? description,
            string? targetUrl,
            bool? required,
            string? avatarUrl)
        {
            this.Description = description;
            this.Id = id;
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.State = state ?? throw new global::System.ArgumentNullException(nameof(state));
            this.Context = context ?? throw new global::System.ArgumentNullException(nameof(context));
            this.TargetUrl = targetUrl;
            this.Required = required;
            this.AvatarUrl = avatarUrl;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleCommitStatus" /> class.
        /// </summary>
        public SimpleCommitStatus()
        {
        }
    }
}