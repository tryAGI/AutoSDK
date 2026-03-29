//HintName: G.Models.RetrieveAgentIncludeRelationships.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Specify which relational fields (e.g., 'tools', 'sources', 'memory') to include in the response. If not provided, all relationships are loaded by default. Using this can optimize performance by reducing unnecessary joins.This is a legacy parameter, and no longer supported after 1.0.0 SDK versions.
    /// </summary>
    [global::System.Obsolete("This model marked as deprecated.")]
    public sealed partial class RetrieveAgentIncludeRelationships
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}