//HintName: G.Models.IngestErrorResponseData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Individual errors returned by the Ingest API.
    /// </summary>
    public sealed partial class IngestErrorResponseData
    {
        /// <summary>
        /// The http status code.<br/>
        /// Example: 400
        /// </summary>
        /// <example>400</example>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public string Status { get; set; } = default!;

        /// <summary>
        /// A short summary of the error.<br/>
        /// Example: Validation Error
        /// </summary>
        /// <example>Validation Error</example>
        [global::Newtonsoft.Json.JsonProperty("title", Required = global::Newtonsoft.Json.Required.Always)]
        public string Title { get; set; } = default!;

        /// <summary>
        /// A detailed description of the error.<br/>
        /// Example: "url" is required
        /// </summary>
        /// <example>"url" is required</example>
        [global::Newtonsoft.Json.JsonProperty("detail", Required = global::Newtonsoft.Json.Required.Always)]
        public string Detail { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IngestErrorResponseData" /> class.
        /// </summary>
        /// <param name="status">
        /// The http status code.<br/>
        /// Example: 400
        /// </param>
        /// <param name="title">
        /// A short summary of the error.<br/>
        /// Example: Validation Error
        /// </param>
        /// <param name="detail">
        /// A detailed description of the error.<br/>
        /// Example: "url" is required
        /// </param>
        public IngestErrorResponseData(
            string status,
            string title,
            string detail)
        {
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Detail = detail ?? throw new global::System.ArgumentNullException(nameof(detail));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IngestErrorResponseData" /> class.
        /// </summary>
        public IngestErrorResponseData()
        {
        }
    }
}