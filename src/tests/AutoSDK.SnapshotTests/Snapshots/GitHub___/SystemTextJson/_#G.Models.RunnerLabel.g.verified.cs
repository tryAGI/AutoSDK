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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Name of the label.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The type of label. Read-only labels are applied automatically when the runner is configured.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RunnerLabelTypeJsonConverter))]
        public global::G.RunnerLabelType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunnerLabel" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the label.
        /// </param>
        /// <param name="name">
        /// Name of the label.
        /// </param>
        /// <param name="type">
        /// The type of label. Read-only labels are applied automatically when the runner is configured.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public RunnerLabel(
            string name,
            int? id,
            global::G.RunnerLabelType? type)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Id = id;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunnerLabel" /> class.
        /// </summary>
        public RunnerLabel()
        {
        }
    }
}