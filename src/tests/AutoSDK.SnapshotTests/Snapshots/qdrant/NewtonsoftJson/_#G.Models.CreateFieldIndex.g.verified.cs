//HintName: G.Models.CreateFieldIndex.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateFieldIndex
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("field_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string FieldName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("field_schema")]
        public global::G.PayloadFieldSchema? FieldSchema { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFieldIndex" /> class.
        /// </summary>
        /// <param name="fieldName"></param>
        /// <param name="fieldSchema"></param>
        public CreateFieldIndex(
            string fieldName,
            global::G.PayloadFieldSchema? fieldSchema)
        {
            this.FieldName = fieldName ?? throw new global::System.ArgumentNullException(nameof(fieldName));
            this.FieldSchema = fieldSchema;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFieldIndex" /> class.
        /// </summary>
        public CreateFieldIndex()
        {
        }
    }
}