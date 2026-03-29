//HintName: G.Models.IdentityUpdate.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IdentityUpdate
    {
        /// <summary>
        /// External, user-generated identifier key of the identity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("identifier_key")]
        public string? IdentifierKey { get; set; }

        /// <summary>
        /// The name of the identity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The type of the identity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("identity_type")]
        public global::G.IdentityType? IdentityType { get; set; }

        /// <summary>
        /// The agent ids that are associated with the identity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_ids")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.IList<string>? AgentIds { get; set; }

        /// <summary>
        /// The IDs of the blocks associated with the identity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("block_ids")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.IList<string>? BlockIds { get; set; }

        /// <summary>
        /// List of properties associated with the identity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("properties")]
        public global::System.Collections.Generic.IList<global::G.IdentityProperty>? Properties { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IdentityUpdate" /> class.
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
        /// <param name="properties">
        /// List of properties associated with the identity.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IdentityUpdate(
            string? identifierKey,
            string? name,
            global::G.IdentityType? identityType,
            global::System.Collections.Generic.IList<global::G.IdentityProperty>? properties)
        {
            this.IdentifierKey = identifierKey;
            this.Name = name;
            this.IdentityType = identityType;
            this.Properties = properties;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IdentityUpdate" /> class.
        /// </summary>
        public IdentityUpdate()
        {
        }
    }
}