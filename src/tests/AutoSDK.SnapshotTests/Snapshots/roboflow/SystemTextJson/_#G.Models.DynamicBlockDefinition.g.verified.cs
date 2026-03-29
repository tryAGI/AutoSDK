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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "DynamicBlockDefinition";

        /// <summary>
        /// Definition of manifest for dynamic block to be created in runtime by workflows execution engine.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("manifest")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ManifestDescription Manifest { get; set; }

        /// <summary>
        /// Code to be executed in run(...) method of block that will be dynamically created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PythonCode Code { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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