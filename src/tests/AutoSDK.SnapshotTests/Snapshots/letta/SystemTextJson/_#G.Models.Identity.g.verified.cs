//HintName: G.Models.Identity.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Identity
    {
        /// <summary>
        /// The human-friendly ID of the Identity
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// External, user-generated identifier key of the identity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("identifier_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IdentifierKey { get; set; }

        /// <summary>
        /// The name of the identity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The type of the identity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("identity_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.IdentityTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.IdentityType IdentityType { get; set; }

        /// <summary>
        /// The project id of the identity, if applicable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// The IDs of the agents associated with the identity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> AgentIds { get; set; }

        /// <summary>
        /// The IDs of the blocks associated with the identity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("block_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> BlockIds { get; set; }

        /// <summary>
        /// List of properties associated with the identity
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("properties")]
        public global::System.Collections.Generic.IList<global::G.IdentityProperty>? Properties { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Identity" /> class.
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
        /// <param name="agentIds">
        /// The IDs of the agents associated with the identity.
        /// </param>
        /// <param name="blockIds">
        /// The IDs of the blocks associated with the identity.
        /// </param>
        /// <param name="id">
        /// The human-friendly ID of the Identity
        /// </param>
        /// <param name="projectId">
        /// The project id of the identity, if applicable.
        /// </param>
        /// <param name="properties">
        /// List of properties associated with the identity
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Identity(
            string identifierKey,
            string name,
            global::G.IdentityType identityType,
            global::System.Collections.Generic.IList<string> agentIds,
            global::System.Collections.Generic.IList<string> blockIds,
            string? id,
            string? projectId,
            global::System.Collections.Generic.IList<global::G.IdentityProperty>? properties)
        {
            this.Id = id;
            this.IdentifierKey = identifierKey ?? throw new global::System.ArgumentNullException(nameof(identifierKey));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.IdentityType = identityType;
            this.ProjectId = projectId;
            this.AgentIds = agentIds ?? throw new global::System.ArgumentNullException(nameof(agentIds));
            this.BlockIds = blockIds ?? throw new global::System.ArgumentNullException(nameof(blockIds));
            this.Properties = properties;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Identity" /> class.
        /// </summary>
        public Identity()
        {
        }
    }
}