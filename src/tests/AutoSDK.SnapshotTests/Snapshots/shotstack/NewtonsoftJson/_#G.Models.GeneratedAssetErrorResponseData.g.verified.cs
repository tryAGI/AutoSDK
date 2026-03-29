//HintName: G.Models.GeneratedAssetErrorResponseData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Individual errors returned by the Create API.
    /// </summary>
    public sealed partial class GeneratedAssetErrorResponseData
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
        /// Example: Bad Request
        /// </summary>
        /// <example>Bad Request</example>
        [global::Newtonsoft.Json.JsonProperty("title", Required = global::Newtonsoft.Json.Required.Always)]
        public string Title { get; set; } = default!;

        /// <summary>
        /// A detailed description of the error.<br/>
        /// Example: "body/options/text" is required.
        /// </summary>
        /// <example>"body/options/text" is required.</example>
        [global::Newtonsoft.Json.JsonProperty("detail", Required = global::Newtonsoft.Json.Required.Always)]
        public string Detail { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GeneratedAssetErrorResponseData" /> class.
        /// </summary>
        /// <param name="status">
        /// The http status code.<br/>
        /// Example: 400
        /// </param>
        /// <param name="title">
        /// A short summary of the error.<br/>
        /// Example: Bad Request
        /// </param>
        /// <param name="detail">
        /// A detailed description of the error.<br/>
        /// Example: "body/options/text" is required.
        /// </param>
        public GeneratedAssetErrorResponseData(
            string status,
            string title,
            string detail)
        {
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Detail = detail ?? throw new global::System.ArgumentNullException(nameof(detail));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GeneratedAssetErrorResponseData" /> class.
        /// </summary>
        public GeneratedAssetErrorResponseData()
        {
        }
    }
}