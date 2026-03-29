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
        [global::Newtonsoft.Json.JsonProperty("projectId", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProjectId { get; set; } = default!;

        /// <summary>
        /// The type of the object to attach the comment to (trace, observation, session, prompt).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("objectType", Required = global::Newtonsoft.Json.Required.Always)]
        public string ObjectType { get; set; } = default!;

        /// <summary>
        /// The id of the object to attach the comment to. If this does not reference a valid existing object, an error will be thrown.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("objectId", Required = global::Newtonsoft.Json.Required.Always)]
        public string ObjectId { get; set; } = default!;

        /// <summary>
        /// The content of the comment. May include markdown. Currently limited to 5000 characters.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public string Content { get; set; } = default!;

        /// <summary>
        /// The id of the user who created the comment.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("authorUserId")]
        public string? AuthorUserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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