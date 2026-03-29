//HintName: G.Models.DynamicBlockDefinition.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DynamicBlockDefinition
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"DynamicBlockDefinition"</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; } = "DynamicBlockDefinition";

        /// <summary>
        /// Definition of manifest for dynamic block to be created in runtime by workflows execution engine.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("manifest", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ManifestDescription Manifest { get; set; } = default!;

        /// <summary>
        /// Code to be executed in run(...) method of block that will be dynamically created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("code", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PythonCode Code { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicBlockDefinition" /> class.
        /// </summary>
        /// <param name="manifest">
        /// Definition of manifest for dynamic block to be created in runtime by workflows execution engine.
        /// </param>
        /// <param name="code">
        /// Code to be executed in run(...) method of block that will be dynamically created.
        /// </param>
        /// <param name="type"></param>
        public DynamicBlockDefinition(
            global::G.ManifestDescription manifest,
            global::G.PythonCode code,
            string type = "DynamicBlockDefinition")
        {
            this.Type = type;
            this.Manifest = manifest ?? throw new global::System.ArgumentNullException(nameof(manifest));
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicBlockDefinition" /> class.
        /// </summary>
        public DynamicBlockDefinition()
        {
        }
    }
}