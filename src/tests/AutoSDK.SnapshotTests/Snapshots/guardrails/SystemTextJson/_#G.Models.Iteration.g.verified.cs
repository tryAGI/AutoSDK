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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The zero-based index of this iteration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Index { get; set; }

        /// <summary>
        /// The unique identifier for the Call this iteration belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CallId { get; set; }

        /// <summary>
        /// Input parameters for an iteration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs")]
        public global::G.Inputs? Inputs { get; set; }

        /// <summary>
        /// Output data from an iteration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputs")]
        public global::G.Outputs? Outputs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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