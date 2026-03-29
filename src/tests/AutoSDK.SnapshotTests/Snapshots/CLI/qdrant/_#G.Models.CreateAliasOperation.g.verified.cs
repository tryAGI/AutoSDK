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
        [global::System.Text.Json.Serialization.JsonPropertyName("create_alias")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CreateAlias CreateAlias { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAliasOperation" /> class.
        /// </summary>
        /// <param name="createAlias">
        /// Create alternative name for a collection. Collection will be available under both names for search, retrieve,
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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