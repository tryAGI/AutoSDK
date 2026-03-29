//HintName: G.Models.ToolRouterToolkitsListResponseItemMeta.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Toolkit metadata
    /// </summary>
    public sealed partial class ToolRouterToolkitsListResponseItemMeta
    {
        /// <summary>
        /// URL to the toolkit logo
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logo")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Logo { get; set; }

        /// <summary>
        /// Description of the toolkit
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolRouterToolkitsListResponseItemMeta" /> class.
        /// </summary>
        /// <param name="logo">
        /// URL to the toolkit logo
        /// </param>
        /// <param name="description">
        /// Description of the toolkit
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolRouterToolkitsListResponseItemMeta(
            string logo,
            string description)
        {
            this.Logo = logo ?? throw new global::System.ArgumentNullException(nameof(logo));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolRouterToolkitsListResponseItemMeta" /> class.
        /// </summary>
        public ToolRouterToolkitsListResponseItemMeta()
        {
        }
    }
}