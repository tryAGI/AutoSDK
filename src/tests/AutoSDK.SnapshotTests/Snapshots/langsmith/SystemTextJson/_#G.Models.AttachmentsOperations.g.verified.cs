//HintName: G.Models.AttachmentsOperations.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AttachmentsOperations
    {
        /// <summary>
        /// Mapping of old attachment names to new names
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rename")]
        public global::System.Collections.Generic.Dictionary<string, string>? Rename { get; set; }

        /// <summary>
        /// List of attachment names to keep
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retain")]
        public global::System.Collections.Generic.IList<string>? Retain { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AttachmentsOperations" /> class.
        /// </summary>
        /// <param name="rename">
        /// Mapping of old attachment names to new names
        /// </param>
        /// <param name="retain">
        /// List of attachment names to keep
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AttachmentsOperations(
            global::System.Collections.Generic.Dictionary<string, string>? rename,
            global::System.Collections.Generic.IList<string>? retain)
        {
            this.Rename = rename;
            this.Retain = retain;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AttachmentsOperations" /> class.
        /// </summary>
        public AttachmentsOperations()
        {
        }
    }
}