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
        [global::System.Text.Json.Serialization.JsonPropertyName("overallCount")]
        public double? OverallCount { get; set; }

        /// <summary>
        /// size of the winning group, a number between 1..k
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("winningCount")]
        public double? WinningCount { get; set; }

        /// <summary>
        /// size of the losing group, can be 0 if the winning group size equals k
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("losingCount")]
        public double? LosingCount { get; set; }

        /// <summary>
        /// The lowest distance of any neighbor, regardless of whether they were in the winning or losing group
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("closestOverallDistance")]
        public double? ClosestOverallDistance { get; set; }

        /// <summary>
        /// deprecated - do not use, to be removed in 0.23.0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("winningDistance")]
        public double? WinningDistance { get; set; }

        /// <summary>
        /// Mean distance of all neighbors from the winning group
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meanWinningDistance")]
        public double? MeanWinningDistance { get; set; }

        /// <summary>
        /// Closest distance of a neighbor from the winning group
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("closestWinningDistance")]
        public double? ClosestWinningDistance { get; set; }

        /// <summary>
        /// The lowest distance of a neighbor in the losing group. Optional. If k equals the size of the winning group, there is no losing group
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("closestLosingDistance")]
        public double? ClosestLosingDistance { get; set; }

        /// <summary>
        /// deprecated - do not use, to be removed in 0.23.0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("losingDistance")]
        public double? LosingDistance { get; set; }

        /// <summary>
        /// Mean distance of all neighbors from the losing group. Optional. If k equals the size of the winning group, there is no losing group.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meanLosingDistance")]
        public double? MeanLosingDistance { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReferenceMetaClassification" /> class.
        /// </summary>
        /// <param name="overallCount">
        /// overall neighbors checked as part of the classification. In most cases this will equal k, but could be lower than k - for example if not enough data was present
        /// </param>
        /// <param name="winningCount">
        /// size of the winning group, a number between 1..k
        /// </param>
        /// <param name="losingCount">
        /// size of the losing group, can be 0 if the winning group size equals k
        /// </param>
        /// <param name="closestOverallDistance">
        /// The lowest distance of any neighbor, regardless of whether they were in the winning or losing group
        /// </param>
        /// <param name="winningDistance">
        /// deprecated - do not use, to be removed in 0.23.0
        /// </param>
        /// <param name="meanWinningDistance">
        /// Mean distance of all neighbors from the winning group
        /// </param>
        /// <param name="closestWinningDistance">
        /// Closest distance of a neighbor from the winning group
        /// </param>
        /// <param name="closestLosingDistance">
        /// The lowest distance of a neighbor in the losing group. Optional. If k equals the size of the winning group, there is no losing group
        /// </param>
        /// <param name="losingDistance">
        /// deprecated - do not use, to be removed in 0.23.0
        /// </param>
        /// <param name="meanLosingDistance">
        /// Mean distance of all neighbors from the losing group. Optional. If k equals the size of the winning group, there is no losing group.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ReferenceMetaClassification(
            double? overallCount,
            double? winningCount,
            double? losingCount,
            double? closestOverallDistance,
            double? winningDistance,
            double? meanWinningDistance,
            double? closestWinningDistance,
            double? closestLosingDistance,
            double? losingDistance,
            double? meanLosingDistance)
        {
            this.OverallCount = overallCount;
            this.WinningCount = winningCount;
            this.LosingCount = losingCount;
            this.ClosestOverallDistance = closestOverallDistance;
            this.WinningDistance = winningDistance;
            this.MeanWinningDistance = meanWinningDistance;
            this.ClosestWinningDistance = closestWinningDistance;
            this.ClosestLosingDistance = closestLosingDistance;
            this.LosingDistance = losingDistance;
            this.MeanLosingDistance = meanLosingDistance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReferenceMetaClassification" /> class.
        /// </summary>
        public ReferenceMetaClassification()
        {
        }


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public static global::G.ReferenceMetaClassification? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.ReferenceMetaClassification),
                jsonSerializerContext) as global::G.ReferenceMetaClassification;
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
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.ReferenceMetaClassification>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.ReferenceMetaClassification?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.ReferenceMetaClassification),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.ReferenceMetaClassification;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.ReferenceMetaClassification?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.ReferenceMetaClassification?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}