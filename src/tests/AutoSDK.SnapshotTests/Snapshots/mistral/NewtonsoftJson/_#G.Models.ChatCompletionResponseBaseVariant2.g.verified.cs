//HintName: G.Models.ChatCompletionResponseBaseVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionResponseBaseVariant2
    {
        /// <summary>
        /// Example: 1702256327
        /// </summary>
        /// <example>1702256327</example>
        [global::Newtonsoft.Json.JsonProperty("created")]
        public int? Created { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionResponseBaseVariant2" /> class.
        /// </summary>
        /// <param name="created">
        /// Example: 1702256327
        /// </param>
        public ChatCompletionResponseBaseVariant2(
            int? created)
        {
            this.Created = created;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionResponseBaseVariant2" /> class.
        /// </summary>
        public ChatCompletionResponseBaseVariant2()
        {
        }
    }
}