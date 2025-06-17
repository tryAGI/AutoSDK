//HintName: G.Models.StreamedChatResponseV2Discriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StreamedChatResponseV2Discriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.StreamedChatResponseV2DiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamedChatResponseV2Discriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
        public StreamedChatResponseV2Discriminator(
            global::G.StreamedChatResponseV2DiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamedChatResponseV2Discriminator" /> class.
        /// </summary>
        public StreamedChatResponseV2Discriminator()
        {
        }
    }
}