//HintName: G.Models.PointerGet.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Base model for schemas.
    /// </summary>
    public sealed partial class PointerGet
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pointer", Required = global::Newtonsoft.Json.Required.Always)]
        public string Pointer { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pipeline_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string PipelineId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("locked", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Locked { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PointerGet" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="pointer"></param>
        /// <param name="pipelineId"></param>
        /// <param name="locked"></param>
        public PointerGet(
            string id,
            string pointer,
            string pipelineId,
            bool locked)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Pointer = pointer ?? throw new global::System.ArgumentNullException(nameof(pointer));
            this.PipelineId = pipelineId ?? throw new global::System.ArgumentNullException(nameof(pipelineId));
            this.Locked = locked;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PointerGet" /> class.
        /// </summary>
        public PointerGet()
        {
        }
    }
}