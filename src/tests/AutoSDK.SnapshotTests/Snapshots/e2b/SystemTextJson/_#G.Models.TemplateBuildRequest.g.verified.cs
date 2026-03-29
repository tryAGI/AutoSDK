//HintName: G.Models.TemplateBuildRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TemplateBuildRequest
    {
        /// <summary>
        /// Alias of the template
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alias")]
        public string? Alias { get; set; }

        /// <summary>
        /// Dockerfile for the template
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dockerfile")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Dockerfile { get; set; }

        /// <summary>
        /// Identifier of the team
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teamID")]
        public string? TeamID { get; set; }

        /// <summary>
        /// Start command to execute in the template after the build
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startCmd")]
        public string? StartCmd { get; set; }

        /// <summary>
        /// Ready check command to execute in the template after the build
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("readyCmd")]
        public string? ReadyCmd { get; set; }

        /// <summary>
        /// CPU cores for the sandbox
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cpuCount")]
        public int? CpuCount { get; set; }

        /// <summary>
        /// Memory for the sandbox in MiB
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memoryMB")]
        public int? MemoryMB { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateBuildRequest" /> class.
        /// </summary>
        /// <param name="dockerfile">
        /// Dockerfile for the template
        /// </param>
        /// <param name="alias">
        /// Alias of the template
        /// </param>
        /// <param name="teamID">
        /// Identifier of the team
        /// </param>
        /// <param name="startCmd">
        /// Start command to execute in the template after the build
        /// </param>
        /// <param name="readyCmd">
        /// Ready check command to execute in the template after the build
        /// </param>
        /// <param name="cpuCount">
        /// CPU cores for the sandbox
        /// </param>
        /// <param name="memoryMB">
        /// Memory for the sandbox in MiB
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TemplateBuildRequest(
            string dockerfile,
            string? alias,
            string? teamID,
            string? startCmd,
            string? readyCmd,
            int? cpuCount,
            int? memoryMB)
        {
            this.Alias = alias;
            this.Dockerfile = dockerfile ?? throw new global::System.ArgumentNullException(nameof(dockerfile));
            this.TeamID = teamID;
            this.StartCmd = startCmd;
            this.ReadyCmd = readyCmd;
            this.CpuCount = cpuCount;
            this.MemoryMB = memoryMB;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateBuildRequest" /> class.
        /// </summary>
        public TemplateBuildRequest()
        {
        }
    }
}