//HintName: G.Models.Sam3PromptResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Sam3PromptResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_index", Required = global::Newtonsoft.Json.Required.Always)]
        public int PromptIndex { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("echo", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Sam3PromptEcho Echo { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("predictions", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.Sam3SegmentationPrediction> Predictions { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Sam3PromptResult" /> class.
        /// </summary>
        /// <param name="promptIndex"></param>
        /// <param name="echo"></param>
        /// <param name="predictions"></param>
        public Sam3PromptResult(
            int promptIndex,
            global::G.Sam3PromptEcho echo,
            global::System.Collections.Generic.IList<global::G.Sam3SegmentationPrediction> predictions)
        {
            this.PromptIndex = promptIndex;
            this.Echo = echo ?? throw new global::System.ArgumentNullException(nameof(echo));
            this.Predictions = predictions ?? throw new global::System.ArgumentNullException(nameof(predictions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Sam3PromptResult" /> class.
        /// </summary>
        public Sam3PromptResult()
        {
        }
    }
}