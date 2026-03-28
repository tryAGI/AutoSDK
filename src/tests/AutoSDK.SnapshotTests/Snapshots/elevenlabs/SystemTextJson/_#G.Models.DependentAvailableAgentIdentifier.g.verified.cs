//HintName: G.Models.DependentAvailableAgentIdentifier.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DependentAvailableAgentIdentifier
    {
        /// <summary>
        /// If the agent is a transitive dependent, contains IDs of the resources that the agent depends on directly.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenced_resource_ids")]
        public global::System.Collections.Generic.IList<string>? ReferencedResourceIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Default Value: available
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at_unix_secs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CreatedAtUnixSecs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access_level")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.DependentAvailableAgentIdentifierAccessLevelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.DependentAvailableAgentIdentifierAccessLevel AccessLevel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DependentAvailableAgentIdentifier" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="createdAtUnixSecs"></param>
        /// <param name="accessLevel"></param>
        /// <param name="referencedResourceIds">
        /// If the agent is a transitive dependent, contains IDs of the resources that the agent depends on directly.
        /// </param>
        /// <param name="type">
        /// Default Value: available
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DependentAvailableAgentIdentifier(
            string id,
            string name,
            int createdAtUnixSecs,
            global::G.DependentAvailableAgentIdentifierAccessLevel accessLevel,
            global::System.Collections.Generic.IList<string>? referencedResourceIds,
            string? type)
        {
            this.ReferencedResourceIds = referencedResourceIds;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type;
            this.CreatedAtUnixSecs = createdAtUnixSecs;
            this.AccessLevel = accessLevel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DependentAvailableAgentIdentifier" /> class.
        /// </summary>
        public DependentAvailableAgentIdentifier()
        {
        }
    }
}