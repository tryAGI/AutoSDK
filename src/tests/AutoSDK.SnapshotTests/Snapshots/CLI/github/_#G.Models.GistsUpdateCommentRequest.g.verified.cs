//HintName: G.Models.GistsUpdateCommentRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GistsUpdateCommentRequest
    {
        /// <summary>
        /// The comment text.<br/>
        /// Example: Body of the attachment
        /// </summary>
        /// <example>Body of the attachment</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Body { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GistsUpdateCommentRequest" /> class.
        /// </summary>
        /// <param name="body">
        /// The comment text.<br/>
        /// Example: Body of the attachment
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GistsUpdateCommentRequest(
            string body)
        {
            this.Body = body ?? throw new global::System.ArgumentNullException(nameof(body));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GistsUpdateCommentRequest" /> class.
        /// </summary>
        public GistsUpdateCommentRequest()
        {
        }
    }
}