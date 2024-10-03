//HintName: G.Models.PropertyModuleConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration specific to modules in a property context.
    /// </summary>
    public sealed partial class PropertyModuleConfig
    {
        /// <summary>
        /// E.g. `text2vec-transformers`, `text2vec-openai`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("<module_name>")]
        public global::G.PropertyModuleConfig2? x_moduleName_ { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}