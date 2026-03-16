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
        [global::Newtonsoft.Json.JsonProperty("dailyGenerations", Required = global::Newtonsoft.Json.Required.Always)]
        public int DailyGenerations { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseUsageModels2" /> class.
        /// </summary>
        /// <param name="dailyGenerations">
        /// The number of generations that have been run for this model in the past day.
        /// </param>
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