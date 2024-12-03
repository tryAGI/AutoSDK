//HintName: G.Models.WebhookWorkflowRunRequestedWorkflowRunPullRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookWorkflowRunRequestedWorkflowRunPullRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebhookWorkflowRunRequestedWorkflowRunPullRequestBase Base { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("head")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebhookWorkflowRunRequestedWorkflowRunPullRequestHead Head { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Number { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookWorkflowRunRequestedWorkflowRunPullRequest" /> class.
        /// </summary>
        /// <param name="base"></param>
        /// <param name="head"></param>
        /// <param name="id"></param>
        /// <param name="number"></param>
        /// <param name="url"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public WebhookWorkflowRunRequestedWorkflowRunPullRequest(
            global::G.WebhookWorkflowRunRequestedWorkflowRunPullRequestBase @base,
            global::G.WebhookWorkflowRunRequestedWorkflowRunPullRequestHead head,
            double id,
            double number,
            string url)
        {
            this.Base = @base ?? throw new global::System.ArgumentNullException(nameof(@base));
            this.Head = head ?? throw new global::System.ArgumentNullException(nameof(head));
            this.Id = id;
            this.Number = number;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookWorkflowRunRequestedWorkflowRunPullRequest" /> class.
        /// </summary>
        public WebhookWorkflowRunRequestedWorkflowRunPullRequest()
        {
        }
    }
}