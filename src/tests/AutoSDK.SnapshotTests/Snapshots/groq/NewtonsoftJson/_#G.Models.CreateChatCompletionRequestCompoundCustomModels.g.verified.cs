//HintName: G.Models.CreateChatCompletionRequestCompoundCustomModels.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateChatCompletionRequestCompoundCustomModels
    {
        /// <summary>
        /// Custom model to use for reasoning.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reasoning_model")]
        public string? ReasoningModel { get; set; }

        /// <summary>
        /// Custom model to use for answering.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("answering_model")]
        public string? AnsweringModel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatCompletionRequestCompoundCustomModels" /> class.
        /// </summary>
        /// <param name="reasoningModel">
        /// Custom model to use for reasoning.
        /// </param>
        /// <param name="answeringModel">
        /// Custom model to use for answering.
        /// </param>
        public CreateChatCompletionRequestCompoundCustomModels(
            string? reasoningModel,
            string? answeringModel)
        {
            this.ReasoningModel = reasoningModel;
            this.AnsweringModel = answeringModel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatCompletionRequestCompoundCustomModels" /> class.
        /// </summary>
        public CreateChatCompletionRequestCompoundCustomModels()
        {
        }
    }
}