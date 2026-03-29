//HintName: G.Models.ModelCalculateOperation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Mathematical operation for cost calculation
    /// </summary>
    public sealed partial class ModelCalculateOperation
    {
        /// <summary>
        /// Operation type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ModelCalculateOperationOperationJsonConverter))]
        public global::G.ModelCalculateOperationOperation? Operation { get; set; }

        /// <summary>
        /// Operands for the operation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operands")]
        public global::System.Collections.Generic.IList<global::G.OneOf<global::G.ModelCalculateOperation, global::G.ModelValueReference>>? Operands { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelCalculateOperation" /> class.
        /// </summary>
        /// <param name="operation">
        /// Operation type
        /// </param>
        /// <param name="operands">
        /// Operands for the operation
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelCalculateOperation(
            global::G.ModelCalculateOperationOperation? operation,
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.ModelCalculateOperation, global::G.ModelValueReference>>? operands)
        {
            this.Operation = operation;
            this.Operands = operands;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelCalculateOperation" /> class.
        /// </summary>
        public ModelCalculateOperation()
        {
        }
    }
}