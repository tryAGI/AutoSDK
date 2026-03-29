//HintName: G.Models.SearchMatrixOffsetsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchMatrixOffsetsResponse
    {
        /// <summary>
        /// Row indices of the matrix
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("offsets_row", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<int> OffsetsRow { get; set; } = default!;

        /// <summary>
        /// Column indices of the matrix
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("offsets_col", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<int> OffsetsCol { get; set; } = default!;

        /// <summary>
        /// Scores associated with matrix coordinates
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("scores", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<float> Scores { get; set; } = default!;

        /// <summary>
        /// Ids of the points in order
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ids", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ExtendedPointId> Ids { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchMatrixOffsetsResponse" /> class.
        /// </summary>
        /// <param name="offsetsRow">
        /// Row indices of the matrix
        /// </param>
        /// <param name="offsetsCol">
        /// Column indices of the matrix
        /// </param>
        /// <param name="scores">
        /// Scores associated with matrix coordinates
        /// </param>
        /// <param name="ids">
        /// Ids of the points in order
        /// </param>
        public SearchMatrixOffsetsResponse(
            global::System.Collections.Generic.IList<int> offsetsRow,
            global::System.Collections.Generic.IList<int> offsetsCol,
            global::System.Collections.Generic.IList<float> scores,
            global::System.Collections.Generic.IList<global::G.ExtendedPointId> ids)
        {
            this.OffsetsRow = offsetsRow ?? throw new global::System.ArgumentNullException(nameof(offsetsRow));
            this.OffsetsCol = offsetsCol ?? throw new global::System.ArgumentNullException(nameof(offsetsCol));
            this.Scores = scores ?? throw new global::System.ArgumentNullException(nameof(scores));
            this.Ids = ids ?? throw new global::System.ArgumentNullException(nameof(ids));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchMatrixOffsetsResponse" /> class.
        /// </summary>
        public SearchMatrixOffsetsResponse()
        {
        }
    }
}