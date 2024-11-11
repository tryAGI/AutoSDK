//HintName: G.Models.ManualVerificationResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ManualVerificationResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("extra_text", Required = global::Newtonsoft.Json.Required.Always)]
        public string ExtraText { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("request_time_unix", Required = global::Newtonsoft.Json.Required.Always)]
        public int RequestTimeUnix { get; set; } = default!;

        /// <summary>
        /// 
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
        /// <param name="extraText"></param>
        /// <param name="requestTimeUnix"></param>
        /// <param name="files"></param>
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