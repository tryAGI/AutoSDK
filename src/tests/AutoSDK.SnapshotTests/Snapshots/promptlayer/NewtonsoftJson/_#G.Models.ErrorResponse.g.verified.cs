//HintName: G.Models.ErrorResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Error response format.
    /// </summary>
    public sealed partial class ErrorResponse
    {
        /// <summary>
        /// Indicates that the request failed.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("success", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Success { get; set; } = default!;

        /// <summary>
        /// Error message explaining why the request failed.
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
        /// <param name="success">
        /// Indicates that the request failed.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="error">
        /// Error message explaining why the request failed.
        /// </param>
        public ErrorResponse(
            bool success,
            string error)
        {
            this.Success = success;
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