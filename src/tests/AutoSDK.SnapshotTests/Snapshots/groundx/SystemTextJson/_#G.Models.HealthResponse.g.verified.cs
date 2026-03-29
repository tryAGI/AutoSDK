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
        [global::System.Text.Json.Serialization.JsonPropertyName("health")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.HealthResponseHealth Health { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HealthResponse" /> class.
        /// </summary>
        /// <param name="health"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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