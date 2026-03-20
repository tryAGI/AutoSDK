//HintName: G.Models.ChatCitationGenerationEventLg3v2o.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCitationGenerationEventLg3v2o
    {
        /// <summary>
        /// Citations for the generated reply.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("citations", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ChatCitation> Citations { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCitationGenerationEventLg3v2o" /> class.
        /// </summary>
        /// <param name="citations">
        /// Citations for the generated reply.
        /// </param>
        public ChatCitationGenerationEventLg3v2o(
            global::System.Collections.Generic.IList<global::G.ChatCitation> citations)
        {
            this.Citations = citations ?? throw new global::System.ArgumentNullException(nameof(citations));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCitationGenerationEventLg3v2o" /> class.
        /// </summary>
        public ChatCitationGenerationEventLg3v2o()
        {
        }
    }
}