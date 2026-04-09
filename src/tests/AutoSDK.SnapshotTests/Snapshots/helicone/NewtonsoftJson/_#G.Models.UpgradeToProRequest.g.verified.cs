//HintName: G.Models.UpgradeToProRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpgradeToProRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("addons")]
        public global::G.UpgradeToProRequestAddons? Addons { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("seats")]
        public double? Seats { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ui_mode")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.UpgradeToProRequestUiModeJsonConverter))]
        public global::G.UpgradeToProRequestUiMode? UiMode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpgradeToProRequest" /> class.
        /// </summary>
        /// <param name="addons"></param>
        /// <param name="seats"></param>
        /// <param name="uiMode"></param>
        public UpgradeToProRequest(
            global::G.UpgradeToProRequestAddons? addons,
            double? seats,
            global::G.UpgradeToProRequestUiMode? uiMode)
        {
            this.Addons = addons;
            this.Seats = seats;
            this.UiMode = uiMode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpgradeToProRequest" /> class.
        /// </summary>
        public UpgradeToProRequest()
        {
        }
    }
}