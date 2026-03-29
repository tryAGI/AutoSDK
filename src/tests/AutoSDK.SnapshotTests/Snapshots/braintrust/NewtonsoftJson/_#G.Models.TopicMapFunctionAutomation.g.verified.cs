//HintName: G.Models.TopicMapFunctionAutomation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TopicMapFunctionAutomation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("function", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AllOf<global::G.SavedFunctionId?, global::G.AnyOf<global::G.TopicMapFunctionAutomationFunctionVariant2Function, global::G.TopicMapFunctionAutomationFunctionVariant2Global>?> Function { get; set; } = default!;

        /// <summary>
        /// Per-topic-map BTQL filter. For trace scope, a topic map runs when max(filter) over the trace is truthy. For span scope, it runs when the current span matches.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("btql_filter")]
        public string? BtqlFilter { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TopicMapFunctionAutomation" /> class.
        /// </summary>
        /// <param name="function"></param>
        /// <param name="btqlFilter">
        /// Per-topic-map BTQL filter. For trace scope, a topic map runs when max(filter) over the trace is truthy. For span scope, it runs when the current span matches.
        /// </param>
        public TopicMapFunctionAutomation(
            global::G.AllOf<global::G.SavedFunctionId?, global::G.AnyOf<global::G.TopicMapFunctionAutomationFunctionVariant2Function, global::G.TopicMapFunctionAutomationFunctionVariant2Global>?> function,
            string? btqlFilter)
        {
            this.Function = function;
            this.BtqlFilter = btqlFilter;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TopicMapFunctionAutomation" /> class.
        /// </summary>
        public TopicMapFunctionAutomation()
        {
        }
    }
}