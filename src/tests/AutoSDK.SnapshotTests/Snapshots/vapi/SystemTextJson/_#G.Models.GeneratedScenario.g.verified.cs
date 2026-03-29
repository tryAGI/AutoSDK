//HintName: G.Models.GeneratedScenario.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GeneratedScenario
    {
        /// <summary>
        /// Short descriptive name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Instructions for the tester
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Instructions { get; set; }

        /// <summary>
        /// Scenario category
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.GeneratedScenarioCategoryJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GeneratedScenarioCategory Category { get; set; }

        /// <summary>
        /// Why this scenario is valuable
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Reasoning { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GeneratedScenario" /> class.
        /// </summary>
        /// <param name="name">
        /// Short descriptive name
        /// </param>
        /// <param name="instructions">
        /// Instructions for the tester
        /// </param>
        /// <param name="category">
        /// Scenario category
        /// </param>
        /// <param name="reasoning">
        /// Why this scenario is valuable
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GeneratedScenario(
            string name,
            string instructions,
            global::G.GeneratedScenarioCategory category,
            string reasoning)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Instructions = instructions ?? throw new global::System.ArgumentNullException(nameof(instructions));
            this.Category = category;
            this.Reasoning = reasoning ?? throw new global::System.ArgumentNullException(nameof(reasoning));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GeneratedScenario" /> class.
        /// </summary>
        public GeneratedScenario()
        {
        }
    }
}