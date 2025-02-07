//HintName: G.Models.ModelCapabilities.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelCapabilities
    {
        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_chat")]
        public bool? CompletionChat { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_fim")]
        public bool? CompletionFim { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fine_tuning")]
        public bool? FineTuning { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function_calling")]
        public bool? FunctionCalling { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vision")]
        public bool? Vision { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelCapabilities" /> class.
        /// </summary>
        /// <param name="completionChat">
        /// Default Value: true
        /// </param>
        /// <param name="completionFim">
        /// Default Value: false
        /// </param>
        /// <param name="fineTuning">
        /// Default Value: false
        /// </param>
        /// <param name="functionCalling">
        /// Default Value: true
        /// </param>
        /// <param name="vision">
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelCapabilities(
            bool? completionChat,
            bool? completionFim,
            bool? fineTuning,
            bool? functionCalling,
            bool? vision)
        {
            this.CompletionChat = completionChat;
            this.CompletionFim = completionFim;
            this.FineTuning = fineTuning;
            this.FunctionCalling = functionCalling;
            this.Vision = vision;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelCapabilities" /> class.
        /// </summary>
        public ModelCapabilities()
        {
        }
    }
}