//HintName: G.Models.CreateCommentRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateCommentRequest
    {
        /// <summary>
        /// The id of the project to attach the comment to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// The type of the object to attach the comment to (trace, observation, session, prompt).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("objectType")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ObjectType { get; set; }

        /// <summary>
        /// The id of the object to attach the comment to. If this does not reference a valid existing object, an error will be thrown.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("objectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ObjectId { get; set; }

        /// <summary>
        /// The content of the comment. May include markdown. Currently limited to 5000 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// The id of the user who created the comment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authorUserId")]
        public string? AuthorUserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCommentRequest" /> class.
        /// </summary>
        /// <param name="projectId">
        /// The id of the project to attach the comment to.
        /// </param>
        /// <param name="objectType">
        /// The type of the object to attach the comment to (trace, observation, session, prompt).
        /// </param>
        /// <param name="objectId">
        /// The id of the object to attach the comment to. If this does not reference a valid existing object, an error will be thrown.
        /// </param>
        /// <param name="content">
        /// The content of the comment. May include markdown. Currently limited to 5000 characters.
        /// </param>
        /// <param name="authorUserId">
        /// The id of the user who created the comment.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateCommentRequest(
            string projectId,
            string objectType,
            string objectId,
            string content,
            string? authorUserId)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.ObjectType = objectType ?? throw new global::System.ArgumentNullException(nameof(objectType));
            this.ObjectId = objectId ?? throw new global::System.ArgumentNullException(nameof(objectId));
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.AuthorUserId = authorUserId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCommentRequest" /> class.
        /// </summary>
        public CreateCommentRequest()
        {
        }
    }
}