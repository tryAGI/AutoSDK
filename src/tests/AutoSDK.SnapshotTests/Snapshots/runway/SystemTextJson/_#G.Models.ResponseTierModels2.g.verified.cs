//HintName: G.Models.ResponseTierModels2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Limits associated with the model.
    /// </summary>
    public sealed partial class ResponseTierModels2
    {
        /// <summary>
        /// The maximum number of generations that can be run concurrently for this model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxConcurrentGenerations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxConcurrentGenerations { get; set; }

        /// <summary>
        /// The maximum number of generations that can be created each day for this model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxDailyGenerations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxDailyGenerations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseTierModels2" /> class.
        /// </summary>
        /// <param name="maxConcurrentGenerations">
        /// The maximum number of generations that can be run concurrently for this model.
        /// </param>
        /// <param name="maxDailyGenerations">
        /// The maximum number of generations that can be created each day for this model.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseTierModels2(
            int maxConcurrentGenerations,
            int maxDailyGenerations)
        {
            this.MaxConcurrentGenerations = maxConcurrentGenerations;
            this.MaxDailyGenerations = maxDailyGenerations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseTierModels2" /> class.
        /// </summary>
        public ResponseTierModels2()
        {
        }
    }
}