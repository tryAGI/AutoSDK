//HintName: G.Models.ServerInfoRes.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ServerInfoRes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("min_required_weave_python_version", Required = global::Newtonsoft.Json.Required.Always)]
        public string MinRequiredWeavePythonVersion { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("trace_server_version", Required = global::Newtonsoft.Json.Required.Always)]
        public string TraceServerVersion { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerInfoRes" /> class.
        /// </summary>
        /// <param name="minRequiredWeavePythonVersion"></param>
        /// <param name="traceServerVersion"></param>
        public ServerInfoRes(
            string minRequiredWeavePythonVersion,
            string traceServerVersion)
        {
            this.MinRequiredWeavePythonVersion = minRequiredWeavePythonVersion ?? throw new global::System.ArgumentNullException(nameof(minRequiredWeavePythonVersion));
            this.TraceServerVersion = traceServerVersion ?? throw new global::System.ArgumentNullException(nameof(traceServerVersion));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerInfoRes" /> class.
        /// </summary>
        public ServerInfoRes()
        {
        }
    }
}