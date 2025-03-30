//HintName: G.Models.ListChatTurnsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response containing a list of turns (message exchanges) within a chat conversation.
    /// </summary>
    public sealed partial class ListChatTurnsResponse
    {
        /// <summary>
        /// List of turns.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("turns")]
        public global::System.Collections.Generic.IList<global::G.Turn>? Turns { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListChatTurnsResponse" /> class.
        /// </summary>
        /// <param name="turns">
        /// List of turns.
        /// </param>
        public ListChatTurnsResponse(
            global::System.Collections.Generic.IList<global::G.Turn>? turns)
        {
            this.Turns = turns;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListChatTurnsResponse" /> class.
        /// </summary>
        public ListChatTurnsResponse()
        {
        }
    }
}