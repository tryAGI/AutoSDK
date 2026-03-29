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
        [global::System.Text.Json.Serialization.JsonPropertyName("max_length")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MaxLength { get; set; }

        /// <summary>
        /// An optional parameter for FloatVector or BinaryVector fields that determines the vector dimension.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dim")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Dim { get; set; }

        /// <summary>
        /// An optional parameter for Array field values that determines the maximum number of elements in the current array field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_capacity")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MaxCapacity { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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