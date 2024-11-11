//HintName: G.Models.WebhookRepositoryTransferredChanges.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookRepositoryTransferredChanges
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("owner", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookRepositoryTransferredChangesOwner Owner { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookRepositoryTransferredChanges" /> class.
        /// </summary>
        /// <param name="owner"></param>
        public WebhookRepositoryTransferredChanges(
            global::G.WebhookRepositoryTransferredChangesOwner owner)
        {
            this.Owner = owner ?? throw new global::System.ArgumentNullException(nameof(owner));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookRepositoryTransferredChanges" /> class.
        /// </summary>
        public WebhookRepositoryTransferredChanges()
        {
        }
    }
}