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
        [global::System.Text.Json.Serialization.JsonPropertyName("scenarios")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.GeneratedScenario> Scenarios { get; set; }

        /// <summary>
        /// Summary of test coverage
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("coverageNotes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CoverageNotes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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