//HintName: G.Models.MessagesRequestContextManagement.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessagesRequestContextManagement
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("edits")]
        public global::System.Collections.Generic.IList<global::G.MessagesRequestContextManagementEditsItems>? Edits { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesRequestContextManagement" /> class.
        /// </summary>
        /// <param name="edits"></param>
        public MessagesRequestContextManagement(
            global::System.Collections.Generic.IList<global::G.MessagesRequestContextManagementEditsItems>? edits)
        {
            this.Edits = edits;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesRequestContextManagement" /> class.
        /// </summary>
        public MessagesRequestContextManagement()
        {
        }
    }
}