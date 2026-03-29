//HintName: G.Models.ToolOutputParameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Schema definition of return values from the tool<br/>
    /// Example: {"run_id":{"type":"number","description":"ID of the workflow run that was triggered","example":12345678},"status":{"type":"string","description":"Status of the workflow run","example":"completed","enum":["queued","in_progress","completed","failed"]}}
    /// </summary>
    public sealed partial class ToolOutputParameters
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}