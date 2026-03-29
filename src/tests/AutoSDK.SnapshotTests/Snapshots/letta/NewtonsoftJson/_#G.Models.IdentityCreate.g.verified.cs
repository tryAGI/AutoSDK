//HintName: G.Models.IdentityCreate.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IdentityCreate
    {
        /// <summary>
        /// External, user-generated identifier key of the identity.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("identifier_key", Required = global::Newtonsoft.Json.Required.Always)]
        public string IdentifierKey { get; set; } = default!;

        /// <summary>
        /// The name of the identity.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The type of the identity.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("identity_type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.IdentityType IdentityType { get; set; } = default!;

        /// <summary>
        /// The project id of the identity, if applicable.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// The agent ids that are associated with the identity.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agent_ids")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.IList<string>? AgentIds { get; set; }

        /// <summary>
        /// The IDs of the blocks associated with the identity.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("block_ids")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.IList<string>? BlockIds { get; set; }

        /// <summary>
        /// List of properties associated with the identity.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("properties")]
        public global::System.Collections.Generic.IList<global::G.IdentityProperty>? Properties { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IdentityCreate" /> class.
        /// </summary>
        /// <param name="identifierKey">
        /// External, user-generated identifier key of the identity.
        /// </param>
        /// <param name="name">
        /// The name of the identity.
        /// </param>
        /// <param name="identityType">
        /// The type of the identity.
        /// </param>
        /// <param name="projectId">
        /// The project id of the identity, if applicable.
        /// </param>
        /// <param name="properties">
        /// List of properties associated with the identity.
        /// </param>
        public IdentityCreate(
            string identifierKey,
            string name,
            global::G.IdentityType identityType,
            string? projectId,
            global::System.Collections.Generic.IList<global::G.IdentityProperty>? properties)
        {
            this.IdentifierKey = identifierKey ?? throw new global::System.ArgumentNullException(nameof(identifierKey));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.IdentityType = identityType;
            this.ProjectId = projectId;
            this.Properties = properties;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IdentityCreate" /> class.
        /// </summary>
        public IdentityCreate()
        {
        }
    }
}