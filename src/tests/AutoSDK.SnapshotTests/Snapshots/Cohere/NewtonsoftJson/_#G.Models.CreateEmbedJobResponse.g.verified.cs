//HintName: G.Models.CreateEmbedJobResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response from creating an embed job.
    /// </summary>
    public sealed partial class CreateEmbedJobResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("job_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string JobId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("meta")]
        public global::G.ApiMeta? Meta { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEmbedJobResponse" /> class.
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="meta"></param>
        public CreateEmbedJobResponse(
            string jobId,
            global::G.ApiMeta? meta)
        {
            this.JobId = jobId ?? throw new global::System.ArgumentNullException(nameof(jobId));
            this.Meta = meta;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEmbedJobResponse" /> class.
        /// </summary>
        public CreateEmbedJobResponse()
        {
        }
    }
}