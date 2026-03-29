//HintName: G.Models.P2pConfigTelemetry.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class P2pConfigTelemetry
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connection_pool_size")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ConnectionPoolSize { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="P2pConfigTelemetry" /> class.
        /// </summary>
        /// <param name="connectionPoolSize"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public P2pConfigTelemetry(
            int connectionPoolSize)
        {
            this.ConnectionPoolSize = connectionPoolSize;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="P2pConfigTelemetry" /> class.
        /// </summary>
        public P2pConfigTelemetry()
        {
        }
    }
}