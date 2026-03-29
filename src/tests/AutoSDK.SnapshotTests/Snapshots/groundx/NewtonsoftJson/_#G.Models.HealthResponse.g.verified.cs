//HintName: G.Models.HealthResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HealthResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("health", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.HealthResponseHealth Health { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HealthResponse" /> class.
        /// </summary>
        /// <param name="health"></param>
        public HealthResponse(
            global::G.HealthResponseHealth health)
        {
            this.Health = health ?? throw new global::System.ArgumentNullException(nameof(health));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HealthResponse" /> class.
        /// </summary>
        public HealthResponse()
        {
        }
    }
}