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
        [global::System.Text.Json.Serialization.JsonPropertyName("managerAgentEntityId")]
        public string? ManagerAgentEntityId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("managerType")]
        public string? ManagerType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("terminationToken")]
        public string? TerminationToken { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxTurns")]
        public double? MaxTurns { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sleeptimeAgentFrequency")]
        public double? SleeptimeAgentFrequency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxMessageBufferLength")]
        public double? MaxMessageBufferLength { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minMessageBufferLength")]
        public double? MinMessageBufferLength { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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