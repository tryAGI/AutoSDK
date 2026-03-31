//HintName: G.Models.OmitIPineconeQueryConfigNamespace.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Construct a type with the properties of T except for those in type K.
    /// </summary>
    public sealed partial class OmitIPineconeQueryConfigNamespace
    {
        /// <summary>
        /// Indicates whether metadata is included in the response as well as the ids.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("includeMetadata")]
        public bool? IncludeMetadata { get; set; }

        /// <summary>
        /// Indicates whether vector values are included in the response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("includeValues")]
        public bool? IncludeValues { get; set; }

        /// <summary>
        /// The number of results to return for each query.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topK")]
        public double? TopK { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OmitIPineconeQueryConfigNamespace" /> class.
        /// </summary>
        /// <param name="includeMetadata">
        /// Indicates whether metadata is included in the response as well as the ids.
        /// </param>
        /// <param name="includeValues">
        /// Indicates whether vector values are included in the response.
        /// </param>
        /// <param name="topK">
        /// The number of results to return for each query.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OmitIPineconeQueryConfigNamespace(
            bool? includeMetadata,
            bool? includeValues,
            double? topK)
        {
            this.IncludeMetadata = includeMetadata;
            this.IncludeValues = includeValues;
            this.TopK = topK;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OmitIPineconeQueryConfigNamespace" /> class.
        /// </summary>
        public OmitIPineconeQueryConfigNamespace()
        {
        }
    }
}