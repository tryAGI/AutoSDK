//HintName: G.Models.TuningExamples.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A set of tuning examples. Can be training or validation data.
    /// </summary>
    public sealed partial class TuningExamples
    {
        /// <summary>
        /// The examples. Example input can be for text or discuss, but all examples in a set must be of the same type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("examples")]
        public global::System.Collections.Generic.IList<global::G.TuningExample>? Examples { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TuningExamples" /> class.
        /// </summary>
        /// <param name="examples">
        /// The examples. Example input can be for text or discuss, but all examples in a set must be of the same type.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TuningExamples(
            global::System.Collections.Generic.IList<global::G.TuningExample>? examples)
        {
            this.Examples = examples;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TuningExamples" /> class.
        /// </summary>
        public TuningExamples()
        {
        }
    }
}