//HintName: G.Models.ExternalOperatorDescription.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExternalOperatorDescription
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operator_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OperatorType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operands_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OperandsNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operands_kinds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>> OperandsKinds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalOperatorDescription" /> class.
        /// </summary>
        /// <param name="operatorType"></param>
        /// <param name="operandsNumber"></param>
        /// <param name="operandsKinds"></param>
        /// <param name="description"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExternalOperatorDescription(
            string operatorType,
            int operandsNumber,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>> operandsKinds,
            string? description)
        {
            this.OperatorType = operatorType ?? throw new global::System.ArgumentNullException(nameof(operatorType));
            this.OperandsNumber = operandsNumber;
            this.OperandsKinds = operandsKinds ?? throw new global::System.ArgumentNullException(nameof(operandsKinds));
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalOperatorDescription" /> class.
        /// </summary>
        public ExternalOperatorDescription()
        {
        }
    }
}