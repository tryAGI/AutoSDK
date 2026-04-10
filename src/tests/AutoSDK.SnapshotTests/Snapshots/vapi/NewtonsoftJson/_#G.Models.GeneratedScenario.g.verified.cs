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
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Instructions for the tester
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("instructions", Required = global::Newtonsoft.Json.Required.Always)]
        public string Instructions { get; set; } = default!;

        /// <summary>
        /// Scenario category
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("category", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.GeneratedScenarioCategoryJsonConverter))]
        public global::G.GeneratedScenarioCategory Category { get; set; } = default!;

        /// <summary>
        /// Why this scenario is valuable
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reasoning", Required = global::Newtonsoft.Json.Required.Always)]
        public string Reasoning { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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