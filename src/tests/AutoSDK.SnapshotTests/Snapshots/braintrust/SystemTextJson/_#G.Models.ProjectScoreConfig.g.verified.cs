//HintName: G.Models.ProjectScoreConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectScoreConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("multi_select")]
        public bool? MultiSelect { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("destination")]
        public string? Destination { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("online")]
        public global::G.OnlineScoreConfig? Online { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectScoreConfig" /> class.
        /// </summary>
        /// <param name="multiSelect"></param>
        /// <param name="destination"></param>
        /// <param name="online"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectScoreConfig(
            bool? multiSelect,
            string? destination,
            global::G.OnlineScoreConfig? online)
        {
            this.MultiSelect = multiSelect;
            this.Destination = destination;
            this.Online = online;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectScoreConfig" /> class.
        /// </summary>
        public ProjectScoreConfig()
        {
        }
    }
}