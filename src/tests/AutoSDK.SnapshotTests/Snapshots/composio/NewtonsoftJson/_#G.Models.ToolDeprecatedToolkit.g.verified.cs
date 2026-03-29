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
        [global::Newtonsoft.Json.JsonProperty("logo", Required = global::Newtonsoft.Json.Required.Always)]
        public string Logo { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolDeprecatedToolkit" /> class.
        /// </summary>
        /// <param name="logo">
        /// URL to the toolkit logo image<br/>
        /// Example: https://github.githubassets.com/assets/GitHub-Mark-ea2971cee799.png
        /// </param>
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