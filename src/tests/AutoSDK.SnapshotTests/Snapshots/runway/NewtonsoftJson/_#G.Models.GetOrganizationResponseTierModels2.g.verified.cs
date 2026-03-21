//HintName: G.Models.GetOrganizationResponseTierModels2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Limits associated with the model.
    /// </summary>
    public sealed partial class GetOrganizationResponseTierModels2
    {
        /// <summary>
        /// The maximum number of generations that can be run concurrently for this model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("maxConcurrentGenerations", Required = global::Newtonsoft.Json.Required.Always)]
        public int MaxConcurrentGenerations { get; set; } = default!;

        /// <summary>
        /// The maximum number of generations that can be created each day for this model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("maxDailyGenerations", Required = global::Newtonsoft.Json.Required.Always)]
        public int MaxDailyGenerations { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationResponseTierModels2" /> class.
        /// </summary>
        /// <param name="maxConcurrentGenerations">
        /// The maximum number of generations that can be run concurrently for this model.
        /// </param>
        /// <param name="maxDailyGenerations">
        /// The maximum number of generations that can be created each day for this model.
        /// </param>
        public GetOrganizationResponseTierModels2(
            int maxConcurrentGenerations,
            int maxDailyGenerations)
        {
            this.MaxConcurrentGenerations = maxConcurrentGenerations;
            this.MaxDailyGenerations = maxDailyGenerations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationResponseTierModels2" /> class.
        /// </summary>
        public GetOrganizationResponseTierModels2()
        {
        }
    }
}