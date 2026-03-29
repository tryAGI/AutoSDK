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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_version", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PromptVersion PromptVersion { get; set; } = default!;

        /// <summary>
        /// Request status indicating success, warning, or error.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public global::G.LogRequestResponseStatus? Status { get; set; }

        /// <summary>
        /// Categorized error type if status is WARNING or ERROR.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error_type")]
        public string? ErrorType { get; set; }

        /// <summary>
        /// Detailed error message if status is WARNING or ERROR.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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