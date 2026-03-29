//HintName: G.Models.Logprobs.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Logprobs
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content")]
        public global::System.Collections.Generic.IList<global::G.LogprobsToken>? Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("refusal")]
        public global::System.Collections.Generic.IList<global::G.LogprobsToken>? Refusal { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Logprobs" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="refusal"></param>
        public Logprobs(
            global::System.Collections.Generic.IList<global::G.LogprobsToken>? content,
            global::System.Collections.Generic.IList<global::G.LogprobsToken>? refusal)
        {
            this.Content = content;
            this.Refusal = refusal;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Logprobs" /> class.
        /// </summary>
        public Logprobs()
        {
        }
    }
}