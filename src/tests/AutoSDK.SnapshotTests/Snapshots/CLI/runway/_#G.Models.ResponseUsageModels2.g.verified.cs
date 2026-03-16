//HintName: G.Models.ResponseUsageModels2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Usage data for the model.
    /// </summary>
    public sealed partial class ResponseUsageModels2
    {
        /// <summary>
        /// The number of generations that have been run for this model in the past day.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dailyGenerations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DailyGenerations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseUsageModels2" /> class.
        /// </summary>
        /// <param name="dailyGenerations">
        /// The number of generations that have been run for this model in the past day.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseUsageModels2(
            int dailyGenerations)
        {
            this.DailyGenerations = dailyGenerations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseUsageModels2" /> class.
        /// </summary>
        public ResponseUsageModels2()
        {
        }
    }
}