//HintName: G.Models.ChatCompletionResponseVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionResponseVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("choices")]
        public global::System.Collections.Generic.IList<global::G.ChatCompletionChoice>? Choices { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionResponseVariant2" /> class.
        /// </summary>
        /// <param name="choices"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionResponseVariant2(
            global::System.Collections.Generic.IList<global::G.ChatCompletionChoice>? choices)
        {
            this.Choices = choices;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionResponseVariant2" /> class.
        /// </summary>
        public ChatCompletionResponseVariant2()
        {
        }
    }
}