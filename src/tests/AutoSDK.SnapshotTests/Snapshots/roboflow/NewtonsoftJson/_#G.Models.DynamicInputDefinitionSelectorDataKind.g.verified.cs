//HintName: G.Models.DynamicInputDefinitionSelectorDataKind.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Mapping of `selector_types` into names of kinds to be compatible. Empty dict (default value) means wildcard kind for all selectors. If name of kind given - must be valid kind, known for workflow execution engine.
    /// </summary>
    public sealed partial class DynamicInputDefinitionSelectorDataKind
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}