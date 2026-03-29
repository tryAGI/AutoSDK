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
        [global::Newtonsoft.Json.JsonProperty("operator_type", Required = global::Newtonsoft.Json.Required.Always)]
        public string OperatorType { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("operands_number", Required = global::Newtonsoft.Json.Required.Always)]
        public int OperandsNumber { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("operands_kinds", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>> OperandsKinds { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalOperatorDescription" /> class.
        /// </summary>
        /// <param name="operatorType"></param>
        /// <param name="operandsNumber"></param>
        /// <param name="operandsKinds"></param>
        /// <param name="description"></param>
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