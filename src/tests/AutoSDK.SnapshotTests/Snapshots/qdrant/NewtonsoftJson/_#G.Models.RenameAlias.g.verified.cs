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
        [global::Newtonsoft.Json.JsonProperty("old_alias_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string OldAliasName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("new_alias_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string NewAliasName { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RenameAlias" /> class.
        /// </summary>
        /// <param name="oldAliasName"></param>
        /// <param name="newAliasName"></param>
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