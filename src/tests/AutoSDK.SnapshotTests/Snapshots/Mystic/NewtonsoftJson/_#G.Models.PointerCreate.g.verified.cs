//HintName: G.Models.PointerCreate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Base model for schemas.
    /// </summary>
    public sealed partial class PointerCreate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pointer_or_pipeline_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string PointerOrPipelineId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pointer", Required = global::Newtonsoft.Json.Required.Always)]
        public string Pointer { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="PointerCreate" /> class.
        /// </summary>
        /// <param name="pointerOrPipelineId"></param>
        /// <param name="pointer"></param>
        /// <param name="locked"></param>
        public PointerCreate(
            string pointerOrPipelineId,
            string pointer,
            bool? locked)
        {
            this.PointerOrPipelineId = pointerOrPipelineId ?? throw new global::System.ArgumentNullException(nameof(pointerOrPipelineId));
            this.Pointer = pointer ?? throw new global::System.ArgumentNullException(nameof(pointer));
            this.Locked = locked;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PointerCreate" /> class.
        /// </summary>
        public PointerCreate()
        {
        }
    }
}