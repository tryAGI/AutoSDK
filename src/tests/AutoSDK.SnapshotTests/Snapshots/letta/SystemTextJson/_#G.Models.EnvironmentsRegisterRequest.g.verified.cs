//HintName: G.Models.EnvironmentsRegisterRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EnvironmentsRegisterRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deviceId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DeviceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connectionName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConnectionName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::G.EnvironmentsRegisterRequestMetadata? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentsRegisterRequest" /> class.
        /// </summary>
        /// <param name="deviceId"></param>
        /// <param name="connectionName"></param>
        /// <param name="metadata"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EnvironmentsRegisterRequest(
            string deviceId,
            string connectionName,
            global::G.EnvironmentsRegisterRequestMetadata? metadata)
        {
            this.DeviceId = deviceId ?? throw new global::System.ArgumentNullException(nameof(deviceId));
            this.ConnectionName = connectionName ?? throw new global::System.ArgumentNullException(nameof(connectionName));
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentsRegisterRequest" /> class.
        /// </summary>
        public EnvironmentsRegisterRequest()
        {
        }
    }
}