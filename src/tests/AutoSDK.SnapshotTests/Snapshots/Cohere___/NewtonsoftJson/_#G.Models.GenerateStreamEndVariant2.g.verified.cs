//HintName: G.Models.GenerateStreamEndVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerateStreamEndVariant2
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
        public global::G.FinishReason? FinishReason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.GenerateStreamEndVariant2Response Response { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateStreamEndVariant2" /> class.
        /// </summary>
        /// <param name="isFinished"></param>
        /// <param name="finishReason"></param>
        /// <param name="response"></param>
        public GenerateStreamEndVariant2(
            bool isFinished,
            global::G.GenerateStreamEndVariant2Response response,
            global::G.FinishReason? finishReason)
        {
            this.IsFinished = isFinished;
            this.Response = response ?? throw new global::System.ArgumentNullException(nameof(response));
            this.FinishReason = finishReason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateStreamEndVariant2" /> class.
        /// </summary>
        public GenerateStreamEndVariant2()
        {
        }
    }
}