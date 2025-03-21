//HintName: G.Models.RealtimeResponseUsage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Usage statistics for the Response, this will correspond to billing. A <br/>
    /// Realtime API session will maintain a conversation context and append new <br/>
    /// Items to the Conversation, thus output from previous turns (text and <br/>
    /// audio tokens) will become the input for later turns.
    /// </summary>
    public sealed partial class RealtimeResponseUsage
    {
        /// <summary>
        /// Details about the input tokens used in the Response.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_token_details")]
        public global::G.RealtimeResponseUsageInputTokenDetails? InputTokenDetails { get; set; }

        /// <summary>
        /// The number of input tokens used in the Response, including text and <br/>
        /// audio tokens.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_tokens")]
        public int? InputTokens { get; set; }

        /// <summary>
        /// Details about the output tokens used in the Response.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_token_details")]
        public global::G.RealtimeResponseUsageOutputTokenDetails? OutputTokenDetails { get; set; }

        /// <summary>
        /// The number of output tokens sent in the Response, including text and <br/>
        /// audio tokens.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_tokens")]
        public int? OutputTokens { get; set; }

        /// <summary>
        /// The total number of tokens in the Response including input and output <br/>
        /// text and audio tokens.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_tokens")]
        public int? TotalTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeResponseUsage" /> class.
        /// </summary>
        /// <param name="inputTokenDetails">
        /// Details about the input tokens used in the Response.
        /// </param>
        /// <param name="inputTokens">
        /// The number of input tokens used in the Response, including text and <br/>
        /// audio tokens.
        /// </param>
        /// <param name="outputTokenDetails">
        /// Details about the output tokens used in the Response.
        /// </param>
        /// <param name="outputTokens">
        /// The number of output tokens sent in the Response, including text and <br/>
        /// audio tokens.
        /// </param>
        /// <param name="totalTokens">
        /// The total number of tokens in the Response including input and output <br/>
        /// text and audio tokens.
        /// </param>
        public RealtimeResponseUsage(
            global::G.RealtimeResponseUsageInputTokenDetails? inputTokenDetails,
            int? inputTokens,
            global::G.RealtimeResponseUsageOutputTokenDetails? outputTokenDetails,
            int? outputTokens,
            int? totalTokens)
        {
            this.InputTokenDetails = inputTokenDetails;
            this.InputTokens = inputTokens;
            this.OutputTokenDetails = outputTokenDetails;
            this.OutputTokens = outputTokens;
            this.TotalTokens = totalTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeResponseUsage" /> class.
        /// </summary>
        public RealtimeResponseUsage()
        {
        }
    }
}