//HintName: G.Models.EnvironmentsRegisterRequestMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EnvironmentsRegisterRequestMetadata
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("os")]
        public string? Os { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lettaCodeVersion")]
        public string? LettaCodeVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nodeVersion")]
        public string? NodeVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workingDirectory")]
        public string? WorkingDirectory { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gitBranch")]
        public string? GitBranch { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentsRegisterRequestMetadata" /> class.
        /// </summary>
        /// <param name="os"></param>
        /// <param name="lettaCodeVersion"></param>
        /// <param name="nodeVersion"></param>
        /// <param name="workingDirectory"></param>
        /// <param name="gitBranch"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EnvironmentsRegisterRequestMetadata(
            string? os,
            string? lettaCodeVersion,
            string? nodeVersion,
            string? workingDirectory,
            string? gitBranch)
        {
            this.Os = os;
            this.LettaCodeVersion = lettaCodeVersion;
            this.NodeVersion = nodeVersion;
            this.WorkingDirectory = workingDirectory;
            this.GitBranch = gitBranch;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentsRegisterRequestMetadata" /> class.
        /// </summary>
        public EnvironmentsRegisterRequestMetadata()
        {
        }
    }
}