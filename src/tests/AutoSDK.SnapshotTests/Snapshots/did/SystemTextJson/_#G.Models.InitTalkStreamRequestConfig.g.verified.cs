//HintName: G.Models.InitTalkStreamRequestConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Advanced configuration options.
    /// </summary>
    public sealed partial class InitTalkStreamRequestConfig
    {
        /// <summary>
        /// Stitch back the animated result to the original image
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stitch")]
        public bool? Stitch { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InitTalkStreamRequestConfig" /> class.
        /// </summary>
        /// <param name="stitch">
        /// Stitch back the animated result to the original image
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InitTalkStreamRequestConfig(
            bool? stitch)
        {
            this.Stitch = stitch;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InitTalkStreamRequestConfig" /> class.
        /// </summary>
        public InitTalkStreamRequestConfig()
        {
        }
    }
}