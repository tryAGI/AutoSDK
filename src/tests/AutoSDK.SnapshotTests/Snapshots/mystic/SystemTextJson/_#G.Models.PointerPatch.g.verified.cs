//HintName: G.Models.PointerPatch.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Base model for schemas.
    /// </summary>
    public sealed partial class PointerPatch
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pointer_or_pipeline_id")]
        public string? PointerOrPipelineId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("locked")]
        public bool? Locked { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PointerPatch" /> class.
        /// </summary>
        /// <param name="pointerOrPipelineId"></param>
        /// <param name="locked"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PointerPatch(
            string? pointerOrPipelineId,
            bool? locked)
        {
            this.PointerOrPipelineId = pointerOrPipelineId;
            this.Locked = locked;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PointerPatch" /> class.
        /// </summary>
        public PointerPatch()
        {
        }
    }
}