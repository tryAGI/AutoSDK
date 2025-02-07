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
        [global::System.Text.Json.Serialization.JsonPropertyName("property_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PropertyName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookCustomPropertyDeletedDefinition" /> class.
        /// </summary>
        /// <param name="propertyName">
        /// The name of the property that was deleted.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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