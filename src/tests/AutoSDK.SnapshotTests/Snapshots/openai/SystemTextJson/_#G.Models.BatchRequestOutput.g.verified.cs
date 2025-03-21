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
        /// A developer-provided per-request id that will be used to match outputs to inputs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_id")]
        public string? CustomId { get; set; }

        /// <summary>
        /// For requests that failed with a non-HTTP error, this will contain more information on the cause of the failure.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public global::G.BatchRequestOutputError? Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response")]
        public global::G.BatchRequestOutputResponse? Response { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchRequestOutput" /> class.
        /// </summary>
        /// <param name="customId">
        /// A developer-provided per-request id that will be used to match outputs to inputs.
        /// </param>
        /// <param name="error">
        /// For requests that failed with a non-HTTP error, this will contain more information on the cause of the failure.
        /// </param>
        /// <param name="id"></param>
        /// <param name="response"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchRequestOutput(
            string? customId,
            global::G.BatchRequestOutputError? error,
            string? id,
            global::G.BatchRequestOutputResponse? response)
        {
            this.CustomId = customId;
            this.Error = error;
            this.Id = id;
            this.Response = response;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchRequestOutput" /> class.
        /// </summary>
        public BatchRequestOutput()
        {
        }
    }
}