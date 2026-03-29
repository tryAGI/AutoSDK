//HintName: G.Models.CartesiaGenerationConfigExperimental.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CartesiaGenerationConfigExperimental
    {
        /// <summary>
        /// Toggle accent localization for sonic-3: 0 (disabled, default) or 1 (enabled). When enabled, the voice adapts to match the transcript language accent while preserving vocal characteristics.<br/>
        /// Default Value: 0<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("accentLocalization")]
        public int? AccentLocalization { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CartesiaGenerationConfigExperimental" /> class.
        /// </summary>
        /// <param name="accentLocalization">
        /// Toggle accent localization for sonic-3: 0 (disabled, default) or 1 (enabled). When enabled, the voice adapts to match the transcript language accent while preserving vocal characteristics.<br/>
        /// Default Value: 0<br/>
        /// Example: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CartesiaGenerationConfigExperimental(
            int? accentLocalization)
        {
            this.AccentLocalization = accentLocalization;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CartesiaGenerationConfigExperimental" /> class.
        /// </summary>
        public CartesiaGenerationConfigExperimental()
        {
        }
    }
}