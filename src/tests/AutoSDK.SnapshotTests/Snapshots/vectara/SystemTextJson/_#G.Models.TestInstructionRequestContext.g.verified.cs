//HintName: G.Models.TestInstructionRequestContext.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Context data to use when rendering the instruction template. This will be merged into `$session.metadata` for template access.<br/>
    /// Example: If you provide `{"currentDate": "2024-01-15"}`, you can access it in the template as `$session.metadata.currentDate`.<br/>
    /// Example: {"currentDate":"2024-01-15","companyName":"Acme Corp"}
    /// </summary>
    public sealed partial class TestInstructionRequestContext
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}