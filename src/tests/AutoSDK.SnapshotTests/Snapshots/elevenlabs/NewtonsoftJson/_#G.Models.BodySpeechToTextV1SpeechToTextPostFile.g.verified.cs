//HintName: G.Models.BodySpeechToTextV1SpeechToTextPostFile.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The file to transcribe. All major audio and video formats are supported. Exactly one of the file or cloud_storage_url parameters must be provided. The file size must be less than 1GB.
    /// </summary>
    public sealed partial class BodySpeechToTextV1SpeechToTextPostFile
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}