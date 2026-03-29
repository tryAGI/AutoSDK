//HintName: G.Models.PropertiesConfigPropertiesVideoConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 房间视频配置
    /// </summary>
    public sealed partial class PropertiesConfigPropertiesVideoConfig
    {
        /// <summary>
        /// 房间视频编码格式，H264 / BYTEVC1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("codec")]
        public string? Codec { get; set; }

        /// <summary>
        /// 房间视频流类型, 支持 main/screen, main: 主流。包括：「由摄像头/麦克风通过内部采集机制，采集到的流。」和「通过自定义采集，采集到的流。」，screen：屏幕流
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stream_video_type")]
        public string? StreamVideoType { get; set; }

        /// <summary>
        /// 视频帧过期时间，单位为s，默认值是1，[1, 10]
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("video_frame_expire_duration")]
        public int? VideoFrameExpireDuration { get; set; }

        /// <summary>
        /// 视频抽帧速率，默认值是1，[1, 24]
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("video_frame_rate")]
        public int? VideoFrameRate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertiesConfigPropertiesVideoConfig" /> class.
        /// </summary>
        /// <param name="codec">
        /// 房间视频编码格式，H264 / BYTEVC1
        /// </param>
        /// <param name="streamVideoType">
        /// 房间视频流类型, 支持 main/screen, main: 主流。包括：「由摄像头/麦克风通过内部采集机制，采集到的流。」和「通过自定义采集，采集到的流。」，screen：屏幕流
        /// </param>
        /// <param name="videoFrameExpireDuration">
        /// 视频帧过期时间，单位为s，默认值是1，[1, 10]
        /// </param>
        /// <param name="videoFrameRate">
        /// 视频抽帧速率，默认值是1，[1, 24]
        /// </param>
        public PropertiesConfigPropertiesVideoConfig(
            string? codec,
            string? streamVideoType,
            int? videoFrameExpireDuration,
            int? videoFrameRate)
        {
            this.Codec = codec;
            this.StreamVideoType = streamVideoType;
            this.VideoFrameExpireDuration = videoFrameExpireDuration;
            this.VideoFrameRate = videoFrameRate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertiesConfigPropertiesVideoConfig" /> class.
        /// </summary>
        public PropertiesConfigPropertiesVideoConfig()
        {
        }
    }
}