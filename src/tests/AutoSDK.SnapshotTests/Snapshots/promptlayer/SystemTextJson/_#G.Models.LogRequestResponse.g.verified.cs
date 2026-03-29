//HintName: G.Models.LogRequestResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LogRequestResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PromptVersion PromptVersion { get; set; }

        /// <summary>
        /// Request status indicating success, warning, or error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.LogRequestResponseStatusJsonConverter))]
        public global::G.LogRequestResponseStatus? Status { get; set; }

        /// <summary>
        /// Categorized error type if status is WARNING or ERROR.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_type")]
        public string? ErrorType { get; set; }

        /// <summary>
        /// Detailed error message if status is WARNING or ERROR.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LogRequestResponse" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="promptVersion"></param>
        /// <param name="status">
        /// Request status indicating success, warning, or error.
        /// </param>
        /// <param name="errorType">
        /// Categorized error type if status is WARNING or ERROR.
        /// </param>
        /// <param name="errorMessage">
        /// Detailed error message if status is WARNING or ERROR.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LogRequestResponse(
            int id,
            global::G.PromptVersion promptVersion,
            global::G.LogRequestResponseStatus? status,
            string? errorType,
            string? errorMessage)
        {
            this.Id = id;
            this.PromptVersion = promptVersion ?? throw new global::System.ArgumentNullException(nameof(promptVersion));
            this.Status = status;
            this.ErrorType = errorType;
            this.ErrorMessage = errorMessage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LogRequestResponse" /> class.
        /// </summary>
        public LogRequestResponse()
        {
        }
    }
}