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
        [global::Newtonsoft.Json.JsonProperty("alias_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string AliasName { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteAlias" /> class.
        /// </summary>
        /// <param name="aliasName"></param>
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