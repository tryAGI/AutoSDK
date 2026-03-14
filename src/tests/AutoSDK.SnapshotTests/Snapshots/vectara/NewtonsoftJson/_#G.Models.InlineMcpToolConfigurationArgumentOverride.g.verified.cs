//HintName: G.Models.InlineMcpToolConfigurationArgumentOverride.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Optional hardcoded arguments for tool calls. The key specifies the location in the tool arguments to overide, and the value specifies what to override with. The LLM will not be able to change the parameters, nor know those values exist within the tool.<br/>
    /// The values can also be dynamic references to context values using $ref with dot notation path syntax:<br/>
    /// - Static value: "fixed_value" or 123<br/>
    /// - Dynamic reference: `{"$ref": "session.metadata.field_name"}`<br/>
    /// References are resolved at runtime from context:<br/>
    /// - session.metadata.* - Access session metadata fields<br/>
    /// - agent.metadata.* - Access agent metadata fields<br/>
    /// Example:<br/>
    ///   `{"query": {"$ref": ".session.metadata.query"}}`<br/>
    /// If you want to have a real value `"$ref"` use `"$$ref"`, that is you can escape the first $ by using $$.<br/>
    /// Example: {"custom_param":"value","limit":10}
    /// </summary>
    public sealed partial class InlineMcpToolConfigurationArgumentOverride
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}