//HintName: G.Models.PatchConvAIDashboardSettingsRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchConvAIDashboardSettingsRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("charts")]
        public global::System.Collections.Generic.IList<global::G.ChartsItem2>? Charts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchConvAIDashboardSettingsRequest" /> class.
        /// </summary>
        /// <param name="charts"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchConvAIDashboardSettingsRequest(
            global::System.Collections.Generic.IList<global::G.ChartsItem2>? charts)
        {
            this.Charts = charts;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchConvAIDashboardSettingsRequest" /> class.
        /// </summary>
        public PatchConvAIDashboardSettingsRequest()
        {
        }
    }
}