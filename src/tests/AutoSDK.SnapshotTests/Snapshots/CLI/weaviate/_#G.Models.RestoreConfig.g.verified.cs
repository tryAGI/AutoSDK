//HintName: G.Models.RestoreConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Backup custom configuration
    /// </summary>
    public sealed partial class RestoreConfig
    {
        /// <summary>
        /// Desired CPU core utilization ranging from 1%-80%<br/>
        /// Default Value: 50
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("CPUPercentage")]
        public int? CPUPercentage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RestoreConfig" /> class.
        /// </summary>
        /// <param name="cPUPercentage">
        /// Desired CPU core utilization ranging from 1%-80%<br/>
        /// Default Value: 50
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RestoreConfig(
            int? cPUPercentage)
        {
            this.CPUPercentage = cPUPercentage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RestoreConfig" /> class.
        /// </summary>
        public RestoreConfig()
        {
        }
    }
}