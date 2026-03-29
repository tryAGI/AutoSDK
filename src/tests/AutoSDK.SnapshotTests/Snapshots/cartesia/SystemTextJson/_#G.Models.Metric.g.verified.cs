//HintName: G.Models.Metric.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Metric
    {
        /// <summary>
        /// The unique identifier for the metric.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The name of the metric. This is a unique name that you can use to identify the metric in the CLI.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The display name of the metric, if available. This is the name that is displayed in the Playground.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// The prompt associated with the metric, detailing the task and evaluation criteria.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// The timestamp when the metric was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Metric" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier for the metric.
        /// </param>
        /// <param name="name">
        /// The name of the metric. This is a unique name that you can use to identify the metric in the CLI.
        /// </param>
        /// <param name="prompt">
        /// The prompt associated with the metric, detailing the task and evaluation criteria.
        /// </param>
        /// <param name="createdAt">
        /// The timestamp when the metric was created.
        /// </param>
        /// <param name="displayName">
        /// The display name of the metric, if available. This is the name that is displayed in the Playground.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Metric(
            string id,
            string name,
            string prompt,
            global::System.DateTime createdAt,
            string? displayName)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.DisplayName = displayName;
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Metric" /> class.
        /// </summary>
        public Metric()
        {
        }
    }
}