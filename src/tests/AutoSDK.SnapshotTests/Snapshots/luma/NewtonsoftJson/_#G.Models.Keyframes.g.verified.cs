//HintName: G.Models.Keyframes.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The keyframes of the generation
    /// </summary>
    public sealed partial class Keyframes
    {
        /// <summary>
        /// A keyframe can be either a Generation reference, an Image, or a Video
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("frame0")]
        public global::G.Keyframe? Frame0 { get; set; }

        /// <summary>
        /// A keyframe can be either a Generation reference, an Image, or a Video
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("frame1")]
        public global::G.Keyframe? Frame1 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Keyframes" /> class.
        /// </summary>
        /// <param name="frame0">
        /// A keyframe can be either a Generation reference, an Image, or a Video
        /// </param>
        /// <param name="frame1">
        /// A keyframe can be either a Generation reference, an Image, or a Video
        /// </param>
        public Keyframes(
            global::G.Keyframe? frame0,
            global::G.Keyframe? frame1)
        {
            this.Frame0 = frame0;
            this.Frame1 = frame1;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Keyframes" /> class.
        /// </summary>
        public Keyframes()
        {
        }
    }
}