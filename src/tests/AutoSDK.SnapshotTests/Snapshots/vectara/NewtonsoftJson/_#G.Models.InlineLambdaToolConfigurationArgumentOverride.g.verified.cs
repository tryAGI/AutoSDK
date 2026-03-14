//HintName: G.Models.InlineLambdaToolConfigurationArgumentOverride.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Optional hardcoded arguments that will be passed to the lambda function. When specified, these values will be used instead of allowing the LLM to fill in those parameters.<br/>
    /// Example: {"custom_param":"value"}
    /// </summary>
    public sealed partial class InlineLambdaToolConfigurationArgumentOverride
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}