//HintName: G.Models.UpgradeToTeamBundleRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpgradeToTeamBundleRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ui_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UpgradeToTeamBundleRequestUiModeJsonConverter))]
        public global::G.UpgradeToTeamBundleRequestUiMode? UiMode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpgradeToTeamBundleRequest" /> class.
        /// </summary>
        /// <param name="uiMode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpgradeToTeamBundleRequest(
            global::G.UpgradeToTeamBundleRequestUiMode? uiMode)
        {
            this.UiMode = uiMode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpgradeToTeamBundleRequest" /> class.
        /// </summary>
        public UpgradeToTeamBundleRequest()
        {
        }
    }
}