//HintName: G.Models.PostToolkitsMultiResponseItemMetaCategorie.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostToolkitsMultiResponseItemMetaCategorie
    {
        /// <summary>
        /// Category identifier<br/>
        /// Example: developer-tools
        /// </summary>
        /// <example>developer-tools</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Human-readable category name<br/>
        /// Example: Developer Tools
        /// </summary>
        /// <example>Developer Tools</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolkitsMultiResponseItemMetaCategorie" /> class.
        /// </summary>
        /// <param name="id">
        /// Category identifier<br/>
        /// Example: developer-tools
        /// </param>
        /// <param name="name">
        /// Human-readable category name<br/>
        /// Example: Developer Tools
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostToolkitsMultiResponseItemMetaCategorie(
            string id,
            string name)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolkitsMultiResponseItemMetaCategorie" /> class.
        /// </summary>
        public PostToolkitsMultiResponseItemMetaCategorie()
        {
        }
    }
}