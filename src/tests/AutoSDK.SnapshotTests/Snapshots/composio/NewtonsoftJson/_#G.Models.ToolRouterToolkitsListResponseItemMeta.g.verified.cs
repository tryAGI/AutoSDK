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
        [global::Newtonsoft.Json.JsonProperty("logo", Required = global::Newtonsoft.Json.Required.Always)]
        public string Logo { get; set; } = default!;

        /// <summary>
        /// Description of the toolkit
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string Description { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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