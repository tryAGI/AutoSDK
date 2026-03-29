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
        [global::System.Text.Json.Serialization.JsonPropertyName("min_required_weave_python_version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MinRequiredWeavePythonVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace_server_version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TraceServerVersion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerInfoRes" /> class.
        /// </summary>
        /// <param name="minRequiredWeavePythonVersion"></param>
        /// <param name="traceServerVersion"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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