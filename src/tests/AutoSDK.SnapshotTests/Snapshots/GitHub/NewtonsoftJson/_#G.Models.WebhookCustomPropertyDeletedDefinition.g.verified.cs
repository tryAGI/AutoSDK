//HintName: G.Models.WebhookCustomPropertyDeletedDefinition.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookCustomPropertyDeletedDefinition
    {
        /// <summary>
        /// The name of the property that was deleted.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("property_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string PropertyName { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookCustomPropertyDeletedDefinition" /> class.
        /// </summary>
        /// <param name="propertyName">
        /// The name of the property that was deleted.
        /// </param>
        public WebhookCustomPropertyDeletedDefinition(
            string propertyName)
        {
            this.PropertyName = propertyName ?? throw new global::System.ArgumentNullException(nameof(propertyName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookCustomPropertyDeletedDefinition" /> class.
        /// </summary>
        public WebhookCustomPropertyDeletedDefinition()
        {
        }
    }
}