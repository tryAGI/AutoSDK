//HintName: G.Models.FetchCreateResponse4.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FetchCreateResponse4
    {
        /// <summary>
        /// HTTP status code
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("statusCode", Required = global::Newtonsoft.Json.Required.Always)]
        public int StatusCode { get; set; } = default!;

        /// <summary>
        /// HTTP error name
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error", Required = global::Newtonsoft.Json.Required.Always)]
        public string Error { get; set; } = default!;

        /// <summary>
        /// Human-readable error message
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// Unique identifier for the fetch request
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FetchCreateResponse4" /> class.
        /// </summary>
        /// <param name="statusCode">
        /// HTTP status code
        /// </param>
        /// <param name="error">
        /// HTTP error name
        /// </param>
        /// <param name="message">
        /// Human-readable error message
        /// </param>
        /// <param name="id">
        /// Unique identifier for the fetch request
        /// </param>
        public FetchCreateResponse4(
            int statusCode,
            string error,
            string message,
            string id)
        {
            this.StatusCode = statusCode;
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FetchCreateResponse4" /> class.
        /// </summary>
        public FetchCreateResponse4()
        {
        }
    }
}