//HintName: G.Models.WebhookStatusBranche.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookStatusBranche
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebhookStatusBrancheCommit Commit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("protected")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Protected { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookStatusBranche" /> class.
        /// </summary>
        /// <param name="commit"></param>
        /// <param name="name"></param>
        /// <param name="protected"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookStatusBranche(
            global::G.WebhookStatusBrancheCommit commit,
            string name,
            bool @protected)
        {
            this.Commit = commit ?? throw new global::System.ArgumentNullException(nameof(commit));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Protected = @protected;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookStatusBranche" /> class.
        /// </summary>
        public WebhookStatusBranche()
        {
        }
    }
}