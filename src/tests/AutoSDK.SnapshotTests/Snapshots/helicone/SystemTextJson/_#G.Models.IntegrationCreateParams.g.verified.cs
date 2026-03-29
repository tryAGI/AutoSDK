//HintName: G.Models.IntegrationCreateParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IntegrationCreateParams
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integration_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IntegrationName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("settings")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.JsonJsonConverter))]
        public global::G.Json? Settings { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationCreateParams" /> class.
        /// </summary>
        /// <param name="integrationName"></param>
        /// <param name="settings"></param>
        /// <param name="active"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IntegrationCreateParams(
            string integrationName,
            global::G.Json? settings,
            bool? active)
        {
            this.IntegrationName = integrationName ?? throw new global::System.ArgumentNullException(nameof(integrationName));
            this.Settings = settings;
            this.Active = active;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationCreateParams" /> class.
        /// </summary>
        public IntegrationCreateParams()
        {
        }
    }
}