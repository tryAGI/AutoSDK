//HintName: G.Models.ReactionsCreateForIssueRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReactionsCreateForIssueRequest
    {
        /// <summary>
        /// The [reaction type](https://docs.github.com/rest/reactions/reactions#about-reactions) to add to the issue.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ReactionsCreateForIssueRequestContentJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ReactionsCreateForIssueRequestContent Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReactionsCreateForIssueRequest" /> class.
        /// </summary>
        /// <param name="content">
        /// The [reaction type](https://docs.github.com/rest/reactions/reactions#about-reactions) to add to the issue.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ReactionsCreateForIssueRequest(
            global::G.ReactionsCreateForIssueRequestContent content)
        {
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReactionsCreateForIssueRequest" /> class.
        /// </summary>
        public ReactionsCreateForIssueRequest()
        {
        }
    }
}