//HintName: G.Models.CollectionSchema.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CollectionSchema
    {
        /// <summary>
        /// Whether allows the primary field to automatically increment. Setting this to True makes the primary field automatically increment. In this case, the primary field should not be included in the data to insert to avoid errors. Set this parameter in the field with is_primary set to True.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("autoId", Required = global::Newtonsoft.Json.Required.Always)]
        public string AutoId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enableDynamicField", Required = global::Newtonsoft.Json.Required.Always)]
        public string EnableDynamicField { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fields", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.FieldSchema> Fields { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CollectionSchema" /> class.
        /// </summary>
        /// <param name="autoId">
        /// Whether allows the primary field to automatically increment. Setting this to True makes the primary field automatically increment. In this case, the primary field should not be included in the data to insert to avoid errors. Set this parameter in the field with is_primary set to True.
        /// </param>
        /// <param name="enableDynamicField"></param>
        /// <param name="fields"></param>
        public CollectionSchema(
            string autoId,
            string enableDynamicField,
            global::System.Collections.Generic.IList<global::G.FieldSchema> fields)
        {
            this.AutoId = autoId ?? throw new global::System.ArgumentNullException(nameof(autoId));
            this.EnableDynamicField = enableDynamicField ?? throw new global::System.ArgumentNullException(nameof(enableDynamicField));
            this.Fields = fields ?? throw new global::System.ArgumentNullException(nameof(fields));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CollectionSchema" /> class.
        /// </summary>
        public CollectionSchema()
        {
        }
    }
}