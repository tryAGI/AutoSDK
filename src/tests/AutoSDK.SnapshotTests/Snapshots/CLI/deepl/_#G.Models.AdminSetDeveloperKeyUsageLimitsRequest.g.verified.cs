//HintName: G.Models.AdminSetDeveloperKeyUsageLimitsRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AdminSetDeveloperKeyUsageLimitsRequest
    {
        /// <summary>
        /// API key ID. Consists of two valid GUIDs separated by a colon.<br/>
        /// Example: ca7d5694-96eb-4263-a9a4-7f7e4211529e:20c2abcf-4c3c-4cd6-8ae8-8bd2a7d4da38
        /// </summary>
        /// <example>ca7d5694-96eb-4263-a9a4-7f7e4211529e:20c2abcf-4c3c-4cd6-8ae8-8bd2a7d4da38</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("key_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string KeyId { get; set; }

        /// <summary>
        /// Restricts the number of total characters (across text translation, document translation, and text improvement) that can be consumed by an API key in a one-month usage period.<br/>
        /// Setting the limit to `0` means the API key will not be able to consume characters.<br/>
        /// Setting the limit to `null` disables the limit, effectively allowing unlimited usage.<br/>
        /// Example: 5000
        /// </summary>
        /// <example>5000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("characters")]
        public double? Characters { get; set; }

        /// <summary>
        /// Restricts the number of milliseconds of speech-to-text that can be consumed by an API key in a one-month usage period.<br/>
        /// Setting the limit to `0` means the API key will not be able to consume speech-to-text milliseconds.<br/>
        /// Setting the limit to `null` disables the limit, effectively allowing unlimited usage.<br/>
        /// Example: 3600000
        /// </summary>
        /// <example>3600000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("speech_to_text_milliseconds")]
        public double? SpeechToTextMilliseconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminSetDeveloperKeyUsageLimitsRequest" /> class.
        /// </summary>
        /// <param name="keyId">
        /// API key ID. Consists of two valid GUIDs separated by a colon.<br/>
        /// Example: ca7d5694-96eb-4263-a9a4-7f7e4211529e:20c2abcf-4c3c-4cd6-8ae8-8bd2a7d4da38
        /// </param>
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AdminSetDeveloperKeyUsageLimitsRequest(
            string keyId,
            double? characters,
            double? speechToTextMilliseconds)
        {
            this.KeyId = keyId ?? throw new global::System.ArgumentNullException(nameof(keyId));
            this.Characters = characters;
            this.SpeechToTextMilliseconds = speechToTextMilliseconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminSetDeveloperKeyUsageLimitsRequest" /> class.
        /// </summary>
        public AdminSetDeveloperKeyUsageLimitsRequest()
        {
        }
    }
}