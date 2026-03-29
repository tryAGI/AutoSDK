//HintName: G.Models.DeleteAliasOperation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Delete alias if exists
    /// </summary>
    public sealed partial class DeleteAliasOperation
    {
        /// <summary>
        /// Delete alias if exists
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delete_alias")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.DeleteAlias DeleteAlias { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteAliasOperation" /> class.
        /// </summary>
        /// <param name="deleteAlias">
        /// Delete alias if exists
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteAliasOperation(
            global::G.DeleteAlias deleteAlias)
        {
            this.DeleteAlias = deleteAlias ?? throw new global::System.ArgumentNullException(nameof(deleteAlias));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteAliasOperation" /> class.
        /// </summary>
        public DeleteAliasOperation()
        {
        }
    }
}