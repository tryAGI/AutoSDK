//HintName: G.Models.TestLambdaToolRequestTestInput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The input parameters to test the function with. Will be validated against the discovered input schema.<br/>
    /// Example: {"order_count":10,"total_revenue":500}
    /// </summary>
    public sealed partial class TestLambdaToolRequestTestInput
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}