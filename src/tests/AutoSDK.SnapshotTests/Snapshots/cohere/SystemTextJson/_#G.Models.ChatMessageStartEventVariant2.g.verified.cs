//HintName: G.Models.ChatMessageStartEventVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatMessageStartEventVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delta")]
        public global::G.ChatMessageStartEventVariant2Delta? Delta { get; set; }

        /// <summary>
        /// Unique identifier for the generated reply.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatMessageStartEventVariant2" /> class.
        /// </summary>
        /// <param name="delta"></param>
        /// <param name="id">
        /// Unique identifier for the generated reply.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatMessageStartEventVariant2(
            global::G.ChatMessageStartEventVariant2Delta? delta,
            string? id)
        {
            this.Delta = delta;
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatMessageStartEventVariant2" /> class.
        /// </summary>
        public ChatMessageStartEventVariant2()
        {
        }
    }
}