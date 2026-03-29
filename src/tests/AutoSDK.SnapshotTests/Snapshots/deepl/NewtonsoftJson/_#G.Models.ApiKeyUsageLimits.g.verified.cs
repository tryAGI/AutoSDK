//HintName: G.Models.ApiKeyUsageLimits.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Usage limits for the API key.
    /// </summary>
    public sealed partial class ApiKeyUsageLimits
    {
        /// <summary>
        /// Restricts the number of total characters (across text translation, document translation, and text improvement) that can be consumed by an API key in a one-month usage period.<br/>
        /// Setting the limit to `0` means the API key will not be able to consume characters.<br/>
        /// Setting the limit to `null` disables the limit, effectively allowing unlimited usage.<br/>
        /// Example: 5000
        /// </summary>
        /// <example>5000</example>
        [global::Newtonsoft.Json.JsonProperty("characters")]
        public double? Characters { get; set; }

        /// <summary>
        /// Restricts the number of milliseconds of speech-to-text that can be consumed by an API key in a one-month usage period.<br/>
        /// Setting the limit to `0` means the API key will not be able to consume speech-to-text milliseconds.<br/>
        /// Setting the limit to `null` disables the limit, effectively allowing unlimited usage.<br/>
        /// Example: 3600000
        /// </summary>
        /// <example>3600000</example>
        [global::Newtonsoft.Json.JsonProperty("speech_to_text_milliseconds")]
        public double? SpeechToTextMilliseconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKeyUsageLimits" /> class.
        /// </summary>
        /// <param name="characters">
        /// Restricts the number of total characters (across text translation, document translation, and text improvement) that can be consumed by an API key in a one-month usage period.<br/>
        /// Setting the limit to `0` means the API key will not be able to consume characters.<br/>
        /// Setting the limit to `null` disables the limit, effectively allowing unlimited usage.<br/>
        /// Example: 5000
        /// </param>
        /// <param name="speechToTextMilliseconds">
        /// Restricts the number of milliseconds of speech-to-text that can be consumed by an API key in a one-month usage period.<br/>
        /// Setting the limit to `0` means the API key will not be able to consume speech-to-text milliseconds.<br/>
        /// Setting the limit to `null` disables the limit, effectively allowing unlimited usage.<br/>
        /// Example: 3600000
        /// </param>
        public ApiKeyUsageLimits(
            double? characters,
            double? speechToTextMilliseconds)
        {
            this.Characters = characters;
            this.SpeechToTextMilliseconds = speechToTextMilliseconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKeyUsageLimits" /> class.
        /// </summary>
        public ApiKeyUsageLimits()
        {
        }
    }
}