//HintName: G.Models.PredictionHumanInput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Return human feedback and resume execution from a stopped checkpoint<br/>
    /// Example: {"type":"reject","feedback":"Include more emoji"}
    /// </summary>
    public sealed partial class PredictionHumanInput
    {
        /// <summary>
        /// Type of human input response<br/>
        /// Example: reject
        /// </summary>
        /// <example>reject</example>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.PredictionHumanInputType? Type { get; set; }

        /// <summary>
        /// Feedback to the last output<br/>
        /// Example: Include more emoji
        /// </summary>
        /// <example>Include more emoji</example>
        [global::Newtonsoft.Json.JsonProperty("feedback")]
        public string? Feedback { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PredictionHumanInput" /> class.
        /// </summary>
        /// <param name="type">
        /// Type of human input response<br/>
        /// Example: reject
        /// </param>
        /// <param name="feedback">
        /// Feedback to the last output<br/>
        /// Example: Include more emoji
        /// </param>
        public PredictionHumanInput(
            global::G.PredictionHumanInputType? type,
            string? feedback)
        {
            this.Type = type;
            this.Feedback = feedback;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PredictionHumanInput" /> class.
        /// </summary>
        public PredictionHumanInput()
        {
        }
    }
}