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
        [global::Newtonsoft.Json.JsonProperty("operations_description", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ExternalOperationDescription> OperationsDescription { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("operators_descriptions", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ExternalOperatorDescription> OperatorsDescriptions { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UniversalQueryLanguageDescription" /> class.
        /// </summary>
        /// <param name="operationsDescription"></param>
        /// <param name="operatorsDescriptions"></param>
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