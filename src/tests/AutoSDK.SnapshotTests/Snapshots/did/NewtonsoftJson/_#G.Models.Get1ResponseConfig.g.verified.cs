//HintName: G.Models.Get1ResponseConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Get1ResponseConfig
    {
        /// <summary>
        /// The logo that will be added to the scene.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("logo")]
        public global::G.Get1ResponseConfigLogo? Logo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Get1ResponseConfig" /> class.
        /// </summary>
        /// <param name="logo">
        /// The logo that will be added to the scene.
        /// </param>
        public Get1ResponseConfig(
            global::G.Get1ResponseConfigLogo? logo)
        {
            this.Logo = logo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Get1ResponseConfig" /> class.
        /// </summary>
        public Get1ResponseConfig()
        {
        }
    }
}