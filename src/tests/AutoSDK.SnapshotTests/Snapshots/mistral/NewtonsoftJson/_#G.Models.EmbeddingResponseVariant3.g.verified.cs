//HintName: G.Models.EmbeddingResponseVariant3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EmbeddingResponseVariant3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("choices")]
        public global::System.Collections.Generic.IList<global::G.ChatCompletionChoice>? Choices { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingResponseVariant3" /> class.
        /// </summary>
        /// <param name="choices"></param>
        public EmbeddingResponseVariant3(
            global::System.Collections.Generic.IList<global::G.ChatCompletionChoice>? choices)
        {
            this.Choices = choices;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingResponseVariant3" /> class.
        /// </summary>
        public EmbeddingResponseVariant3()
        {
        }
    }
}