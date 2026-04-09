//HintName: G.Models.GenerateApplicationAsyncResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerateApplicationAsyncResponse
    {
        /// <summary>
        /// The unique identifier for the async job created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// The status of the job.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ApiJobStatusJsonConverter))]
        public global::G.ApiJobStatus Status { get; set; } = default!;

        /// <summary>
        /// The timestamp when the job was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateApplicationAsyncResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier for the async job created.
        /// </param>
        /// <param name="status">
        /// The status of the job.
        /// </param>
        /// <param name="createdAt">
        /// The timestamp when the job was created.
        /// </param>
        public GenerateApplicationAsyncResponse(
            global::System.Guid id,
            global::G.ApiJobStatus status,
            global::System.DateTime createdAt)
        {
            this.Id = id;
            this.Status = status;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateApplicationAsyncResponse" /> class.
        /// </summary>
        public GenerateApplicationAsyncResponse()
        {
        }
    }
}