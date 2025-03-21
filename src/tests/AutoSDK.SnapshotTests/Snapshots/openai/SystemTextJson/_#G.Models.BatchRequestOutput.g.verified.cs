//HintName: G.Models.BatchRequestOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The per-line object of the batch output and error files
    /// </summary>
    public sealed partial class BatchRequestOutput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// A developer-provided per-request id that will be used to match outputs to inputs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_id")]
        public string? CustomId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response")]
        public global::G.BatchRequestOutputResponse? Response { get; set; }

        /// <summary>
        /// For requests that failed with a non-HTTP error, this will contain more information on the cause of the failure.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public global::G.BatchRequestOutputError? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchRequestOutput" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="customId">
        /// A developer-provided per-request id that will be used to match outputs to inputs.
        /// </param>
        /// <param name="response"></param>
        /// <param name="error">
        /// For requests that failed with a non-HTTP error, this will contain more information on the cause of the failure.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchRequestOutput(
            string? id,
            string? customId,
            global::G.BatchRequestOutputResponse? response,
            global::G.BatchRequestOutputError? error)
        {
            this.Id = id;
            this.CustomId = customId;
            this.Response = response;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchRequestOutput" /> class.
        /// </summary>
        public BatchRequestOutput()
        {
        }
    }
}