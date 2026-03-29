//HintName: G.Models.SessionParticipantDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SessionParticipantDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("identity", Required = global::Newtonsoft.Json.Required.Always)]
        public string Identity { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("joined_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string JoinedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("left_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string LeftAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("location", Required = global::Newtonsoft.Json.Required.Always)]
        public string Location { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("region", Required = global::Newtonsoft.Json.Required.Always)]
        public string Region { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("connection_type", Required = global::Newtonsoft.Json.Required.Always)]
        public string ConnectionType { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("device_model", Required = global::Newtonsoft.Json.Required.Always)]
        public string DeviceModel { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("os", Required = global::Newtonsoft.Json.Required.Always)]
        public string Os { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("browser", Required = global::Newtonsoft.Json.Required.Always)]
        public string Browser { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sdk_version", Required = global::Newtonsoft.Json.Required.Always)]
        public string SdkVersion { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionParticipantDto" /> class.
        /// </summary>
        /// <param name="identity"></param>
        /// <param name="name"></param>
        /// <param name="joinedAt"></param>
        /// <param name="leftAt"></param>
        /// <param name="location"></param>
        /// <param name="region"></param>
        /// <param name="connectionType"></param>
        /// <param name="deviceModel"></param>
        /// <param name="os"></param>
        /// <param name="browser"></param>
        /// <param name="sdkVersion"></param>
        public SessionParticipantDto(
            string identity,
            string name,
            string joinedAt,
            string leftAt,
            string location,
            string region,
            string connectionType,
            string deviceModel,
            string os,
            string browser,
            string sdkVersion)
        {
            this.Identity = identity ?? throw new global::System.ArgumentNullException(nameof(identity));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.JoinedAt = joinedAt ?? throw new global::System.ArgumentNullException(nameof(joinedAt));
            this.LeftAt = leftAt ?? throw new global::System.ArgumentNullException(nameof(leftAt));
            this.Location = location ?? throw new global::System.ArgumentNullException(nameof(location));
            this.Region = region ?? throw new global::System.ArgumentNullException(nameof(region));
            this.ConnectionType = connectionType ?? throw new global::System.ArgumentNullException(nameof(connectionType));
            this.DeviceModel = deviceModel ?? throw new global::System.ArgumentNullException(nameof(deviceModel));
            this.Os = os ?? throw new global::System.ArgumentNullException(nameof(os));
            this.Browser = browser ?? throw new global::System.ArgumentNullException(nameof(browser));
            this.SdkVersion = sdkVersion ?? throw new global::System.ArgumentNullException(nameof(sdkVersion));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionParticipantDto" /> class.
        /// </summary>
        public SessionParticipantDto()
        {
        }
    }
}