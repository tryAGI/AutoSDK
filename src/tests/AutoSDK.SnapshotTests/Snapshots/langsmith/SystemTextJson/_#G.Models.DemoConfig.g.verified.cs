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
        [global::System.Text.Json.Serialization.JsonPropertyName("message_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MessageIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metaprompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Metaprompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("examples")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<object> Examples { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("overall_feedback")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? OverallFeedback { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DemoConfig" /> class.
        /// </summary>
        /// <param name="messageIndex"></param>
        /// <param name="metaprompt"></param>
        /// <param name="examples"></param>
        /// <param name="overallFeedback"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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