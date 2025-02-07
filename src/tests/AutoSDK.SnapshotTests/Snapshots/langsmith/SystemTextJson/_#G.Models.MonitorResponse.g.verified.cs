//HintName: G.Models.MonitorResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MonitorResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blocks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.MonitorBlock> Blocks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MonitorResponse" /> class.
        /// </summary>
        /// <param name="blocks"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MonitorResponse(
            global::System.Collections.Generic.IList<global::G.MonitorBlock> blocks)
        {
            this.Blocks = blocks ?? throw new global::System.ArgumentNullException(nameof(blocks));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MonitorResponse" /> class.
        /// </summary>
        public MonitorResponse()
        {
        }
    }
}