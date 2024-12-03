//HintName: G.Models.WebhookProjectsV2ItemEditedChangesVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookProjectsV2ItemEditedChangesVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("field_value", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookProjectsV2ItemEditedChangesVariant1FieldValue FieldValue { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookProjectsV2ItemEditedChangesVariant1" /> class.
        /// </summary>
        /// <param name="fieldValue"></param>
        public WebhookProjectsV2ItemEditedChangesVariant1(
            global::G.WebhookProjectsV2ItemEditedChangesVariant1FieldValue fieldValue)
        {
            this.FieldValue = fieldValue ?? throw new global::System.ArgumentNullException(nameof(fieldValue));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookProjectsV2ItemEditedChangesVariant1" /> class.
        /// </summary>
        public WebhookProjectsV2ItemEditedChangesVariant1()
        {
        }
    }
}