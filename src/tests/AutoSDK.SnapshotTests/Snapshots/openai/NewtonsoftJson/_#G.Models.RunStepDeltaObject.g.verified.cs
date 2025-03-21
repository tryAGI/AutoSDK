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
        /// The delta containing the fields that have changed on the run step.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("delta", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RunStepDeltaObjectDelta Delta { get; set; } = default!;

        /// <summary>
        /// The identifier of the run step, which can be referenced in API endpoints.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The object type, which is always `thread.run.step.delta`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public global::G.RunStepDeltaObjectObject Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepDeltaObject" /> class.
        /// </summary>
        /// <param name="delta">
        /// The delta containing the fields that have changed on the run step.
        /// </param>
        /// <param name="id">
        /// The identifier of the run step, which can be referenced in API endpoints.
        /// </param>
        /// <param name="object">
        /// The object type, which is always `thread.run.step.delta`.
        /// </param>
        public RunStepDeltaObject(
            global::G.RunStepDeltaObjectDelta delta,
            string id,
            global::G.RunStepDeltaObjectObject @object)
        {
            this.Delta = delta ?? throw new global::System.ArgumentNullException(nameof(delta));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepDeltaObject" /> class.
        /// </summary>
        public RunStepDeltaObject()
        {
        }
    }
}