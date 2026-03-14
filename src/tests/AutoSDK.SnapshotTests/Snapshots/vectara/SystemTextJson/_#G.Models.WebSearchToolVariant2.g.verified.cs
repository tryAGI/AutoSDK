//HintName: G.Models.WebSearchToolVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebSearchToolVariant2
    {
        /// <summary>
        /// This should always be `web_search`.<br/>
        /// Default Value: web_search<br/>
        /// Example: web_search
        /// </summary>
        /// <default>"web_search"</default>
        /// <example>web_search</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "web_search";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchToolVariant2" /> class.
        /// </summary>
        /// <param name="type">
        /// This should always be `web_search`.<br/>
        /// Default Value: web_search<br/>
        /// Example: web_search
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebSearchToolVariant2(
            string type)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchToolVariant2" /> class.
        /// </summary>
        public WebSearchToolVariant2()
        {
        }
    }
}