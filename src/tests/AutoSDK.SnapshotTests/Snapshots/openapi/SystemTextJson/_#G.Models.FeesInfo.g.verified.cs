//HintName: G.Models.FeesInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FeesInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("processing")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Processing { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("technical")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Technical { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FeesInfo" /> class.
        /// </summary>
        /// <param name="processing"></param>
        /// <param name="technical"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FeesInfo(
            string? processing,
            string? technical)
        {
            this.Processing = processing ?? throw new global::System.ArgumentNullException(nameof(processing));
            this.Technical = technical ?? throw new global::System.ArgumentNullException(nameof(technical));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeesInfo" /> class.
        /// </summary>
        public FeesInfo()
        {
        }
    }
}