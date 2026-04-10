//HintName: G.Models.GenerateStreamError49d5xw.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerateStreamError49d5xw
    {
        /// <summary>
        /// Refers to the nth generation. Only present when `num_generations` is greater than zero.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("index")]
        public int? Index { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_finished", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsFinished { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("finish_reason", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.FinishReasonJsonConverter))]
        public global::G.FinishReason FinishReason { get; set; } = default!;

        /// <summary>
        /// Error message
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("err", Required = global::Newtonsoft.Json.Required.Always)]
        public string Err { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateStreamError49d5xw" /> class.
        /// </summary>
        /// <param name="isFinished"></param>
        /// <param name="finishReason"></param>
        /// <param name="err">
        /// Error message
        /// </param>
        /// <param name="index">
        /// Refers to the nth generation. Only present when `num_generations` is greater than zero.
        /// </param>
        public GenerateStreamError49d5xw(
            bool isFinished,
            global::G.FinishReason finishReason,
            string err,
            int? index)
        {
            this.Index = index;
            this.IsFinished = isFinished;
            this.FinishReason = finishReason;
            this.Err = err ?? throw new global::System.ArgumentNullException(nameof(err));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateStreamError49d5xw" /> class.
        /// </summary>
        public GenerateStreamError49d5xw()
        {
        }
    }
}