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
        public string? Sha { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookStatusBrancheCommit(
            string? sha,
            string? url)
        {
            this.Sha = sha;
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookStatusBrancheCommit" /> class.
        /// </summary>
        public WebhookStatusBrancheCommit()
        {
        }
    }
}