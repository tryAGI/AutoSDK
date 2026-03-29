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
        [global::Newtonsoft.Json.JsonProperty("cpuFamily", Required = global::Newtonsoft.Json.Required.Always)]
        public string CpuFamily { get; set; } = default!;

        /// <summary>
        /// CPU model of the node
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cpuModel", Required = global::Newtonsoft.Json.Required.Always)]
        public string CpuModel { get; set; } = default!;

        /// <summary>
        /// CPU model name of the node
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cpuModelName", Required = global::Newtonsoft.Json.Required.Always)]
        public string CpuModelName { get; set; } = default!;

        /// <summary>
        /// CPU architecture of the node
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cpuArchitecture", Required = global::Newtonsoft.Json.Required.Always)]
        public string CpuArchitecture { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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