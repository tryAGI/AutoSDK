//HintName: G.Models.TestLambdaToolResponseOutputSchema.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The discovered output schema from type annotations. May be null if validation failed or no type hints provided.<br/>
    /// Example: {"type":"object","properties":{"score":{"type":"number"}}}
    /// </summary>
    public sealed partial class TestLambdaToolResponseOutputSchema
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}