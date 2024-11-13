//HintName: G.Models.PutDatasetVersionsSchema.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PutDatasetVersionsSchema
    {
        /// <summary>
        /// Only modifications made on or before this time are included. If None, the latest version of the dataset is used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("as_of")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AnyOf<global::System.DateTime?, string> AsOf { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Tag { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PutDatasetVersionsSchema" /> class.
        /// </summary>
        /// <param name="asOf">
        /// Only modifications made on or before this time are included. If None, the latest version of the dataset is used.
        /// </param>
        /// <param name="tag"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public PutDatasetVersionsSchema(
            global::G.AnyOf<global::System.DateTime?, string> asOf,
            string tag)
        {
            this.AsOf = asOf;
            this.Tag = tag ?? throw new global::System.ArgumentNullException(nameof(tag));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PutDatasetVersionsSchema" /> class.
        /// </summary>
        public PutDatasetVersionsSchema()
        {
        }
    }
}