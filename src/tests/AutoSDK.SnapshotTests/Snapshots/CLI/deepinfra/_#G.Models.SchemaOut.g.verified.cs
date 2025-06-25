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
        [global::System.Text.Json.Serialization.JsonPropertyName("variant")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.SchemaVariant Variant { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema_in")]
        public object? SchemaIn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema_out")]
        public object? SchemaOut1 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema_stream")]
        public object? SchemaStream { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fields_in")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ModelFieldInfo> FieldsIn { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SchemaOut" /> class.
        /// </summary>
        /// <param name="variant"></param>
        /// <param name="schemaIn"></param>
        /// <param name="schemaOut1"></param>
        /// <param name="schemaStream"></param>
        /// <param name="fieldsIn"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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