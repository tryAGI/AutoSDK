//HintName: G.Models.HealthResponseHealth.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HealthResponseHealth
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("services")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.HealthService> Services { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HealthResponseHealth" /> class.
        /// </summary>
        /// <param name="services"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HealthResponseHealth(
            global::System.Collections.Generic.IList<global::G.HealthService> services)
        {
            this.Services = services ?? throw new global::System.ArgumentNullException(nameof(services));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HealthResponseHealth" /> class.
        /// </summary>
        public HealthResponseHealth()
        {
        }
    }
}