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
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// A short summary of the error.<br/>
        /// Example: Bad Request
        /// </summary>
        /// <example>Bad Request</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// A detailed description of the error.<br/>
        /// Example: "body/options/text" is required.
        /// </summary>
        /// <example>"body/options/text" is required.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Detail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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