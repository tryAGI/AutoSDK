//HintName: G.Models.WorkspaceGroupResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkspaceGroupResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("members", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Members { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("permissions")]
        public global::System.Collections.Generic.IList<global::G.WorkspaceGroupPermission>? Permissions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("group_usage_limit")]
        public global::G.AnyOf<int?, string, object>? GroupUsageLimit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("character_count")]
        public int? CharacterCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("scim_external_id")]
        public string? ScimExternalId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceGroupResponseModel" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="id"></param>
        /// <param name="members"></param>
        /// <param name="permissions"></param>
        /// <param name="groupUsageLimit"></param>
        /// <param name="characterCount"></param>
        /// <param name="scimExternalId"></param>
        public WorkspaceGroupResponseModel(
            string name,
            string id,
            global::System.Collections.Generic.IList<string> members,
            global::System.Collections.Generic.IList<global::G.WorkspaceGroupPermission>? permissions,
            global::G.AnyOf<int?, string, object>? groupUsageLimit,
            int? characterCount,
            string? scimExternalId)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Members = members ?? throw new global::System.ArgumentNullException(nameof(members));
            this.Permissions = permissions;
            this.GroupUsageLimit = groupUsageLimit;
            this.CharacterCount = characterCount;
            this.ScimExternalId = scimExternalId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceGroupResponseModel" /> class.
        /// </summary>
        public WorkspaceGroupResponseModel()
        {
        }
    }
}