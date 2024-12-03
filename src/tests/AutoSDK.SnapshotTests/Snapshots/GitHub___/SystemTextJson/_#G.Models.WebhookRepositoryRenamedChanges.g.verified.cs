//HintName: G.Models.WebhookRepositoryRenamedChanges.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookRepositoryRenamedChanges
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebhookRepositoryRenamedChangesRepository Repository { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookRepositoryRenamedChanges" /> class.
        /// </summary>
        /// <param name="repository"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public WebhookRepositoryRenamedChanges(
            global::G.WebhookRepositoryRenamedChangesRepository repository)
        {
            this.Repository = repository ?? throw new global::System.ArgumentNullException(nameof(repository));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookRepositoryRenamedChanges" /> class.
        /// </summary>
        public WebhookRepositoryRenamedChanges()
        {
        }
    }
}