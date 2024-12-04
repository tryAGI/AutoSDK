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
        /// The total number of tokens in the Response including input and output <br/>
        /// text and audio tokens.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tokens")]
        public int? TotalTokens { get; set; }

        /// <summary>
        /// The number of input tokens used in the Response, including text and <br/>
        /// audio tokens.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_tokens")]
        public int? InputTokens { get; set; }

        /// <summary>
        /// The number of output tokens sent in the Response, including text and <br/>
        /// audio tokens.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_tokens")]
        public int? OutputTokens { get; set; }

        /// <summary>
        /// Details about the input tokens used in the Response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_token_details")]
        public global::G.RealtimeResponseUsageInputTokenDetails? InputTokenDetails { get; set; }

        /// <summary>
        /// Details about the output tokens used in the Response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_token_details")]
        public global::G.RealtimeResponseUsageOutputTokenDetails? OutputTokenDetails { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeResponseUsage" /> class.
        /// </summary>
        /// <param name="totalTokens">
        /// The total number of tokens in the Response including input and output <br/>
        /// text and audio tokens.
        /// </param>
        /// <param name="inputTokens">
        /// The number of input tokens used in the Response, including text and <br/>
        /// audio tokens.
        /// </param>
        /// <param name="outputTokens">
        /// The number of output tokens sent in the Response, including text and <br/>
        /// audio tokens.
        /// </param>
        /// <param name="inputTokenDetails">
        /// Details about the input tokens used in the Response.
        /// </param>
        /// <param name="outputTokenDetails">
        /// Details about the output tokens used in the Response.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public RealtimeResponseUsage(
            int? totalTokens,
            int? inputTokens,
            int? outputTokens,
            global::G.RealtimeResponseUsageInputTokenDetails? inputTokenDetails,
            global::G.RealtimeResponseUsageOutputTokenDetails? outputTokenDetails)
        {
            this.TotalTokens = totalTokens;
            this.InputTokens = inputTokens;
            this.OutputTokens = outputTokens;
            this.InputTokenDetails = inputTokenDetails;
            this.OutputTokenDetails = outputTokenDetails;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeResponseUsage" /> class.
        /// </summary>
        public RealtimeResponseUsage()
        {
        }
    }
}