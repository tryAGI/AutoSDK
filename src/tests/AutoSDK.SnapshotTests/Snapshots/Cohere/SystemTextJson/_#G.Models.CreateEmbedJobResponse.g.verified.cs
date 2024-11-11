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
        [global::System.Text.Json.Serialization.JsonPropertyName("job_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string JobId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta")]
        public global::G.ApiMeta? Meta { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEmbedJobResponse" /> class.
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="meta"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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