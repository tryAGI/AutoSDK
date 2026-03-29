//HintName: G.Models.FindingLocation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FindingLocation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("byteRange")]
        public global::G.LocationRange? ByteRange { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("codepointRange")]
        public global::G.LocationRange? CodepointRange { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rowRange")]
        public global::G.LocationRange? RowRange { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("columnRange")]
        public global::G.LocationRange? ColumnRange { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commitHash")]
        public string? CommitHash { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commitAuthor")]
        public string? CommitAuthor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FindingLocation" /> class.
        /// </summary>
        /// <param name="byteRange"></param>
        /// <param name="codepointRange"></param>
        /// <param name="rowRange"></param>
        /// <param name="columnRange"></param>
        /// <param name="commitHash"></param>
        /// <param name="commitAuthor"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FindingLocation(
            global::G.LocationRange? byteRange,
            global::G.LocationRange? codepointRange,
            global::G.LocationRange? rowRange,
            global::G.LocationRange? columnRange,
            string? commitHash,
            string? commitAuthor)
        {
            this.ByteRange = byteRange;
            this.CodepointRange = codepointRange;
            this.RowRange = rowRange;
            this.ColumnRange = columnRange;
            this.CommitHash = commitHash;
            this.CommitAuthor = commitAuthor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FindingLocation" /> class.
        /// </summary>
        public FindingLocation()
        {
        }
    }
}