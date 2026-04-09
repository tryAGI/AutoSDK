//HintName: G.Models.Permission.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Permission resource grants user, group or the rest of the world access to the PaLM API resource (e.g. a tuned model, corpus). A role is a collection of permitted operations that allows users to perform specific actions on PaLM API resources. To make them available to users, groups, or service accounts, you assign roles. When you assign a role, you grant permissions that the role contains. There are three concentric roles. Each role is a superset of the previous role's permitted operations: - reader can use the resource (e.g. tuned model, corpus) for inference - writer has reader's permissions and additionally can edit and share - owner has writer's permissions and additionally can delete
    /// </summary>
    public sealed partial class Permission
    {
        /// <summary>
        /// Output only. Identifier. The permission name. A unique name will be generated on create. Examples: tunedModels/{tuned_model}/permissions/{permission} corpora/{corpus}/permissions/{permission} Output only.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Optional. Immutable. The type of the grantee.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("granteeType")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.PermissionGranteeTypeJsonConverter))]
        public global::G.PermissionGranteeType? GranteeType { get; set; }

        /// <summary>
        /// Optional. Immutable. The email address of the user of group which this permission refers. Field is not set when permission's grantee type is EVERYONE.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("emailAddress")]
        public string? EmailAddress { get; set; }

        /// <summary>
        /// Required. The role granted by this permission.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.PermissionRoleJsonConverter))]
        public global::G.PermissionRole? Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Permission" /> class.
        /// </summary>
        /// <param name="name">
        /// Output only. Identifier. The permission name. A unique name will be generated on create. Examples: tunedModels/{tuned_model}/permissions/{permission} corpora/{corpus}/permissions/{permission} Output only.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="granteeType">
        /// Optional. Immutable. The type of the grantee.
        /// </param>
        /// <param name="emailAddress">
        /// Optional. Immutable. The email address of the user of group which this permission refers. Field is not set when permission's grantee type is EVERYONE.
        /// </param>
        /// <param name="role">
        /// Required. The role granted by this permission.
        /// </param>
        public Permission(
            string? name,
            global::G.PermissionGranteeType? granteeType,
            string? emailAddress,
            global::G.PermissionRole? role)
        {
            this.Name = name;
            this.GranteeType = granteeType;
            this.EmailAddress = emailAddress;
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Permission" /> class.
        /// </summary>
        public Permission()
        {
        }
    }
}