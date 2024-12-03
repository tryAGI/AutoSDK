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
        [global::Newtonsoft.Json.JsonProperty("repository", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookRepositoryRenamedChangesRepository Repository { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookRepositoryRenamedChanges" /> class.
        /// </summary>
        /// <param name="repository"></param>
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