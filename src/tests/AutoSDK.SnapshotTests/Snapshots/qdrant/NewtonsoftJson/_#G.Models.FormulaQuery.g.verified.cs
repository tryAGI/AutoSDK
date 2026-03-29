//HintName: G.Models.FormulaQuery.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FormulaQuery
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("formula", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Expression Formula { get; set; } = default!;

        /// <summary>
        /// Default Value: {}
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("defaults")]
        public object? Defaults { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FormulaQuery" /> class.
        /// </summary>
        /// <param name="formula"></param>
        /// <param name="defaults">
        /// Default Value: {}
        /// </param>
        public FormulaQuery(
            global::G.Expression formula,
            object? defaults)
        {
            this.Formula = formula;
            this.Defaults = defaults;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FormulaQuery" /> class.
        /// </summary>
        public FormulaQuery()
        {
        }
    }
}