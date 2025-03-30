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
        /// The extra text of the manual verification.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extra_text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ExtraText { get; set; }

        /// <summary>
        /// The date of the manual verification in Unix time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_time_unix")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RequestTimeUnix { get; set; }

        /// <summary>
        /// The files of the manual verification.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("files")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ManualVerificationFileResponseModel> Files { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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