//HintName: G.Models.DocumentParseResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DocumentParseResponse
    {
        /// <summary>
        /// The API name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api")]
        public string? Api { get; set; }

        /// <summary>
        /// The model used for document parsing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public global::G.DocumentParseContent? Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public global::G.DocumentParseUsage? Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentParseResponse" /> class.
        /// </summary>
        /// <param name="api">
        /// The API name.
        /// </param>
        /// <param name="model">
        /// The model used for document parsing.
        /// </param>
        /// <param name="content"></param>
        /// <param name="usage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DocumentParseResponse(
            string? api,
            string? model,
            global::G.DocumentParseContent? content,
            global::G.DocumentParseUsage? usage)
        {
            this.Api = api;
            this.Model = model;
            this.Content = content;
            this.Usage = usage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentParseResponse" /> class.
        /// </summary>
        public DocumentParseResponse()
        {
        }
    }
}