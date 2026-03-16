//HintName: G.Models.ResponseVariant5.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A failed task
    /// </summary>
    public sealed partial class ResponseVariant5
    {
        /// <summary>
        /// The ID of the task being returned.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// The timestamp that the task was submitted at.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createdAt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        /// <default>"FAILED"</default>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public string Status { get; set; } = "FAILED";

        /// <summary>
        /// A human-friendly reason for the failure. We do not recommend returning this to users directly without adding context.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("failure", Required = global::Newtonsoft.Json.Required.Always)]
        public string Failure { get; set; } = default!;

        /// <summary>
        /// A machine-readable error code for the failure. See https://docs.dev.runwayml.com/errors/task-failures/ for more information.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("failureCode")]
        public string? FailureCode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseVariant5" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the task being returned.
        /// </param>
        /// <param name="createdAt">
        /// The timestamp that the task was submitted at.
        /// </param>
        /// <param name="status"></param>
        /// <param name="failure">
        /// A human-friendly reason for the failure. We do not recommend returning this to users directly without adding context.
        /// </param>
        /// <param name="failureCode">
        /// A machine-readable error code for the failure. See https://docs.dev.runwayml.com/errors/task-failures/ for more information.
        /// </param>
        public ResponseVariant5(
            global::System.Guid id,
            global::System.DateTime createdAt,
            string failure,
            string? failureCode,
            string status = "FAILED")
        {
            this.Id = id;
            this.CreatedAt = createdAt;
            this.Failure = failure ?? throw new global::System.ArgumentNullException(nameof(failure));
            this.Status = status;
            this.FailureCode = failureCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseVariant5" /> class.
        /// </summary>
        public ResponseVariant5()
        {
        }
    }
}