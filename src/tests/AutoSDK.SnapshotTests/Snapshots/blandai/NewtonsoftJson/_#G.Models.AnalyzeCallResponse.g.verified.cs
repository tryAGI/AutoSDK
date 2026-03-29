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
        [global::Newtonsoft.Json.JsonProperty("status")]
        public global::G.AnalyzeCallResponseStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message")]
        public string? Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("answers")]
        public global::System.Collections.Generic.IList<string>? Answers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("credits_used")]
        public float? CreditsUsed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyzeCallResponse" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="message"></param>
        /// <param name="answers"></param>
        /// <param name="creditsUsed"></param>
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