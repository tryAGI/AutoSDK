//HintName: G.Models.AnalyzeCallResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AnalyzeCallResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnalyzeCallResponseStatusJsonConverter))]
        public global::G.AnalyzeCallResponseStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("answers")]
        public global::System.Collections.Generic.IList<string>? Answers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credits_used")]
        public float? CreditsUsed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyzeCallResponse" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="message"></param>
        /// <param name="answers"></param>
        /// <param name="creditsUsed"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnalyzeCallResponse(
            global::G.AnalyzeCallResponseStatus? status,
            string? message,
            global::System.Collections.Generic.IList<string>? answers,
            float? creditsUsed)
        {
            this.Status = status;
            this.Message = message;
            this.Answers = answers;
            this.CreditsUsed = creditsUsed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyzeCallResponse" /> class.
        /// </summary>
        public AnalyzeCallResponse()
        {
        }
    }
}