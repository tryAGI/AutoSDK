//HintName: G.Models.CreateSceneRequestDtoConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Advanced configuration options.
    /// </summary>
    public sealed partial class CreateSceneRequestDtoConfig
    {
        /// <summary>
        /// The logo that will be added to the scene.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("logo")]
        public global::G.CreateSceneRequestDtoConfigLogo? Logo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSceneRequestDtoConfig" /> class.
        /// </summary>
        /// <param name="logo">
        /// The logo that will be added to the scene.
        /// </param>
        public CreateSceneRequestDtoConfig(
            global::G.CreateSceneRequestDtoConfigLogo? logo)
        {
            this.Logo = logo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSceneRequestDtoConfig" /> class.
        /// </summary>
        public CreateSceneRequestDtoConfig()
        {
        }
    }
}