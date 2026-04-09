//HintName: G.Models.ContextAwareTextSplittingRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ContextAwareTextSplittingRequest
    {
        /// <summary>
        /// The text to split into chunks.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("strategy", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.SplittingStrategyJsonConverter))]
        public global::G.SplittingStrategy Strategy { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContextAwareTextSplittingRequest" /> class.
        /// </summary>
        /// <param name="text">
        /// The text to split into chunks.
        /// </param>
        /// <param name="strategy"></param>
        public ContextAwareTextSplittingRequest(
            string text,
            global::G.SplittingStrategy strategy)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Strategy = strategy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContextAwareTextSplittingRequest" /> class.
        /// </summary>
        public ContextAwareTextSplittingRequest()
        {
        }
    }
}