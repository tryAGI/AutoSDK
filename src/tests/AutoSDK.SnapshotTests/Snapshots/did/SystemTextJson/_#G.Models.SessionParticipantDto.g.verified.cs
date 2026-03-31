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
        [global::System.Text.Json.Serialization.JsonPropertyName("identity")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Identity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("joined_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string JoinedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("left_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LeftAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("location")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Location { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Region { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connection_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConnectionType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("device_model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DeviceModel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("os")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Os { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("browser")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Browser { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sdk_version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SdkVersion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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