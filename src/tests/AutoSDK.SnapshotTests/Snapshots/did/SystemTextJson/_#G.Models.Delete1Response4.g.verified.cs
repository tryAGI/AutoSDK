//HintName: G.Models.Delete1Response4.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Delete1Response4
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("knowledge")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Knowledge { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deletedDocuments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object DeletedDocuments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Delete1Response4" /> class.
        /// </summary>
        /// <param name="knowledge"></param>
        /// <param name="deletedDocuments"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Delete1Response4(
            bool knowledge,
            object deletedDocuments)
        {
            this.Knowledge = knowledge;
            this.DeletedDocuments = deletedDocuments ?? throw new global::System.ArgumentNullException(nameof(deletedDocuments));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Delete1Response4" /> class.
        /// </summary>
        public Delete1Response4()
        {
        }
    }
}