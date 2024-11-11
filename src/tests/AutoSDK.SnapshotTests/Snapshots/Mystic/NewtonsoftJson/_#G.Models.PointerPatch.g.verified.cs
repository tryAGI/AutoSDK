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
        [global::Newtonsoft.Json.JsonProperty("pointer_or_pipeline_id")]
        public string? PointerOrPipelineId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("locked")]
        public bool? Locked { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PointerPatch" /> class.
        /// </summary>
        /// <param name="pointerOrPipelineId"></param>
        /// <param name="locked"></param>
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