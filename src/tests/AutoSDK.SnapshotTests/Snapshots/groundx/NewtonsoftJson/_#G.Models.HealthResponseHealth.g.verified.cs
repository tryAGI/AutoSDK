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
        [global::Newtonsoft.Json.JsonProperty("services", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.HealthService> Services { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HealthResponseHealth" /> class.
        /// </summary>
        /// <param name="services"></param>
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