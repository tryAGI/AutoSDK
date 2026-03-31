//HintName: G.Models.Create2RequestConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Advanced configuration options.
    /// </summary>
    public sealed partial class Create2RequestConfig
    {
        /// <summary>
        /// The logo that will be added to the scene.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logo")]
        public global::G.Create2RequestConfigLogo? Logo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Create2RequestConfig" /> class.
        /// </summary>
        /// <param name="logo">
        /// The logo that will be added to the scene.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Create2RequestConfig(
            global::G.Create2RequestConfigLogo? logo)
        {
            this.Logo = logo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Create2RequestConfig" /> class.
        /// </summary>
        public Create2RequestConfig()
        {
        }
    }
}