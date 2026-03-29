//HintName: G.Models.SinkStrategy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SinkStrategy
    {
        /// <summary>
        /// 是否检查索引成功
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("check_index")]
        public bool? CheckIndex { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SinkStrategy" /> class.
        /// </summary>
        /// <param name="checkIndex">
        /// 是否检查索引成功
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SinkStrategy(
            bool? checkIndex)
        {
            this.CheckIndex = checkIndex;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SinkStrategy" /> class.
        /// </summary>
        public SinkStrategy()
        {
        }
    }
}