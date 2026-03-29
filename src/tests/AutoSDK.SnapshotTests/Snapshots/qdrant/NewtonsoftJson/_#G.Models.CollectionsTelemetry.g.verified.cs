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
        [global::Newtonsoft.Json.JsonProperty("number_of_collections", Required = global::Newtonsoft.Json.Required.Always)]
        public int NumberOfCollections { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_collections")]
        public int? MaxCollections { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("collections")]
        public global::System.Collections.Generic.IList<global::G.CollectionTelemetryEnum>? Collections { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("snapshots")]
        public global::System.Collections.Generic.IList<global::G.CollectionSnapshotTelemetry>? Snapshots { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CollectionsTelemetry" /> class.
        /// </summary>
        /// <param name="numberOfCollections"></param>
        /// <param name="maxCollections"></param>
        /// <param name="collections"></param>
        /// <param name="snapshots"></param>
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