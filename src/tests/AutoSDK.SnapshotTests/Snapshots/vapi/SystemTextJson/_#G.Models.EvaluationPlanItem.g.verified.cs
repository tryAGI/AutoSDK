//HintName: G.Models.EvaluationPlanItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EvaluationPlanItem
    {
        /// <summary>
        /// This is the ID of an existing structured output to use for evaluation.<br/>
        /// Mutually exclusive with structuredOutput.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("structuredOutputId")]
        public global::System.Guid? StructuredOutputId { get; set; }

        /// <summary>
        /// This is an inline structured output definition for evaluation.<br/>
        /// Mutually exclusive with structuredOutputId.<br/>
        /// Only primitive schema types (string, number, integer, boolean) are allowed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("structuredOutput")]
        public global::G.CreateStructuredOutputDTO? StructuredOutput { get; set; }

        /// <summary>
        /// This is the comparison operator to use when evaluating the extracted value against the expected value.<br/>
        /// Available operators depend on the structured output's schema type:<br/>
        /// - boolean: '=', '!='<br/>
        /// - string: '=', '!='<br/>
        /// - number/integer: '=', '!=', '&gt;', '&lt;', '&gt;=', '&lt;='<br/>
        /// Example: =
        /// </summary>
        /// <example>=</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("comparator")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.EvaluationPlanItemComparatorJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.EvaluationPlanItemComparator Comparator { get; set; }

        /// <summary>
        /// This is the expected value to compare against the extracted structured output result.<br/>
        /// Type should match the structured output's schema type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<double?, string, bool?>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OneOf<double?, string, bool?> Value { get; set; }

        /// <summary>
        /// This is whether this evaluation must pass for the simulation to pass.<br/>
        /// Defaults to true. If false, the result is informational only.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required")]
        public bool? Required { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationPlanItem" /> class.
        /// </summary>
        /// <param name="comparator">
        /// This is the comparison operator to use when evaluating the extracted value against the expected value.<br/>
        /// Available operators depend on the structured output's schema type:<br/>
        /// - boolean: '=', '!='<br/>
        /// - string: '=', '!='<br/>
        /// - number/integer: '=', '!=', '&gt;', '&lt;', '&gt;=', '&lt;='<br/>
        /// Example: =
        /// </param>
        /// <param name="value">
        /// This is the expected value to compare against the extracted structured output result.<br/>
        /// Type should match the structured output's schema type.
        /// </param>
        /// <param name="structuredOutputId">
        /// This is the ID of an existing structured output to use for evaluation.<br/>
        /// Mutually exclusive with structuredOutput.
        /// </param>
        /// <param name="structuredOutput">
        /// This is an inline structured output definition for evaluation.<br/>
        /// Mutually exclusive with structuredOutputId.<br/>
        /// Only primitive schema types (string, number, integer, boolean) are allowed.
        /// </param>
        /// <param name="required">
        /// This is whether this evaluation must pass for the simulation to pass.<br/>
        /// Defaults to true. If false, the result is informational only.<br/>
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvaluationPlanItem(
            global::G.EvaluationPlanItemComparator comparator,
            global::G.OneOf<double?, string, bool?> value,
            global::System.Guid? structuredOutputId,
            global::G.CreateStructuredOutputDTO? structuredOutput,
            bool? required)
        {
            this.StructuredOutputId = structuredOutputId;
            this.StructuredOutput = structuredOutput;
            this.Comparator = comparator;
            this.Value = value;
            this.Required = required;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationPlanItem" /> class.
        /// </summary>
        public EvaluationPlanItem()
        {
        }
    }
}