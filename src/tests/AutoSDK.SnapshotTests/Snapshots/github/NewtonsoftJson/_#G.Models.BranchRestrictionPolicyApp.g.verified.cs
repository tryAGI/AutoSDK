//HintName: G.Models.BranchRestrictionPolicyApp.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BranchRestrictionPolicyApp
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("slug")]
        public string? Slug { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("node_id")]
        public string? NodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("owner")]
        public global::G.BranchRestrictionPolicyAppOwner? Owner { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("client_id")]
        public string? ClientId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("external_url")]
        public string? ExternalUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("html_url")]
        public string? HtmlUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("permissions")]
        public global::G.BranchRestrictionPolicyAppPermissions? Permissions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("events")]
        public global::System.Collections.Generic.IList<string>? Events { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BranchRestrictionPolicyApp" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="slug"></param>
        /// <param name="nodeId"></param>
        /// <param name="owner"></param>
        /// <param name="name"></param>
        /// <param name="clientId"></param>
        /// <param name="description"></param>
        /// <param name="externalUrl"></param>
        /// <param name="htmlUrl"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="permissions"></param>
        /// <param name="events"></param>
        public BranchRestrictionPolicyApp(
            int? id,
            string? slug,
            string? nodeId,
            global::G.BranchRestrictionPolicyAppOwner? owner,
            string? name,
            string? clientId,
            string? description,
            string? externalUrl,
            string? htmlUrl,
            string? createdAt,
            string? updatedAt,
            global::G.BranchRestrictionPolicyAppPermissions? permissions,
            global::System.Collections.Generic.IList<string>? events)
        {
            this.Id = id;
            this.Slug = slug;
            this.NodeId = nodeId;
            this.Owner = owner;
            this.Name = name;
            this.ClientId = clientId;
            this.Description = description;
            this.ExternalUrl = externalUrl;
            this.HtmlUrl = htmlUrl;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Permissions = permissions;
            this.Events = events;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BranchRestrictionPolicyApp" /> class.
        /// </summary>
        public BranchRestrictionPolicyApp()
        {
        }
    }
}