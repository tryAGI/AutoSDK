//HintName: G.Models.MachineInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MachineInfo
    {
        /// <summary>
        /// CPU family of the node
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cpuFamily")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CpuFamily { get; set; }

        /// <summary>
        /// CPU model of the node
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cpuModel")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CpuModel { get; set; }

        /// <summary>
        /// CPU model name of the node
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cpuModelName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CpuModelName { get; set; }

        /// <summary>
        /// CPU architecture of the node
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cpuArchitecture")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CpuArchitecture { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MachineInfo" /> class.
        /// </summary>
        /// <param name="cpuFamily">
        /// CPU family of the node
        /// </param>
        /// <param name="cpuModel">
        /// CPU model of the node
        /// </param>
        /// <param name="cpuModelName">
        /// CPU model name of the node
        /// </param>
        /// <param name="cpuArchitecture">
        /// CPU architecture of the node
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MachineInfo(
            string cpuFamily,
            string cpuModel,
            string cpuModelName,
            string cpuArchitecture)
        {
            this.CpuFamily = cpuFamily ?? throw new global::System.ArgumentNullException(nameof(cpuFamily));
            this.CpuModel = cpuModel ?? throw new global::System.ArgumentNullException(nameof(cpuModel));
            this.CpuModelName = cpuModelName ?? throw new global::System.ArgumentNullException(nameof(cpuModelName));
            this.CpuArchitecture = cpuArchitecture ?? throw new global::System.ArgumentNullException(nameof(cpuArchitecture));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MachineInfo" /> class.
        /// </summary>
        public MachineInfo()
        {
        }
    }
}