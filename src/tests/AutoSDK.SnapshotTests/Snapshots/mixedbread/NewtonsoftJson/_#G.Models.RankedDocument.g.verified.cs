//HintName: G.Models.RankedDocument.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RankedDocument
    {
        /// <summary>
        /// The index of the document.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("index", Required = global::Newtonsoft.Json.Required.Always)]
        public int Index { get; set; } = default!;

        /// <summary>
        /// The score of the document.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("score", Required = global::Newtonsoft.Json.Required.Always)]
        public double Score { get; set; } = default!;

        /// <summary>
        /// The input document.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input")]
        public object? Input { get; set; }

        /// <summary>
        /// The object type.<br/>
        /// Default Value: rank_result
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RankedDocument" /> class.
        /// </summary>
        /// <param name="index">
        /// The index of the document.
        /// </param>
        /// <param name="score">
        /// The score of the document.
        /// </param>
        /// <param name="input">
        /// The input document.
        /// </param>
        /// <param name="object">
        /// The object type.<br/>
        /// Default Value: rank_result
        /// </param>
        public RankedDocument(
            int index,
            double score,
            object? input,
            string? @object)
        {
            this.Index = index;
            this.Score = score;
            this.Input = input;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RankedDocument" /> class.
        /// </summary>
        public RankedDocument()
        {
        }
    }
}