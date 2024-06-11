//HintName: G.Models.RunStepDeltaObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Represents a run step delta i.e. any changed fields on a run step during streaming.
    /// </summary>
    public sealed partial class RunStepDeltaObject
    {
        /// <summary>
        /// The identifier of the run step, which can be referenced in API endpoints.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The object type, which is always `thread.run.step.delta`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RunStepDeltaObjectObject Object { get; set; } = default!;

        /// <summary>
        /// The delta containing the fields that have changed on the run step.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("delta", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RunStepDeltaObjectDelta Delta { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}