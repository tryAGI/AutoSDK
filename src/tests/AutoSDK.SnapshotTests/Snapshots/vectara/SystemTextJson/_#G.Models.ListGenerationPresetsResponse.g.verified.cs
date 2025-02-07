//HintName: G.Models.ListGenerationPresetsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListGenerationPresetsResponse
    {
        /// <summary>
        /// List of generation presets.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generation_presets")]
        public global::System.Collections.Generic.IList<global::G.GenerationPreset>? GenerationPresets { get; set; }

        /// <summary>
        /// The standard metadata in the response of a list operation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::G.ListMetadata? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListGenerationPresetsResponse" /> class.
        /// </summary>
        /// <param name="generationPresets">
        /// List of generation presets.
        /// </param>
        /// <param name="metadata">
        /// The standard metadata in the response of a list operation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListGenerationPresetsResponse(
            global::System.Collections.Generic.IList<global::G.GenerationPreset>? generationPresets,
            global::G.ListMetadata? metadata)
        {
            this.GenerationPresets = generationPresets;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListGenerationPresetsResponse" /> class.
        /// </summary>
        public ListGenerationPresetsResponse()
        {
        }
    }
}