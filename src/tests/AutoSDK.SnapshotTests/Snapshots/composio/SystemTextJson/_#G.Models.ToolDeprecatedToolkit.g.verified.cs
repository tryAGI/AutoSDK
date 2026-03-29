//HintName: G.Models.ToolDeprecatedToolkit.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolDeprecatedToolkit
    {
        /// <summary>
        /// URL to the toolkit logo image<br/>
        /// Example: https://github.githubassets.com/assets/GitHub-Mark-ea2971cee799.png
        /// </summary>
        /// <example>https://github.githubassets.com/assets/GitHub-Mark-ea2971cee799.png</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("logo")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Logo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolDeprecatedToolkit" /> class.
        /// </summary>
        /// <param name="logo">
        /// URL to the toolkit logo image<br/>
        /// Example: https://github.githubassets.com/assets/GitHub-Mark-ea2971cee799.png
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolDeprecatedToolkit(
            string logo)
        {
            this.Logo = logo ?? throw new global::System.ArgumentNullException(nameof(logo));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolDeprecatedToolkit" /> class.
        /// </summary>
        public ToolDeprecatedToolkit()
        {
        }
    }
}