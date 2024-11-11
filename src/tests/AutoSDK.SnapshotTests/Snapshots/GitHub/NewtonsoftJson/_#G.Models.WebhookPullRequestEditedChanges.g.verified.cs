//HintName: G.Models.WebhookPullRequestEditedChanges.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The changes to the comment if the action was `edited`.
    /// </summary>
    public sealed partial class WebhookPullRequestEditedChanges
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("base")]
        public global::G.WebhookPullRequestEditedChangesBase? Base { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("body")]
        public global::G.WebhookPullRequestEditedChangesBody? Body { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title")]
        public global::G.WebhookPullRequestEditedChangesTitle? Title { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPullRequestEditedChanges" /> class.
        /// </summary>
        /// <param name="base"></param>
        /// <param name="body"></param>
        /// <param name="title"></param>
        public WebhookPullRequestEditedChanges(
            global::G.WebhookPullRequestEditedChangesBase? @base,
            global::G.WebhookPullRequestEditedChangesBody? body,
            global::G.WebhookPullRequestEditedChangesTitle? title)
        {
            this.Base = @base;
            this.Body = body;
            this.Title = title;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookPullRequestEditedChanges" /> class.
        /// </summary>
        public WebhookPullRequestEditedChanges()
        {
        }
    }
}