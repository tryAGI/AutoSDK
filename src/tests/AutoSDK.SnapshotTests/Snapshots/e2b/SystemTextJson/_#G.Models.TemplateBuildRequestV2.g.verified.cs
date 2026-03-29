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
        [global::System.Text.Json.Serialization.JsonPropertyName("alias")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Alias { get; set; }

        /// <summary>
        /// Identifier of the team
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teamID")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? TeamID { get; set; }

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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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