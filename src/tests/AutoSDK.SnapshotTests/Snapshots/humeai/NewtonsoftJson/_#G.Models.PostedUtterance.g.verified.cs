//HintName: G.Models.PostedUtterance.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostedUtterance
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voice")]
        public global::G.PostedUtteranceVoice? Voice { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("speed")]
        public double? Speed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("trailing_silence")]
        public double? TrailingSilence { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("instant_mode")]
        public bool? InstantMode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostedUtterance" /> class.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="description"></param>
        /// <param name="voice"></param>
        /// <param name="speed"></param>
        /// <param name="trailingSilence"></param>
        /// <param name="instantMode"></param>
        public PostedUtterance(
            string text,
            string? description,
            global::G.PostedUtteranceVoice? voice,
            double? speed,
            double? trailingSilence,
            bool? instantMode)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Description = description;
            this.Voice = voice;
            this.Speed = speed;
            this.TrailingSilence = trailingSilence;
            this.InstantMode = instantMode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostedUtterance" /> class.
        /// </summary>
        public PostedUtterance()
        {
        }
    }
}