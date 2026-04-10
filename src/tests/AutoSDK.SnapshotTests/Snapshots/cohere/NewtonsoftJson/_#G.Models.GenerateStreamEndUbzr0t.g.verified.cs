//HintName: G.Models.GenerateStreamEndUbzr0t.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerateStreamEndUbzr0t
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_finished", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsFinished { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("finish_reason")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.FinishReasonJsonConverter))]
        public global::G.FinishReason? FinishReason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.GenerateStreamEndResponse Response { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateStreamEndUbzr0t" /> class.
        /// </summary>
        /// <param name="isFinished"></param>
        /// <param name="response"></param>
        /// <param name="finishReason"></param>
        public GenerateStreamEndUbzr0t(
            bool isFinished,
            global::G.GenerateStreamEndResponse response,
            global::G.FinishReason? finishReason)
        {
            this.IsFinished = isFinished;
            this.FinishReason = finishReason;
            this.Response = response ?? throw new global::System.ArgumentNullException(nameof(response));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateStreamEndUbzr0t" /> class.
        /// </summary>
        public GenerateStreamEndUbzr0t()
        {
        }
    }
}