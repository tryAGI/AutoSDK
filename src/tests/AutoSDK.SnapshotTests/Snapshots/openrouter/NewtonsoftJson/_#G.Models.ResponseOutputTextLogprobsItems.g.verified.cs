//HintName: G.Models.ResponseOutputTextLogprobsItems.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseOutputTextLogprobsItems
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("token", Required = global::Newtonsoft.Json.Required.Always)]
        public string Token { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bytes", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<double> Bytes { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("logprob", Required = global::Newtonsoft.Json.Required.Always)]
        public double Logprob { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("top_logprobs", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ResponseOutputTextLogprobsItemsTopLogprobsItems> TopLogprobs { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseOutputTextLogprobsItems" /> class.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="bytes"></param>
        /// <param name="logprob"></param>
        /// <param name="topLogprobs"></param>
        public ResponseOutputTextLogprobsItems(
            string token,
            global::System.Collections.Generic.IList<double> bytes,
            double logprob,
            global::System.Collections.Generic.IList<global::G.ResponseOutputTextLogprobsItemsTopLogprobsItems> topLogprobs)
        {
            this.Token = token ?? throw new global::System.ArgumentNullException(nameof(token));
            this.Bytes = bytes ?? throw new global::System.ArgumentNullException(nameof(bytes));
            this.Logprob = logprob;
            this.TopLogprobs = topLogprobs ?? throw new global::System.ArgumentNullException(nameof(topLogprobs));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseOutputTextLogprobsItems" /> class.
        /// </summary>
        public ResponseOutputTextLogprobsItems()
        {
        }
    }
}