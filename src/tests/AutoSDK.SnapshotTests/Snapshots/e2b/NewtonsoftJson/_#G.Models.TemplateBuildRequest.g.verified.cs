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
        [global::Newtonsoft.Json.JsonProperty("alias")]
        public string? Alias { get; set; }

        /// <summary>
        /// Dockerfile for the template
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dockerfile", Required = global::Newtonsoft.Json.Required.Always)]
        public string Dockerfile { get; set; } = default!;

        /// <summary>
        /// Identifier of the team
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("teamID")]
        public string? TeamID { get; set; }

        /// <summary>
        /// Start command to execute in the template after the build
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("startCmd")]
        public string? StartCmd { get; set; }

        /// <summary>
        /// Ready check command to execute in the template after the build
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("readyCmd")]
        public string? ReadyCmd { get; set; }

        /// <summary>
        /// CPU cores for the sandbox
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cpuCount")]
        public int? CpuCount { get; set; }

        /// <summary>
        /// Memory for the sandbox in MiB
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("memoryMB")]
        public int? MemoryMB { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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