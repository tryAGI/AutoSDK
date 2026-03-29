//HintName: G.Models.FieldSchemaElementTypeParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Extra field parameters.
    /// </summary>
    public sealed partial class FieldSchemaElementTypeParams
    {
        /// <summary>
        /// An optional parameter for VarChar values that determines the maximum length of the value in the current field.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_length", Required = global::Newtonsoft.Json.Required.Always)]
        public string MaxLength { get; set; } = default!;

        /// <summary>
        /// An optional parameter for FloatVector or BinaryVector fields that determines the vector dimension.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dim", Required = global::Newtonsoft.Json.Required.Always)]
        public string Dim { get; set; } = default!;

        /// <summary>
        /// An optional parameter for Array field values that determines the maximum number of elements in the current array field.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_capacity", Required = global::Newtonsoft.Json.Required.Always)]
        public string MaxCapacity { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FieldSchemaElementTypeParams" /> class.
        /// </summary>
        /// <param name="maxLength">
        /// An optional parameter for VarChar values that determines the maximum length of the value in the current field.
        /// </param>
        /// <param name="dim">
        /// An optional parameter for FloatVector or BinaryVector fields that determines the vector dimension.
        /// </param>
        /// <param name="maxCapacity">
        /// An optional parameter for Array field values that determines the maximum number of elements in the current array field.
        /// </param>
        public FieldSchemaElementTypeParams(
            string maxLength,
            string dim,
            string maxCapacity)
        {
            this.MaxLength = maxLength ?? throw new global::System.ArgumentNullException(nameof(maxLength));
            this.Dim = dim ?? throw new global::System.ArgumentNullException(nameof(dim));
            this.MaxCapacity = maxCapacity ?? throw new global::System.ArgumentNullException(nameof(maxCapacity));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FieldSchemaElementTypeParams" /> class.
        /// </summary>
        public FieldSchemaElementTypeParams()
        {
        }
    }
}