//HintName: G.Models.GetContentsResponseStatuse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetContentsResponseStatuse
    {
        /// <summary>
        /// The URL that was requested<br/>
        /// Example: https://example.com
        /// </summary>
        /// <example>https://example.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Status of the content fetch operation<br/>
        /// Example: success
        /// </summary>
        /// <example>success</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.GetContentsResponseStatuseStatusJsonConverter))]
        public global::G.GetContentsResponseStatuseStatus? Status { get; set; }

        /// <summary>
        /// Error details, only present when status is "error"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public global::G.GetContentsResponseStatuseError? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetContentsResponseStatuse" /> class.
        /// </summary>
        /// <param name="id">
        /// The URL that was requested<br/>
        /// Example: https://example.com
        /// </param>
        /// <param name="status">
        /// Status of the content fetch operation<br/>
        /// Example: success
        /// </param>
        /// <param name="error">
        /// Error details, only present when status is "error"
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetContentsResponseStatuse(
            string? id,
            global::G.GetContentsResponseStatuseStatus? status,
            global::G.GetContentsResponseStatuseError? error)
        {
            this.Id = id;
            this.Status = status;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetContentsResponseStatuse" /> class.
        /// </summary>
        public GetContentsResponseStatuse()
        {
        }
    }
}