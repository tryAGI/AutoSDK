//HintName: G.Models.ParentSoundSettings.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ParentSoundSettings
    {
        /// <summary>
        /// Default Value: 0.18F
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("defaultSoundtrackVolume")]
        public double? DefaultSoundtrackVolume { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("soundtracks")]
        public global::System.Collections.Generic.IList<global::G.ParentSoundtrackRegion>? Soundtracks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ParentSoundSettings" /> class.
        /// </summary>
        /// <param name="defaultSoundtrackVolume">
        /// Default Value: 0.18F
        /// </param>
        /// <param name="soundtracks">
        /// Default Value: []
        /// </param>
        public ParentSoundSettings(
            double? defaultSoundtrackVolume,
            global::System.Collections.Generic.IList<global::G.ParentSoundtrackRegion>? soundtracks)
        {
            this.DefaultSoundtrackVolume = defaultSoundtrackVolume;
            this.Soundtracks = soundtracks;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParentSoundSettings" /> class.
        /// </summary>
        public ParentSoundSettings()
        {
        }
    }
}