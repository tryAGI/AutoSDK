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
        [global::Newtonsoft.Json.JsonProperty("delete_alias", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.DeleteAlias DeleteAlias { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteAliasOperation" /> class.
        /// </summary>
        /// <param name="deleteAlias">
        /// Delete alias if exists
        /// </param>
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