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
        [global::Newtonsoft.Json.JsonProperty("referenced_resource_ids")]
        public global::System.Collections.Generic.IList<string>? ReferencedResourceIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Default Value: available
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at_unix_secs", Required = global::Newtonsoft.Json.Required.Always)]
        public int CreatedAtUnixSecs { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("access_level", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.DependentAvailableAgentIdentifierAccessLevel AccessLevel { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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