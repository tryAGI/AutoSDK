//HintName: G.Models.ErrorResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The response to an unsuccessful request.
    /// </summary>
    public sealed partial class ErrorResponse
    {
        /// <summary>
        /// The status of the request.
        /// </summary>
        /// <default>"error"</default>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public string Status { get; set; } = "error";

        /// <summary>
        /// The error message.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error", Required = global::Newtonsoft.Json.Required.Always)]
        public string Error { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorResponse" /> class.
        /// </summary>
        /// <param name="error">
        /// The error message.
        /// </param>
        /// <param name="status">
        /// The status of the request.
        /// </param>
        public ErrorResponse(
            string error,
            string status = "error")
        {
            this.Status = status;
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorResponse" /> class.
        /// </summary>
        public ErrorResponse()
        {
        }
    }
}