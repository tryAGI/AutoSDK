//HintName: G.Models.UpdateSettingsResponseAvatars.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateSettingsResponseAvatars
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("express_slots")]
        public double? ExpressSlots { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("premiumplus_slots")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double PremiumplusSlots { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSettingsResponseAvatars" /> class.
        /// </summary>
        /// <param name="premiumplusSlots"></param>
        /// <param name="expressSlots"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateSettingsResponseAvatars(
            double premiumplusSlots,
            double? expressSlots)
        {
            this.ExpressSlots = expressSlots;
            this.PremiumplusSlots = premiumplusSlots;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSettingsResponseAvatars" /> class.
        /// </summary>
        public UpdateSettingsResponseAvatars()
        {
        }
    }
}