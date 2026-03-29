//HintName: G.Models.CreateBatch.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateBatch
    {
        /// <summary>
        /// List of requests to be processed in batch.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("requests", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.LettaBatchRequest> Requests { get; set; } = default!;

        /// <summary>
        /// Optional URL to call via POST when the batch completes. The callback payload will be a JSON object with the following fields: {'job_id': string, 'status': string, 'completed_at': string}. Where 'job_id' is the unique batch job identifier, 'status' is the final batch status (e.g., 'completed', 'failed'), and 'completed_at' is an ISO 8601 timestamp indicating when the batch job completed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("callback_url")]
        public string? CallbackUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBatch" /> class.
        /// </summary>
        /// <param name="requests">
        /// List of requests to be processed in batch.
        /// </param>
        /// <param name="callbackUrl">
        /// Optional URL to call via POST when the batch completes. The callback payload will be a JSON object with the following fields: {'job_id': string, 'status': string, 'completed_at': string}. Where 'job_id' is the unique batch job identifier, 'status' is the final batch status (e.g., 'completed', 'failed'), and 'completed_at' is an ISO 8601 timestamp indicating when the batch job completed.
        /// </param>
        public CreateBatch(
            global::System.Collections.Generic.IList<global::G.LettaBatchRequest> requests,
            string? callbackUrl)
        {
            this.Requests = requests ?? throw new global::System.ArgumentNullException(nameof(requests));
            this.CallbackUrl = callbackUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBatch" /> class.
        /// </summary>
        public CreateBatch()
        {
        }
    }
}