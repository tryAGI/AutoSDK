//HintName: G.Models.TextInsightFromCallTableFormula.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formulas are mathematical expressions applied on the data returned by the queries to transform them before being used to create the insight.<br/>
    /// The formulas needs to be a valid mathematical expression, supported by MathJS - https://mathjs.org/docs/expressions/syntax.html<br/>
    /// A formula is created by using the query names as the variable.<br/>
    /// The formulas must contain at least one query name in the LiquidJS format {{query_name}} or {{['query name']}} which will be substituted with the query result.<br/>
    /// For example, if you have 2 queries, 'Was Booking Made' and 'Average Call Duration', you can create a formula like this:<br/>
    /// ```<br/>
    /// {{['Query 1']}} / {{['Query 2']}} * 100<br/>
    /// ```<br/>
    /// ```<br/>
    /// ({{[Query 1]}} * 10) + {{[Query 2]}}<br/>
    /// ```<br/>
    /// This will take the<br/>
    /// You can also use the query names as the variable in the formula.
    /// </summary>
    public sealed partial class TextInsightFromCallTableFormula
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}