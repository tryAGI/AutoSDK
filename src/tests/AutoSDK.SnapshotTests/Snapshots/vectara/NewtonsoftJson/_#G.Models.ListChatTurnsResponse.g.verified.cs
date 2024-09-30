//HintName: G.Models.ListChatTurnsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
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
    }
}