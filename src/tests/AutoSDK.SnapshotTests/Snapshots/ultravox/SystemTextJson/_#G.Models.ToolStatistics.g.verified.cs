//HintName: G.Models.ToolStatistics.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolStatistics
    {
        /// <summary>
        /// Default Value: 0<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("errorCount")]
        public int ErrorCount { get; set; } = default!;

        /// <summary>
        /// Default Value: 0<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("timesCalled")]
        public int TimesCalled { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolStatistics" /> class.
        /// </summary>
        /// <param name="errorCount">
        /// Default Value: 0<br/>
        /// Included only in responses
        /// </param>
        /// <param name="timesCalled">
        /// Default Value: 0<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolStatistics(
            int errorCount = default!,
            int timesCalled = default!)
        {
            this.ErrorCount = errorCount;
            this.TimesCalled = timesCalled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolStatistics" /> class.
        /// </summary>
        public ToolStatistics()
        {
        }
    }
}