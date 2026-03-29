//HintName: G.Models.TopicAutomationDataScopeVariant3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TopicAutomationDataScopeVariant3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.TopicAutomationDataScopeVariant3Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("experiment_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ExperimentId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TopicAutomationDataScopeVariant3" /> class.
        /// </summary>
        /// <param name="experimentId"></param>
        /// <param name="type"></param>
        public TopicAutomationDataScopeVariant3(
            string experimentId,
            global::G.TopicAutomationDataScopeVariant3Type type)
        {
            this.Type = type;
            this.ExperimentId = experimentId ?? throw new global::System.ArgumentNullException(nameof(experimentId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TopicAutomationDataScopeVariant3" /> class.
        /// </summary>
        public TopicAutomationDataScopeVariant3()
        {
        }
    }
}