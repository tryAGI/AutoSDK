//HintName: G.Models.QuestionAnsweringResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class QuestionAnsweringResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("answer")]
        public string? Answer { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("similarChunks")]
        public global::System.Collections.Generic.IList<global::G.SimilarityChunk>? SimilarChunks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QuestionAnsweringResponse" /> class.
        /// </summary>
        /// <param name="answer"></param>
        /// <param name="similarChunks"></param>
        public QuestionAnsweringResponse(
            string? answer,
            global::System.Collections.Generic.IList<global::G.SimilarityChunk>? similarChunks)
        {
            this.Answer = answer;
            this.SimilarChunks = similarChunks;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QuestionAnsweringResponse" /> class.
        /// </summary>
        public QuestionAnsweringResponse()
        {
        }
    }
}