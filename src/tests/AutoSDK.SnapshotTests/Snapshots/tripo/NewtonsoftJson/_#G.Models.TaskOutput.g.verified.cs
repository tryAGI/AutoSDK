//HintName: G.Models.TaskOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TaskOutput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public string? Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("base_model")]
        public string? BaseModel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pbr_model")]
        public string? PbrModel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rendered_image")]
        public string? RenderedImage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskOutput" /> class.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="baseModel"></param>
        /// <param name="pbrModel"></param>
        /// <param name="renderedImage"></param>
        public TaskOutput(
            string? model,
            string? baseModel,
            string? pbrModel,
            string? renderedImage)
        {
            this.Model = model;
            this.BaseModel = baseModel;
            this.PbrModel = pbrModel;
            this.RenderedImage = renderedImage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskOutput" /> class.
        /// </summary>
        public TaskOutput()
        {
        }
    }
}