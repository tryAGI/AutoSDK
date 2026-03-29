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
        [global::System.Text.Json.Serialization.JsonPropertyName("autoId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AutoId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enableDynamicField")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EnableDynamicField { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fields")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.FieldSchema> Fields { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CollectionSchema" /> class.
        /// </summary>
        /// <param name="autoId">
        /// Whether allows the primary field to automatically increment. Setting this to True makes the primary field automatically increment. In this case, the primary field should not be included in the data to insert to avoid errors. Set this parameter in the field with is_primary set to True.
        /// </param>
        /// <param name="enableDynamicField"></param>
        /// <param name="fields"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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