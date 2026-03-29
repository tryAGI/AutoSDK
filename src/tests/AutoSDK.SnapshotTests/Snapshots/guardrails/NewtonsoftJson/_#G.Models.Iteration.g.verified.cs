//HintName: G.Models.Iteration.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Represents a single iteration within a Guard Call.
    /// </summary>
    public sealed partial class Iteration
    {
        /// <summary>
        /// The unique identifier for this iteration.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The zero-based index of this iteration.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("index", Required = global::Newtonsoft.Json.Required.Always)]
        public int Index { get; set; } = default!;

        /// <summary>
        /// The unique identifier for the Call this iteration belongs to.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("callId", Required = global::Newtonsoft.Json.Required.Always)]
        public string CallId { get; set; } = default!;

        /// <summary>
        /// Input parameters for an iteration.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inputs")]
        public global::G.Inputs? Inputs { get; set; }

        /// <summary>
        /// Output data from an iteration.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("outputs")]
        public global::G.Outputs? Outputs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Iteration" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier for this iteration.
        /// </param>
        /// <param name="index">
        /// The zero-based index of this iteration.
        /// </param>
        /// <param name="callId">
        /// The unique identifier for the Call this iteration belongs to.
        /// </param>
        /// <param name="inputs">
        /// Input parameters for an iteration.
        /// </param>
        /// <param name="outputs">
        /// Output data from an iteration.
        /// </param>
        public Iteration(
            string id,
            int index,
            string callId,
            global::G.Inputs? inputs,
            global::G.Outputs? outputs)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Index = index;
            this.CallId = callId ?? throw new global::System.ArgumentNullException(nameof(callId));
            this.Inputs = inputs;
            this.Outputs = outputs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Iteration" /> class.
        /// </summary>
        public Iteration()
        {
        }
    }
}