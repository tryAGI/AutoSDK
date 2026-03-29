//HintName: G.Models.RenameAlias.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Change alias to a new one
    /// </summary>
    public sealed partial class RenameAlias
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("old_alias_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OldAliasName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("new_alias_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NewAliasName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RenameAlias" /> class.
        /// </summary>
        /// <param name="oldAliasName"></param>
        /// <param name="newAliasName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RenameAlias(
            string oldAliasName,
            string newAliasName)
        {
            this.OldAliasName = oldAliasName ?? throw new global::System.ArgumentNullException(nameof(oldAliasName));
            this.NewAliasName = newAliasName ?? throw new global::System.ArgumentNullException(nameof(newAliasName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RenameAlias" /> class.
        /// </summary>
        public RenameAlias()
        {
        }
    }
}