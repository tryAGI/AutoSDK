//HintName: G.Models.FileResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FileResponse
    {
        /// <summary>
        /// The file id
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The name of the uploaded file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// The link used to download the file if audio_url was used
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        public string? Source { get; set; }

        /// <summary>
        /// Duration of the audio file<br/>
        /// Example: 3600
        /// </summary>
        /// <example>3600</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_duration")]
        public double? AudioDuration { get; set; }

        /// <summary>
        /// Number of channels in the audio file<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("number_of_channels")]
        public int? NumberOfChannels { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// The file id
        /// </param>
        /// <param name="filename">
        /// The name of the uploaded file
        /// </param>
        /// <param name="source">
        /// The link used to download the file if audio_url was used
        /// </param>
        /// <param name="audioDuration">
        /// Duration of the audio file<br/>
        /// Example: 3600
        /// </param>
        /// <param name="numberOfChannels">
        /// Number of channels in the audio file<br/>
        /// Example: 1
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FileResponse(
            string id,
            string? filename,
            string? source,
            double? audioDuration,
            int? numberOfChannels)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Filename = filename;
            this.Source = source;
            this.AudioDuration = audioDuration;
            this.NumberOfChannels = numberOfChannels;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileResponse" /> class.
        /// </summary>
        public FileResponse()
        {
        }
    }
}