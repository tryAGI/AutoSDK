//HintName: G.Models.TestToolRequestInput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The input parameters to pass to the function. Must match the tool's input schema.<br/>
    /// Example: {"number":42,"text":"Hello, world!"}
    /// </summary>
    public sealed partial class TestToolRequestInput
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}