//HintName: G.Models.KeyVariant5.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class KeyVariant5
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("MetadataField", Required = global::Newtonsoft.Json.Required.Always)]
        public string MetadataField { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KeyVariant5" /> class.
        /// </summary>
        /// <param name="metadataField"></param>
        public KeyVariant5(
            string metadataField)
        {
            this.MetadataField = metadataField ?? throw new global::System.ArgumentNullException(nameof(metadataField));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KeyVariant5" /> class.
        /// </summary>
        public KeyVariant5()
        {
        }
    }
}