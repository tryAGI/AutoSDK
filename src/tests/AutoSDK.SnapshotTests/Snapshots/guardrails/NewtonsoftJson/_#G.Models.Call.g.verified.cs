//HintName: G.Models.Call.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Represents a single execution of a Guard.
    /// </summary>
    public sealed partial class Call
    {
        /// <summary>
        /// The unique identifier for this Call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("iterations")]
        public global::System.Collections.Generic.IList<global::G.Iteration>? Iterations { get; set; }

        /// <summary>
        /// The inputs for a Guard Call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inputs")]
        public global::G.CallInputs? Inputs { get; set; }

        /// <summary>
        /// Exception message if the call failed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("exception")]
        public string? Exception { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Call" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier for this Call.
        /// </param>
        /// <param name="iterations">
        /// Default Value: []
        /// </param>
        /// <param name="inputs">
        /// The inputs for a Guard Call.
        /// </param>
        /// <param name="exception">
        /// Exception message if the call failed.
        /// </param>
        public Call(
            string id,
            global::System.Collections.Generic.IList<global::G.Iteration>? iterations,
            global::G.CallInputs? inputs,
            string? exception)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Iterations = iterations;
            this.Inputs = inputs;
            this.Exception = exception;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Call" /> class.
        /// </summary>
        public Call()
        {
        }
    }
}