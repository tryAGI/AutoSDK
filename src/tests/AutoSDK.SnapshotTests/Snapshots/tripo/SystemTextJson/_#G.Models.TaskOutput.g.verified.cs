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
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_model")]
        public string? BaseModel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pbr_model")]
        public string? PbrModel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rendered_image")]
        public string? RenderedImage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskOutput" /> class.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="baseModel"></param>
        /// <param name="pbrModel"></param>
        /// <param name="renderedImage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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