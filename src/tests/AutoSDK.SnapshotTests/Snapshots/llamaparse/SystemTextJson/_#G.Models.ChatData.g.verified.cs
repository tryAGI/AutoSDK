//HintName: G.Models.ChatData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatData
    {
        /// <summary>
        /// Schema for the search params for an retrieval execution that can be preset for a pipeline.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retrieval_parameters")]
        public global::G.PresetRetrievalParams? RetrievalParameters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm_parameters")]
        public global::G.LLMParameters? LlmParameters { get; set; }

        /// <summary>
        /// Default Value: base_component
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("class_name")]
        public string? ClassName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatData" /> class.
        /// </summary>
        /// <param name="retrievalParameters">
        /// Schema for the search params for an retrieval execution that can be preset for a pipeline.
        /// </param>
        /// <param name="llmParameters"></param>
        /// <param name="className">
        /// Default Value: base_component
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatData(
            global::G.PresetRetrievalParams? retrievalParameters,
            global::G.LLMParameters? llmParameters,
            string? className)
        {
            this.RetrievalParameters = retrievalParameters;
            this.LlmParameters = llmParameters;
            this.ClassName = className;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatData" /> class.
        /// </summary>
        public ChatData()
        {
        }
    }
}