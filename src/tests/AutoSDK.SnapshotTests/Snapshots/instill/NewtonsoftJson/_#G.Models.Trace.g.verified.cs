//HintName: G.Models.Trace.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Trace contains the execution details of a component.
    /// </summary>
    public sealed partial class Trace
    {
        /// <summary>
        /// Statuses contains an execution status per input.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("statuses")]
        public global::System.Collections.Generic.IList<global::G.TraceStatus>? Statuses { get; set; }

        /// <summary>
        /// Component inputs.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inputs")]
        public global::System.Collections.Generic.IList<object>? Inputs { get; set; }

        /// <summary>
        /// Component outputs.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("outputs")]
        public global::System.Collections.Generic.IList<object>? Outputs { get; set; }

        /// <summary>
        /// Error details.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error")]
        public object? Error { get; set; }

        /// <summary>
        /// Computation time in seconds.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("computeTimeInSeconds")]
        public float? ComputeTimeInSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Trace" /> class.
        /// </summary>
        /// <param name="statuses">
        /// Statuses contains an execution status per input.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="inputs">
        /// Component inputs.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="outputs">
        /// Component outputs.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="error">
        /// Error details.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="computeTimeInSeconds">
        /// Computation time in seconds.<br/>
        /// Included only in responses
        /// </param>
        public Trace(
            global::System.Collections.Generic.IList<global::G.TraceStatus>? statuses,
            global::System.Collections.Generic.IList<object>? inputs,
            global::System.Collections.Generic.IList<object>? outputs,
            object? error,
            float? computeTimeInSeconds)
        {
            this.Statuses = statuses;
            this.Inputs = inputs;
            this.Outputs = outputs;
            this.Error = error;
            this.ComputeTimeInSeconds = computeTimeInSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Trace" /> class.
        /// </summary>
        public Trace()
        {
        }
    }
}