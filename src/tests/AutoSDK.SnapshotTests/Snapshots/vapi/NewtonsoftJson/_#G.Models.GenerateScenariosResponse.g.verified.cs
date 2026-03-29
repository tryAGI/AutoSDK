//HintName: G.Models.GenerateScenariosResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerateScenariosResponse
    {
        /// <summary>
        /// Generated scenarios
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("scenarios", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.GeneratedScenario> Scenarios { get; set; } = default!;

        /// <summary>
        /// Summary of test coverage
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("coverageNotes", Required = global::Newtonsoft.Json.Required.Always)]
        public string CoverageNotes { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateScenariosResponse" /> class.
        /// </summary>
        /// <param name="scenarios">
        /// Generated scenarios
        /// </param>
        /// <param name="coverageNotes">
        /// Summary of test coverage
        /// </param>
        public GenerateScenariosResponse(
            global::System.Collections.Generic.IList<global::G.GeneratedScenario> scenarios,
            string coverageNotes)
        {
            this.Scenarios = scenarios ?? throw new global::System.ArgumentNullException(nameof(scenarios));
            this.CoverageNotes = coverageNotes ?? throw new global::System.ArgumentNullException(nameof(coverageNotes));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateScenariosResponse" /> class.
        /// </summary>
        public GenerateScenariosResponse()
        {
        }
    }
}