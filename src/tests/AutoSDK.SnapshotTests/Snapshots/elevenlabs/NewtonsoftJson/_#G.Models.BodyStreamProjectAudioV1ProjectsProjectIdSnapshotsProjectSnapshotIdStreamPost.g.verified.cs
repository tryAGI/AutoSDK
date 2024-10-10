//HintName: G.Models.BodyStreamProjectAudioV1ProjectsProjectIdSnapshotsProjectSnapshotIdStreamPost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyStreamProjectAudioV1ProjectsProjectIdSnapshotsProjectSnapshotIdStreamPost
    {
        /// <summary>
        /// Whether to convert the audio to mpeg format.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("convert_to_mpeg")]
        public bool? ConvertToMpeg { get; set; } = false;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}