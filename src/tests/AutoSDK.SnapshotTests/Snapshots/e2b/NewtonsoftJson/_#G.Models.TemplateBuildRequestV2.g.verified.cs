//HintName: G.Models.TemplateBuildRequestV2.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TemplateBuildRequestV2
    {
        /// <summary>
        /// Alias of the template
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("alias", Required = global::Newtonsoft.Json.Required.Always)]
        public string Alias { get; set; } = default!;

        /// <summary>
        /// Identifier of the team
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("teamID")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? TeamID { get; set; }

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
        /// Initializes a new instance of the <see cref="TemplateBuildRequestV2" /> class.
        /// </summary>
        /// <param name="alias">
        /// Alias of the template
        /// </param>
        /// <param name="cpuCount">
        /// CPU cores for the sandbox
        /// </param>
        /// <param name="memoryMB">
        /// Memory for the sandbox in MiB
        /// </param>
        public TemplateBuildRequestV2(
            string alias,
            int? cpuCount,
            int? memoryMB)
        {
            this.Alias = alias ?? throw new global::System.ArgumentNullException(nameof(alias));
            this.CpuCount = cpuCount;
            this.MemoryMB = memoryMB;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateBuildRequestV2" /> class.
        /// </summary>
        public TemplateBuildRequestV2()
        {
        }
    }
}