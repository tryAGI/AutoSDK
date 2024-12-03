//HintName: G.Models.WebhookStatusBrancheCommit.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookStatusBrancheCommit
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sha")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Sha { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookStatusBrancheCommit" /> class.
        /// </summary>
        /// <param name="sha"></param>
        /// <param name="url"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public WebhookStatusBrancheCommit(
            string? sha,
            string? url)
        {
            this.Sha = sha ?? throw new global::System.ArgumentNullException(nameof(sha));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookStatusBrancheCommit" /> class.
        /// </summary>
        public WebhookStatusBrancheCommit()
        {
        }
    }
}