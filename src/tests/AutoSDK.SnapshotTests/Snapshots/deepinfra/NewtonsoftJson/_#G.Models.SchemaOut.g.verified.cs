//HintName: G.Models.SchemaOut.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SchemaOut
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("variant", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SchemaVariant Variant { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("schema_in")]
        public object? SchemaIn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("schema_out")]
        public object? SchemaOut1 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("schema_stream")]
        public object? SchemaStream { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fields_in", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ModelFieldInfo> FieldsIn { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SchemaOut" /> class.
        /// </summary>
        /// <param name="variant"></param>
        /// <param name="schemaIn"></param>
        /// <param name="schemaOut1"></param>
        /// <param name="schemaStream"></param>
        /// <param name="fieldsIn"></param>
        public SchemaOut(
            global::G.SchemaVariant variant,
            global::System.Collections.Generic.IList<global::G.ModelFieldInfo> fieldsIn,
            object? schemaIn,
            object? schemaOut1,
            object? schemaStream)
        {
            this.Variant = variant ?? throw new global::System.ArgumentNullException(nameof(variant));
            this.FieldsIn = fieldsIn ?? throw new global::System.ArgumentNullException(nameof(fieldsIn));
            this.SchemaIn = schemaIn;
            this.SchemaOut1 = schemaOut1;
            this.SchemaStream = schemaStream;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SchemaOut" /> class.
        /// </summary>
        public SchemaOut()
        {
        }
    }
}