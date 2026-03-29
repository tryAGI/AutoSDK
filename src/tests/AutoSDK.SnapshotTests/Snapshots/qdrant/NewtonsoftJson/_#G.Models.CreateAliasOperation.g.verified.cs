//HintName: G.Models.CreateAliasOperation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAliasOperation
    {
        /// <summary>
        /// Create alternative name for a collection. Collection will be available under both names for search, retrieve,
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("create_alias", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CreateAlias CreateAlias { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAliasOperation" /> class.
        /// </summary>
        /// <param name="createAlias">
        /// Create alternative name for a collection. Collection will be available under both names for search, retrieve,
        /// </param>
        public CreateAliasOperation(
            global::G.CreateAlias createAlias)
        {
            this.CreateAlias = createAlias ?? throw new global::System.ArgumentNullException(nameof(createAlias));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAliasOperation" /> class.
        /// </summary>
        public CreateAliasOperation()
        {
        }
    }
}