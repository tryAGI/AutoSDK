//HintName: G.Models.DependentUnknownAgentIdentifier.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A model that represents an agent dependent on a knowledge base/tools<br/>
    /// to which the user has no direct access.
    /// </summary>
    public sealed partial class DependentUnknownAgentIdentifier
    {
        /// <summary>
        /// If the agent is a transitive dependent, contains IDs of the resources that the agent depends on directly.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("referenced_resource_ids")]
        public global::System.Collections.Generic.IList<string>? ReferencedResourceIds { get; set; }

        /// <summary>
        /// Default Value: unknown
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DependentUnknownAgentIdentifier" /> class.
        /// </summary>
        /// <param name="referencedResourceIds">
        /// If the agent is a transitive dependent, contains IDs of the resources that the agent depends on directly.
        /// </param>
        /// <param name="type">
        /// Default Value: unknown
        /// </param>
        public DependentUnknownAgentIdentifier(
            global::System.Collections.Generic.IList<string>? referencedResourceIds,
            string? type)
        {
            this.ReferencedResourceIds = referencedResourceIds;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DependentUnknownAgentIdentifier" /> class.
        /// </summary>
        public DependentUnknownAgentIdentifier()
        {
        }
    }
}