//HintName: G.Models.RenameAliasOperation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Change alias to a new one
    /// </summary>
    public sealed partial class RenameAliasOperation
    {
        /// <summary>
        /// Change alias to a new one
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rename_alias")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.RenameAlias RenameAlias { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RenameAliasOperation" /> class.
        /// </summary>
        /// <param name="renameAlias">
        /// Change alias to a new one
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RenameAliasOperation(
            global::G.RenameAlias renameAlias)
        {
            this.RenameAlias = renameAlias ?? throw new global::System.ArgumentNullException(nameof(renameAlias));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RenameAliasOperation" /> class.
        /// </summary>
        public RenameAliasOperation()
        {
        }
    }
}