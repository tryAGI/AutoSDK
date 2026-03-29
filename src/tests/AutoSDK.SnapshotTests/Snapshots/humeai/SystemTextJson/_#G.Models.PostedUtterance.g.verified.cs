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
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice")]
        public global::G.PostedUtteranceVoice? Voice { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed")]
        public double? Speed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trailing_silence")]
        public double? TrailingSilence { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instant_mode")]
        public bool? InstantMode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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