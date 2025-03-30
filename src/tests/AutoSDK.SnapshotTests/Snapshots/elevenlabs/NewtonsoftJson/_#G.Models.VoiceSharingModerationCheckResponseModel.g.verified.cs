//HintName: G.Models.VoiceSharingModerationCheckResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VoiceSharingModerationCheckResponseModel
    {
        /// <summary>
        /// The date the moderation check was made in Unix time.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("date_checked_unix")]
        public int? DateCheckedUnix { get; set; }

        /// <summary>
        /// The name value of the voice.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name_value")]
        public string? NameValue { get; set; }

        /// <summary>
        /// Whether the name check was successful.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name_check")]
        public bool? NameCheck { get; set; }

        /// <summary>
        /// The description value of the voice.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description_value")]
        public string? DescriptionValue { get; set; }

        /// <summary>
        /// Whether the description check was successful.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description_check")]
        public bool? DescriptionCheck { get; set; }

        /// <summary>
        /// A list of sample IDs.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sample_ids")]
        public global::System.Collections.Generic.IList<string>? SampleIds { get; set; }

        /// <summary>
        /// A list of sample checks.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sample_checks")]
        public global::System.Collections.Generic.IList<double>? SampleChecks { get; set; }

        /// <summary>
        /// A list of captcha IDs.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("captcha_ids")]
        public global::System.Collections.Generic.IList<string>? CaptchaIds { get; set; }

        /// <summary>
        /// A list of CAPTCHA check values.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("captcha_checks")]
        public global::System.Collections.Generic.IList<double>? CaptchaChecks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceSharingModerationCheckResponseModel" /> class.
        /// </summary>
        /// <param name="dateCheckedUnix">
        /// The date the moderation check was made in Unix time.
        /// </param>
        /// <param name="nameValue">
        /// The name value of the voice.
        /// </param>
        /// <param name="nameCheck">
        /// Whether the name check was successful.
        /// </param>
        /// <param name="descriptionValue">
        /// The description value of the voice.
        /// </param>
        /// <param name="descriptionCheck">
        /// Whether the description check was successful.
        /// </param>
        /// <param name="sampleIds">
        /// A list of sample IDs.
        /// </param>
        /// <param name="sampleChecks">
        /// A list of sample checks.
        /// </param>
        /// <param name="captchaIds">
        /// A list of captcha IDs.
        /// </param>
        /// <param name="captchaChecks">
        /// A list of CAPTCHA check values.
        /// </param>
        public VoiceSharingModerationCheckResponseModel(
            int? dateCheckedUnix,
            string? nameValue,
            bool? nameCheck,
            string? descriptionValue,
            bool? descriptionCheck,
            global::System.Collections.Generic.IList<string>? sampleIds,
            global::System.Collections.Generic.IList<double>? sampleChecks,
            global::System.Collections.Generic.IList<string>? captchaIds,
            global::System.Collections.Generic.IList<double>? captchaChecks)
        {
            this.DateCheckedUnix = dateCheckedUnix;
            this.NameValue = nameValue;
            this.NameCheck = nameCheck;
            this.DescriptionValue = descriptionValue;
            this.DescriptionCheck = descriptionCheck;
            this.SampleIds = sampleIds;
            this.SampleChecks = sampleChecks;
            this.CaptchaIds = captchaIds;
            this.CaptchaChecks = captchaChecks;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceSharingModerationCheckResponseModel" /> class.
        /// </summary>
        public VoiceSharingModerationCheckResponseModel()
        {
        }
    }
}