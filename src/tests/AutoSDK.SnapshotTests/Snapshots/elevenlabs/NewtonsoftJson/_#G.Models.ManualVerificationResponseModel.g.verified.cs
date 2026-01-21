//HintName: G.Models.ManualVerificationResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"extra_text":"Please verify the voice is that of a female.","files":[{"file_id":"CwhRBWXzGAHq8TQ4Fs18","file_name":"file.mp3","mime_type":"audio/mpeg","size_bytes":1000000,"upload_date_unix":1714204800}],"request_time_unix":1714204800}
    /// </summary>
    public sealed partial class ManualVerificationResponseModel
    {
        /// <summary>
        /// The extra text of the manual verification.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("extra_text", Required = global::Newtonsoft.Json.Required.Always)]
        public string ExtraText { get; set; } = default!;

        /// <summary>
        /// The date of the manual verification in Unix time.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("request_time_unix", Required = global::Newtonsoft.Json.Required.Always)]
        public int RequestTimeUnix { get; set; } = default!;

        /// <summary>
        /// The files of the manual verification.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("files", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ManualVerificationFileResponseModel> Files { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ManualVerificationResponseModel" /> class.
        /// </summary>
        /// <param name="extraText">
        /// The extra text of the manual verification.
        /// </param>
        /// <param name="requestTimeUnix">
        /// The date of the manual verification in Unix time.
        /// </param>
        /// <param name="files">
        /// The files of the manual verification.
        /// </param>
        public ManualVerificationResponseModel(
            string extraText,
            int requestTimeUnix,
            global::System.Collections.Generic.IList<global::G.ManualVerificationFileResponseModel> files)
        {
            this.ExtraText = extraText ?? throw new global::System.ArgumentNullException(nameof(extraText));
            this.RequestTimeUnix = requestTimeUnix;
            this.Files = files ?? throw new global::System.ArgumentNullException(nameof(files));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ManualVerificationResponseModel" /> class.
        /// </summary>
        public ManualVerificationResponseModel()
        {
        }
    }
}