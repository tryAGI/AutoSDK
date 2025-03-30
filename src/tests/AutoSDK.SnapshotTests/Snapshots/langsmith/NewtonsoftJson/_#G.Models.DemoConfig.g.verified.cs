//HintName: G.Models.DemoConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DemoConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message_index", Required = global::Newtonsoft.Json.Required.Always)]
        public int MessageIndex { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metaprompt", Required = global::Newtonsoft.Json.Required.Always)]
        public object Metaprompt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("examples", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<object> Examples { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("overall_feedback", Required = global::Newtonsoft.Json.Required.Always)]
        public string? OverallFeedback { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DemoConfig" /> class.
        /// </summary>
        /// <param name="messageIndex"></param>
        /// <param name="metaprompt"></param>
        /// <param name="examples"></param>
        /// <param name="overallFeedback"></param>
        public DemoConfig(
            int messageIndex,
            object metaprompt,
            global::System.Collections.Generic.IList<object> examples,
            string? overallFeedback)
        {
            this.MessageIndex = messageIndex;
            this.Metaprompt = metaprompt ?? throw new global::System.ArgumentNullException(nameof(metaprompt));
            this.Examples = examples ?? throw new global::System.ArgumentNullException(nameof(examples));
            this.OverallFeedback = overallFeedback ?? throw new global::System.ArgumentNullException(nameof(overallFeedback));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DemoConfig" /> class.
        /// </summary>
        public DemoConfig()
        {
        }
    }
}