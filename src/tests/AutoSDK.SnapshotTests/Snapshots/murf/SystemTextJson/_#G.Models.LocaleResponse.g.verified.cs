//HintName: G.Models.LocaleResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LocaleResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("locale")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Locale { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Language { get; set; }

        /// <summary>
        /// Dubbing Type supported by locale
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supports")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.LocaleResponseSupportsItems> Supports { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LocaleResponse" /> class.
        /// </summary>
        /// <param name="locale"></param>
        /// <param name="language"></param>
        /// <param name="supports">
        /// Dubbing Type supported by locale
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LocaleResponse(
            string locale,
            string language,
            global::System.Collections.Generic.IList<global::G.LocaleResponseSupportsItems> supports)
        {
            this.Locale = locale ?? throw new global::System.ArgumentNullException(nameof(locale));
            this.Language = language ?? throw new global::System.ArgumentNullException(nameof(language));
            this.Supports = supports ?? throw new global::System.ArgumentNullException(nameof(supports));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LocaleResponse" /> class.
        /// </summary>
        public LocaleResponse()
        {
        }
    }
}