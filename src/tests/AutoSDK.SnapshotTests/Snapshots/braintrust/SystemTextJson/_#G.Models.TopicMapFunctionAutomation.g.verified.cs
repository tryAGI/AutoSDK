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
        [global::System.Text.Json.Serialization.JsonPropertyName("function")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AllOfJsonConverter<global::G.SavedFunctionId?, global::G.AnyOf<global::G.TopicMapFunctionAutomationFunctionVariant2Function, global::G.TopicMapFunctionAutomationFunctionVariant2Global>?>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AllOf<global::G.SavedFunctionId?, global::G.AnyOf<global::G.TopicMapFunctionAutomationFunctionVariant2Function, global::G.TopicMapFunctionAutomationFunctionVariant2Global>?> Function { get; set; }

        /// <summary>
        /// Per-topic-map BTQL filter. For trace scope, a topic map runs when max(filter) over the trace is truthy. For span scope, it runs when the current span matches.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("btql_filter")]
        public string? BtqlFilter { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TopicMapFunctionAutomation" /> class.
        /// </summary>
        /// <param name="function"></param>
        /// <param name="btqlFilter">
        /// Per-topic-map BTQL filter. For trace scope, a topic map runs when max(filter) over the trace is truthy. For span scope, it runs when the current span matches.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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