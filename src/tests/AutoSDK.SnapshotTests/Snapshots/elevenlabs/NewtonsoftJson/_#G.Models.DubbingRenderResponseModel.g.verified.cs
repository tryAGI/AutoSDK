//HintName: G.Models.DubbingRenderResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DubbingRenderResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version", Required = global::Newtonsoft.Json.Required.Always)]
        public int Version { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("render_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string RenderId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DubbingRenderResponseModel" /> class.
        /// </summary>
        /// <param name="version"></param>
        /// <param name="renderId"></param>
        public DubbingRenderResponseModel(
            int version,
            string renderId)
        {
            this.Version = version;
            this.RenderId = renderId ?? throw new global::System.ArgumentNullException(nameof(renderId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DubbingRenderResponseModel" /> class.
        /// </summary>
        public DubbingRenderResponseModel()
        {
        }
    }
}