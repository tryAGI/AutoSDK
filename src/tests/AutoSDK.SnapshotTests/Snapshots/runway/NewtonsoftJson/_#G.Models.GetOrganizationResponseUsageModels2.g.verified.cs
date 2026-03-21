//HintName: G.Models.GetOrganizationResponseUsageModels2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Usage data for the model.
    /// </summary>
    public sealed partial class GetOrganizationResponseUsageModels2
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
        /// Initializes a new instance of the <see cref="GetOrganizationResponseUsageModels2" /> class.
        /// </summary>
        /// <param name="dailyGenerations">
        /// The number of generations that have been run for this model in the past day.
        /// </param>
        public GetOrganizationResponseUsageModels2(
            int dailyGenerations)
        {
            this.DailyGenerations = dailyGenerations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationResponseUsageModels2" /> class.
        /// </summary>
        public GetOrganizationResponseUsageModels2()
        {
        }
    }
}