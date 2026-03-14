//HintName: G.Models.TestLambdaToolResponseInputSchema.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The discovered input schema from type annotations. May be null if validation failed or no type hints provided.<br/>
    /// Example: {"type":"object","properties":{"order_count":{"type":"integer"},"total_revenue":{"type":"number"}},"required":["order_count","total_revenue"]}
    /// </summary>
    public sealed partial class TestLambdaToolResponseInputSchema
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}