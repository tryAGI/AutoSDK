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
        [global::Newtonsoft.Json.JsonProperty("deviceId", Required = global::Newtonsoft.Json.Required.Always)]
        public string DeviceId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("connectionName", Required = global::Newtonsoft.Json.Required.Always)]
        public string ConnectionName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public global::G.EnvironmentsRegisterRequestMetadata? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentsRegisterRequest" /> class.
        /// </summary>
        /// <param name="deviceId"></param>
        /// <param name="connectionName"></param>
        /// <param name="metadata"></param>
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