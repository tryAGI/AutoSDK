//HintName: G.Models.WorkspaceGroupResponseModel.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

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
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("members")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Members { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permissions")]
        public global::System.Collections.Generic.IList<global::G.WorkspaceGroupPermission>? Permissions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_usage_limit")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<int?, string, object>))]
        public global::G.AnyOf<int?, string, object>? GroupUsageLimit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("character_count")]
        public int? CharacterCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scim_external_id")]
        public string? ScimExternalId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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