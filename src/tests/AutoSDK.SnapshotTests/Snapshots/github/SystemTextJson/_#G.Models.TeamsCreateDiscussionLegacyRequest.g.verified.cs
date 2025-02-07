//HintName: G.Models.TeamsCreateDiscussionLegacyRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TeamsCreateDiscussionLegacyRequest
    {
        /// <summary>
        /// The discussion post's title.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// The discussion post's body text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Body { get; set; }

        /// <summary>
        /// Private posts are only visible to team members, organization owners, and team maintainers. Public posts are visible to all members of the organization. Set to `true` to create a private post.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("private")]
        public bool? Private { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamsCreateDiscussionLegacyRequest" /> class.
        /// </summary>
        /// <param name="title">
        /// The discussion post's title.
        /// </param>
        /// <param name="body">
        /// The discussion post's body text.
        /// </param>
        /// <param name="private">
        /// Private posts are only visible to team members, organization owners, and team maintainers. Public posts are visible to all members of the organization. Set to `true` to create a private post.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TeamsCreateDiscussionLegacyRequest(
            string title,
            string body,
            bool? @private)
        {
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Body = body ?? throw new global::System.ArgumentNullException(nameof(body));
            this.Private = @private;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamsCreateDiscussionLegacyRequest" /> class.
        /// </summary>
        public TeamsCreateDiscussionLegacyRequest()
        {
        }
    }
}