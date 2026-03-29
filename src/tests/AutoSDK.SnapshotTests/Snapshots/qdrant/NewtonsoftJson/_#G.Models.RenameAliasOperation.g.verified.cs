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
        [global::Newtonsoft.Json.JsonProperty("rename_alias", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RenameAlias RenameAlias { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RenameAliasOperation" /> class.
        /// </summary>
        /// <param name="renameAlias">
        /// Change alias to a new one
        /// </param>
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