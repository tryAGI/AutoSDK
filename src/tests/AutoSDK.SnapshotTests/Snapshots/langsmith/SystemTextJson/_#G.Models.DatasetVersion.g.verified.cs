//HintName: G.Models.DatasetVersion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Dataset version schema.
    /// </summary>
    public sealed partial class DatasetVersion
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("as_of")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime AsOf { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetVersion" /> class.
        /// </summary>
        /// <param name="tags"></param>
        /// <param name="asOf"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public DatasetVersion(
            global::System.DateTime asOf,
            global::System.Collections.Generic.IList<string>? tags)
        {
            this.AsOf = asOf;
            this.Tags = tags;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetVersion" /> class.
        /// </summary>
        public DatasetVersion()
        {
        }
    }
}