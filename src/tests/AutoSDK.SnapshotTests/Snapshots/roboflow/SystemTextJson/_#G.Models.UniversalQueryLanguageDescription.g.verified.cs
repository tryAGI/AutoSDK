//HintName: G.Models.UniversalQueryLanguageDescription.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UniversalQueryLanguageDescription
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operations_description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ExternalOperationDescription> OperationsDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operators_descriptions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ExternalOperatorDescription> OperatorsDescriptions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UniversalQueryLanguageDescription" /> class.
        /// </summary>
        /// <param name="operationsDescription"></param>
        /// <param name="operatorsDescriptions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UniversalQueryLanguageDescription(
            global::System.Collections.Generic.IList<global::G.ExternalOperationDescription> operationsDescription,
            global::System.Collections.Generic.IList<global::G.ExternalOperatorDescription> operatorsDescriptions)
        {
            this.OperationsDescription = operationsDescription ?? throw new global::System.ArgumentNullException(nameof(operationsDescription));
            this.OperatorsDescriptions = operatorsDescriptions ?? throw new global::System.ArgumentNullException(nameof(operatorsDescriptions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UniversalQueryLanguageDescription" /> class.
        /// </summary>
        public UniversalQueryLanguageDescription()
        {
        }
    }
}