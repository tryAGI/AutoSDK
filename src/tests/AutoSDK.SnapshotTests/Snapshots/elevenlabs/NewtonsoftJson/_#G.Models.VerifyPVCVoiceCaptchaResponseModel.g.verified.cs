//HintName: G.Models.VerifyPVCVoiceCaptchaResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VerifyPVCVoiceCaptchaResponseModel
    {
        /// <summary>
        /// The status of the verify PVC captcha request. If the request was successful, the status will be 'ok'. Otherwise an error message with status 500 will be returned.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public string Status { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VerifyPVCVoiceCaptchaResponseModel" /> class.
        /// </summary>
        /// <param name="status">
        /// The status of the verify PVC captcha request. If the request was successful, the status will be 'ok'. Otherwise an error message with status 500 will be returned.
        /// </param>
        public VerifyPVCVoiceCaptchaResponseModel(
            string status)
        {
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VerifyPVCVoiceCaptchaResponseModel" /> class.
        /// </summary>
        public VerifyPVCVoiceCaptchaResponseModel()
        {
        }
    }
}