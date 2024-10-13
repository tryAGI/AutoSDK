//HintName: G.Models.ReferenceMetaClassification.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This meta field contains additional info about the classified reference property
    /// </summary>
    public sealed partial class ReferenceMetaClassification
    {
        /// <summary>
        /// overall neighbors checked as part of the classification. In most cases this will equal k, but could be lower than k - for example if not enough data was present
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("overallCount")]
        public double? OverallCount { get; set; }

        /// <summary>
        /// size of the winning group, a number between 1..k
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("winningCount")]
        public double? WinningCount { get; set; }

        /// <summary>
        /// size of the losing group, can be 0 if the winning group size equals k
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("losingCount")]
        public double? LosingCount { get; set; }

        /// <summary>
        /// The lowest distance of any neighbor, regardless of whether they were in the winning or losing group
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("closestOverallDistance")]
        public double? ClosestOverallDistance { get; set; }

        /// <summary>
        /// deprecated - do not use, to be removed in 0.23.0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("winningDistance")]
        public double? WinningDistance { get; set; }

        /// <summary>
        /// Mean distance of all neighbors from the winning group
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("meanWinningDistance")]
        public double? MeanWinningDistance { get; set; }

        /// <summary>
        /// Closest distance of a neighbor from the winning group
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("closestWinningDistance")]
        public double? ClosestWinningDistance { get; set; }

        /// <summary>
        /// The lowest distance of a neighbor in the losing group. Optional. If k equals the size of the winning group, there is no losing group
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("closestLosingDistance")]
        public double? ClosestLosingDistance { get; set; }

        /// <summary>
        /// deprecated - do not use, to be removed in 0.23.0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("losingDistance")]
        public double? LosingDistance { get; set; }

        /// <summary>
        /// Mean distance of all neighbors from the losing group. Optional. If k equals the size of the winning group, there is no losing group.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("meanLosingDistance")]
        public double? MeanLosingDistance { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.SerializeObject(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.ReferenceMetaClassification? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.ReferenceMetaClassification>(
                json,
                jsonSerializerOptions);
        }

    }
}