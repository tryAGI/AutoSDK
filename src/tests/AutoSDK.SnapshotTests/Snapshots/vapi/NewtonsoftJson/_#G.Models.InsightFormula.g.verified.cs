//HintName: G.Models.InsightFormula.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InsightFormula
    {
        /// <summary>
        /// This is the name of the formula.<br/>
        /// It will be used to label the formula in the insight board on the UI.<br/>
        /// Example: Booking Rate
        /// </summary>
        /// <example>Booking Rate</example>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// This is the formula to calculate the insight from the queries.<br/>
        /// The formula needs to be a valid mathematical expression.<br/>
        /// The formula must contain at least one query name in the LiquidJS format {{query_name}} or {{['query name']}} which will be substituted with the query result.<br/>
        /// Any MathJS formula is allowed - https://mathjs.org/docs/expressions/syntax.html<br/>
        /// Common valid math operations are +, -, *, /, %
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("formula", Required = global::Newtonsoft.Json.Required.Always)]
        public string Formula { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InsightFormula" /> class.
        /// </summary>
        /// <param name="formula">
        /// This is the formula to calculate the insight from the queries.<br/>
        /// The formula needs to be a valid mathematical expression.<br/>
        /// The formula must contain at least one query name in the LiquidJS format {{query_name}} or {{['query name']}} which will be substituted with the query result.<br/>
        /// Any MathJS formula is allowed - https://mathjs.org/docs/expressions/syntax.html<br/>
        /// Common valid math operations are +, -, *, /, %
        /// </param>
        /// <param name="name">
        /// This is the name of the formula.<br/>
        /// It will be used to label the formula in the insight board on the UI.<br/>
        /// Example: Booking Rate
        /// </param>
        public InsightFormula(
            string formula,
            string? name)
        {
            this.Name = name;
            this.Formula = formula ?? throw new global::System.ArgumentNullException(nameof(formula));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InsightFormula" /> class.
        /// </summary>
        public InsightFormula()
        {
        }
    }
}