//HintName: G.Models.CreateChatCompletionRequestCompoundCustom.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Custom configuration of models and tools for Compound.
    /// </summary>
    public sealed partial class CreateChatCompletionRequestCompoundCustom
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        public global::G.CreateChatCompletionRequestCompoundCustomModels? Models { get; set; }

        /// <summary>
        /// Configuration options for tools available to Compound.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::G.CreateChatCompletionRequestCompoundCustomTools? Tools { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatCompletionRequestCompoundCustom" /> class.
        /// </summary>
        /// <param name="models"></param>
        /// <param name="tools">
        /// Configuration options for tools available to Compound.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateChatCompletionRequestCompoundCustom(
            global::G.CreateChatCompletionRequestCompoundCustomModels? models,
            global::G.CreateChatCompletionRequestCompoundCustomTools? tools)
        {
            this.Models = models;
            this.Tools = tools;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatCompletionRequestCompoundCustom" /> class.
        /// </summary>
        public CreateChatCompletionRequestCompoundCustom()
        {
        }
    }
}