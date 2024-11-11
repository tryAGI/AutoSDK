//HintName: G.Models.WebhookRepositoryRenamedChangesRepository.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookRepositoryRenamedChangesRepository
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookRepositoryRenamedChangesRepositoryName Name { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookRepositoryRenamedChangesRepository" /> class.
        /// </summary>
        /// <param name="name"></param>
        public WebhookRepositoryRenamedChangesRepository(
            global::G.WebhookRepositoryRenamedChangesRepositoryName name)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookRepositoryRenamedChangesRepository" /> class.
        /// </summary>
        public WebhookRepositoryRenamedChangesRepository()
        {
        }
    }
}