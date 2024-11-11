//HintName: G.Models.GistsGetCommentResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GistsGetCommentResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("block")]
        public global::G.GistsGetCommentResponseBlock? Block { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("documentation_url")]
        public string? DocumentationUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GistsGetCommentResponse" /> class.
        /// </summary>
        /// <param name="block"></param>
        /// <param name="message"></param>
        /// <param name="documentationUrl"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public GistsGetCommentResponse(
            global::G.GistsGetCommentResponseBlock? block,
            string? message,
            string? documentationUrl)
        {
            this.Block = block;
            this.Message = message;
            this.DocumentationUrl = documentationUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GistsGetCommentResponse" /> class.
        /// </summary>
        public GistsGetCommentResponse()
        {
        }
    }
}