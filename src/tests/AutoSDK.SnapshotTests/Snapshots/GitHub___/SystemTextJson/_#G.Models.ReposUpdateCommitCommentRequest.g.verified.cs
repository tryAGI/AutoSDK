//HintName: G.Models.ReposUpdateCommitCommentRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReposUpdateCommitCommentRequest
    {
        /// <summary>
        /// The contents of the comment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Body { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposUpdateCommitCommentRequest" /> class.
        /// </summary>
        /// <param name="body">
        /// The contents of the comment
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ReposUpdateCommitCommentRequest(
            string body)
        {
            this.Body = body ?? throw new global::System.ArgumentNullException(nameof(body));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposUpdateCommitCommentRequest" /> class.
        /// </summary>
        public ReposUpdateCommitCommentRequest()
        {
        }
    }
}