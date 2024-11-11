//HintName: G.Models.PipelineFamilyGet.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Base model for schemas.
    /// </summary>
    public sealed partial class PipelineFamilyGet
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("run_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int RunCount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("latest_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime LatestAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pipeline_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string PipelineId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image_url")]
        public string? ImageUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineFamilyGet" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="runCount"></param>
        /// <param name="description"></param>
        /// <param name="latestAt"></param>
        /// <param name="pipelineId"></param>
        /// <param name="imageUrl"></param>
        public PipelineFamilyGet(
            string name,
            int runCount,
            global::System.DateTime latestAt,
            string pipelineId,
            string? description,
            string? imageUrl)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.RunCount = runCount;
            this.LatestAt = latestAt;
            this.PipelineId = pipelineId ?? throw new global::System.ArgumentNullException(nameof(pipelineId));
            this.Description = description;
            this.ImageUrl = imageUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineFamilyGet" /> class.
        /// </summary>
        public PipelineFamilyGet()
        {
        }
    }
}