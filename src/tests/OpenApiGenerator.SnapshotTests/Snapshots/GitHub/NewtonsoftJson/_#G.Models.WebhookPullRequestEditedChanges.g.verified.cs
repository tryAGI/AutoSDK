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
        public WebhookPullRequestEditedChangesBase? Base { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("body")]
        public WebhookPullRequestEditedChangesBody? Body { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title")]
        public WebhookPullRequestEditedChangesTitle? Title { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}