//HintName: G.Models.ExperimentHypotheseRun.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExperimentHypotheseRun
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request")]
        public global::G.RequestObj? Request { get; set; }

        /// <summary>
        /// Construct a type with a set of properties K of type T
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scores")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::G.Score2> Scores { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response")]
        public global::G.ResponseObj? Response { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resultRequestId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ResultRequestId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datasetRowId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DatasetRowId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentHypotheseRun" /> class.
        /// </summary>
        /// <param name="scores">
        /// Construct a type with a set of properties K of type T
        /// </param>
        /// <param name="resultRequestId"></param>
        /// <param name="datasetRowId"></param>
        /// <param name="request"></param>
        /// <param name="response"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExperimentHypotheseRun(
            global::System.Collections.Generic.Dictionary<string, global::G.Score2> scores,
            string resultRequestId,
            string datasetRowId,
            global::G.RequestObj? request,
            global::G.ResponseObj? response)
        {
            this.Request = request;
            this.Scores = scores ?? throw new global::System.ArgumentNullException(nameof(scores));
            this.Response = response;
            this.ResultRequestId = resultRequestId ?? throw new global::System.ArgumentNullException(nameof(resultRequestId));
            this.DatasetRowId = datasetRowId ?? throw new global::System.ArgumentNullException(nameof(datasetRowId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentHypotheseRun" /> class.
        /// </summary>
        public ExperimentHypotheseRun()
        {
        }
    }
}