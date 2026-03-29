//HintName: G.Models.VectorUpsertResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VectorUpsertResponse
    {
        /// <summary>
        /// Number of vectors added<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("numAdded")]
        public double? NumAdded { get; set; }

        /// <summary>
        /// Number of vectors deleted<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("numDeleted")]
        public double? NumDeleted { get; set; }

        /// <summary>
        /// Number of vectors updated<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("numUpdated")]
        public double? NumUpdated { get; set; }

        /// <summary>
        /// Number of vectors skipped (not added, deleted, or updated)<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("numSkipped")]
        public double? NumSkipped { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("addedDocs")]
        public global::System.Collections.Generic.IList<global::G.Document>? AddedDocs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VectorUpsertResponse" /> class.
        /// </summary>
        /// <param name="numAdded">
        /// Number of vectors added<br/>
        /// Example: 1
        /// </param>
        /// <param name="numDeleted">
        /// Number of vectors deleted<br/>
        /// Example: 1
        /// </param>
        /// <param name="numUpdated">
        /// Number of vectors updated<br/>
        /// Example: 1
        /// </param>
        /// <param name="numSkipped">
        /// Number of vectors skipped (not added, deleted, or updated)<br/>
        /// Example: 1
        /// </param>
        /// <param name="addedDocs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VectorUpsertResponse(
            double? numAdded,
            double? numDeleted,
            double? numUpdated,
            double? numSkipped,
            global::System.Collections.Generic.IList<global::G.Document>? addedDocs)
        {
            this.NumAdded = numAdded;
            this.NumDeleted = numDeleted;
            this.NumUpdated = numUpdated;
            this.NumSkipped = numSkipped;
            this.AddedDocs = addedDocs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VectorUpsertResponse" /> class.
        /// </summary>
        public VectorUpsertResponse()
        {
        }
    }
}