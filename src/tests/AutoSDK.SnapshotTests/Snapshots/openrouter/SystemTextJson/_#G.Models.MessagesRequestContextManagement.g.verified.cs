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
        [global::System.Text.Json.Serialization.JsonPropertyName("edits")]
        public global::System.Collections.Generic.IList<global::G.MessagesRequestContextManagementEditsItems>? Edits { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesRequestContextManagement" /> class.
        /// </summary>
        /// <param name="edits"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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