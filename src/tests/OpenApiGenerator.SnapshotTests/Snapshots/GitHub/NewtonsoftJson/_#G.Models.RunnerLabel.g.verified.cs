//HintName: G.Models.RunnerLabel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A label for a self hosted runner
    /// </summary>
    public sealed partial class RunnerLabel
    {
        /// <summary>
        /// Unique identifier of the label.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Name of the label.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The type of label. Read-only labels are applied automatically when the runner is configured.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public RunnerLabelType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}