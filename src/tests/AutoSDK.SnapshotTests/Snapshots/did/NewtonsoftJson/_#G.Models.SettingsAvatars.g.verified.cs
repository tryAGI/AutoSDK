//HintName: G.Models.SettingsAvatars.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SettingsAvatars
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("express_slots")]
        public double? ExpressSlots { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("premiumplus_slots", Required = global::Newtonsoft.Json.Required.Always)]
        public double PremiumplusSlots { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SettingsAvatars" /> class.
        /// </summary>
        /// <param name="premiumplusSlots"></param>
        /// <param name="expressSlots"></param>
        public SettingsAvatars(
            double premiumplusSlots,
            double? expressSlots)
        {
            this.ExpressSlots = expressSlots;
            this.PremiumplusSlots = premiumplusSlots;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SettingsAvatars" /> class.
        /// </summary>
        public SettingsAvatars()
        {
        }
    }
}