//HintName: G.Models.ToolHistory.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolHistory
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("call")]
        public global::G.Call Call { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("errorCount")]
        public int ErrorCount { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolHistory" /> class.
        /// </summary>
        /// <param name="call">
        /// Included only in responses
        /// </param>
        /// <param name="errorCount">
        /// Included only in responses
        /// </param>
        public ToolHistory(
            global::G.Call call = default!,
            int errorCount = default!)
        {
            this.Call = call;
            this.ErrorCount = errorCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolHistory" /> class.
        /// </summary>
        public ToolHistory()
        {
        }
    }
}