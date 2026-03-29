//HintName: G.Models.CollectionsTelemetry.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CollectionsTelemetry
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("number_of_collections")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NumberOfCollections { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_collections")]
        public int? MaxCollections { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collections")]
        public global::System.Collections.Generic.IList<global::G.CollectionTelemetryEnum>? Collections { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("snapshots")]
        public global::System.Collections.Generic.IList<global::G.CollectionSnapshotTelemetry>? Snapshots { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CollectionsTelemetry" /> class.
        /// </summary>
        /// <param name="numberOfCollections"></param>
        /// <param name="maxCollections"></param>
        /// <param name="collections"></param>
        /// <param name="snapshots"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CollectionsTelemetry(
            int numberOfCollections,
            int? maxCollections,
            global::System.Collections.Generic.IList<global::G.CollectionTelemetryEnum>? collections,
            global::System.Collections.Generic.IList<global::G.CollectionSnapshotTelemetry>? snapshots)
        {
            this.NumberOfCollections = numberOfCollections;
            this.MaxCollections = maxCollections;
            this.Collections = collections;
            this.Snapshots = snapshots;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CollectionsTelemetry" /> class.
        /// </summary>
        public CollectionsTelemetry()
        {
        }
    }
}