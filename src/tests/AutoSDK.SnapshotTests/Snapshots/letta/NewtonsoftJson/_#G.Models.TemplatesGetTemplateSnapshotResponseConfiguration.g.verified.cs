//HintName: G.Models.TemplatesGetTemplateSnapshotResponseConfiguration.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TemplatesGetTemplateSnapshotResponseConfiguration
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("managerAgentEntityId")]
        public string? ManagerAgentEntityId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("managerType")]
        public string? ManagerType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("terminationToken")]
        public string? TerminationToken { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("maxTurns")]
        public double? MaxTurns { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sleeptimeAgentFrequency")]
        public double? SleeptimeAgentFrequency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("maxMessageBufferLength")]
        public double? MaxMessageBufferLength { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("minMessageBufferLength")]
        public double? MinMessageBufferLength { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatesGetTemplateSnapshotResponseConfiguration" /> class.
        /// </summary>
        /// <param name="managerAgentEntityId"></param>
        /// <param name="managerType"></param>
        /// <param name="terminationToken"></param>
        /// <param name="maxTurns"></param>
        /// <param name="sleeptimeAgentFrequency"></param>
        /// <param name="maxMessageBufferLength"></param>
        /// <param name="minMessageBufferLength"></param>
        public TemplatesGetTemplateSnapshotResponseConfiguration(
            string? managerAgentEntityId,
            string? managerType,
            string? terminationToken,
            double? maxTurns,
            double? sleeptimeAgentFrequency,
            double? maxMessageBufferLength,
            double? minMessageBufferLength)
        {
            this.ManagerAgentEntityId = managerAgentEntityId;
            this.ManagerType = managerType;
            this.TerminationToken = terminationToken;
            this.MaxTurns = maxTurns;
            this.SleeptimeAgentFrequency = sleeptimeAgentFrequency;
            this.MaxMessageBufferLength = maxMessageBufferLength;
            this.MinMessageBufferLength = minMessageBufferLength;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatesGetTemplateSnapshotResponseConfiguration" /> class.
        /// </summary>
        public TemplatesGetTemplateSnapshotResponseConfiguration()
        {
        }
    }
}