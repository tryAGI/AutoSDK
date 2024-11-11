//HintName: G.Models.TeamsUpdateDiscussionLegacyRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TeamsUpdateDiscussionLegacyRequest
    {
        /// <summary>
        /// The discussion post's title.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// The discussion post's body text.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("body")]
        public string? Body { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamsUpdateDiscussionLegacyRequest" /> class.
        /// </summary>
        /// <param name="title">
        /// The discussion post's title.
        /// </param>
        /// <param name="body">
        /// The discussion post's body text.
        /// </param>
        public TeamsUpdateDiscussionLegacyRequest(
            string? title,
            string? body)
        {
            this.Title = title;
            this.Body = body;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamsUpdateDiscussionLegacyRequest" /> class.
        /// </summary>
        public TeamsUpdateDiscussionLegacyRequest()
        {
        }
    }
}