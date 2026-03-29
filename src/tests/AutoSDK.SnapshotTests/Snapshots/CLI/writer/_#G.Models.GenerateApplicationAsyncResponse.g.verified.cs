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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// The status of the job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ApiJobStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ApiJobStatus Status { get; set; }

        /// <summary>
        /// The timestamp when the job was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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