//HintName: G.Models.RunStepStreamEventVariant7.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Occurs when a [run step](/docs/api-reference/runs/step-object) expires.
    /// </summary>
    public sealed partial class RunStepStreamEventVariant7
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RunStepStreamEventVariant7Event Event { get; set; } = default!;

        /// <summary>
        /// Represents a step in execution of a run.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RunStepObject? Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}