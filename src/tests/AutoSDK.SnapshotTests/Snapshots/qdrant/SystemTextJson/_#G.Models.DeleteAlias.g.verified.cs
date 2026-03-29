//HintName: G.Models.DeleteAlias.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Delete alias if exists
    /// </summary>
    public sealed partial class DeleteAlias
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alias_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AliasName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteAlias" /> class.
        /// </summary>
        /// <param name="aliasName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteAlias(
            string aliasName)
        {
            this.AliasName = aliasName ?? throw new global::System.ArgumentNullException(nameof(aliasName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteAlias" /> class.
        /// </summary>
        public DeleteAlias()
        {
        }
    }
}