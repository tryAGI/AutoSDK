//HintName: G.Models.RunStreamEventVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Occurs when a new [run](/docs/api-reference/runs/object) is created.
    /// </summary>
    public sealed partial class RunStreamEventVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RunStreamEventVariant1Event Event { get; set; } = default!;

        /// <summary>
        /// Represents an execution run on a [thread](/docs/api-reference/threads).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RunObject? Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}