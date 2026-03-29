//HintName: G.Models.PropertiesConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 可选参数，room 的配置
    /// </summary>
    public sealed partial class PropertiesConfig
    {
        /// <summary>
        /// 房间音频配置
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("audio_config")]
        public global::G.PropertiesConfigPropertiesAudioConfig? AudioConfig { get; set; }

        /// <summary>
        /// 自定义开场白
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prologue_content")]
        public string? PrologueContent { get; set; }

        /// <summary>
        /// 在进房后等待多长时间播放开场白，默认是500ms，[0, 5000]
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prologue_delay_duration_ms")]
        public int? PrologueDelayDurationMs { get; set; }

        /// <summary>
        /// 房间模式
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("room_mode")]
        public global::G.PropertiesConfigRoomMode? RoomMode { get; set; }

        /// <summary>
        /// 语音检测配置
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("turn_detection")]
        public global::G.PropertiesConfigPropertiesTurnDetection? TurnDetection { get; set; }

        /// <summary>
        /// 房间视频配置
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("video_config")]
        public global::G.PropertiesConfigPropertiesVideoConfig? VideoConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertiesConfig" /> class.
        /// </summary>
        /// <param name="audioConfig">
        /// 房间音频配置
        /// </param>
        /// <param name="prologueContent">
        /// 自定义开场白
        /// </param>
        /// <param name="prologueDelayDurationMs">
        /// 在进房后等待多长时间播放开场白，默认是500ms，[0, 5000]
        /// </param>
        /// <param name="roomMode">
        /// 房间模式
        /// </param>
        /// <param name="turnDetection">
        /// 语音检测配置
        /// </param>
        /// <param name="videoConfig">
        /// 房间视频配置
        /// </param>
        public PropertiesConfig(
            global::G.PropertiesConfigPropertiesAudioConfig? audioConfig,
            string? prologueContent,
            int? prologueDelayDurationMs,
            global::G.PropertiesConfigRoomMode? roomMode,
            global::G.PropertiesConfigPropertiesTurnDetection? turnDetection,
            global::G.PropertiesConfigPropertiesVideoConfig? videoConfig)
        {
            this.AudioConfig = audioConfig;
            this.PrologueContent = prologueContent;
            this.PrologueDelayDurationMs = prologueDelayDurationMs;
            this.RoomMode = roomMode;
            this.TurnDetection = turnDetection;
            this.VideoConfig = videoConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertiesConfig" /> class.
        /// </summary>
        public PropertiesConfig()
        {
        }
    }
}