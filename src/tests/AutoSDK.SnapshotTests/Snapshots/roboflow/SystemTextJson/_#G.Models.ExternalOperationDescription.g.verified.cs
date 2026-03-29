//HintName: G.Models.ExternalOperationDescription.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExternalOperationDescription
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operation_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OperationType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compound")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Compound { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_kind")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> InputKind { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_kind")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> OutputKind { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nested_operation_input_kind")]
        public global::System.Collections.Generic.IList<string>? NestedOperationInputKind { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nested_operation_output_kind")]
        public global::System.Collections.Generic.IList<string>? NestedOperationOutputKind { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// List of possible property names.             Optional parameter for operations extracting property values from data. 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("property_name_options")]
        public global::System.Collections.Generic.IList<string>? PropertyNameOptions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalOperationDescription" /> class.
        /// </summary>
        /// <param name="operationType"></param>
        /// <param name="compound"></param>
        /// <param name="inputKind"></param>
        /// <param name="outputKind"></param>
        /// <param name="nestedOperationInputKind"></param>
        /// <param name="nestedOperationOutputKind"></param>
        /// <param name="description"></param>
        /// <param name="propertyNameOptions">
        /// List of possible property names.             Optional parameter for operations extracting property values from data. 
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExternalOperationDescription(
            string operationType,
            bool compound,
            global::System.Collections.Generic.IList<string> inputKind,
            global::System.Collections.Generic.IList<string> outputKind,
            global::System.Collections.Generic.IList<string>? nestedOperationInputKind,
            global::System.Collections.Generic.IList<string>? nestedOperationOutputKind,
            string? description,
            global::System.Collections.Generic.IList<string>? propertyNameOptions)
        {
            this.OperationType = operationType ?? throw new global::System.ArgumentNullException(nameof(operationType));
            this.Compound = compound;
            this.InputKind = inputKind ?? throw new global::System.ArgumentNullException(nameof(inputKind));
            this.OutputKind = outputKind ?? throw new global::System.ArgumentNullException(nameof(outputKind));
            this.NestedOperationInputKind = nestedOperationInputKind;
            this.NestedOperationOutputKind = nestedOperationOutputKind;
            this.Description = description;
            this.PropertyNameOptions = propertyNameOptions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalOperationDescription" /> class.
        /// </summary>
        public ExternalOperationDescription()
        {
        }
    }
}