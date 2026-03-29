//HintName: G.Models.UpdateRule.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateRule
    {
        /// <summary>
        /// 更新间隔，单位(天)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("update_interval")]
        public int? UpdateInterval { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("update_type")]
        public int? UpdateType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateRule" /> class.
        /// </summary>
        /// <param name="updateInterval">
        /// 更新间隔，单位(天)
        /// </param>
        /// <param name="updateType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateRule(
            int? updateInterval,
            int? updateType)
        {
            this.UpdateInterval = updateInterval;
            this.UpdateType = updateType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateRule" /> class.
        /// </summary>
        public UpdateRule()
        {
        }
    }
}