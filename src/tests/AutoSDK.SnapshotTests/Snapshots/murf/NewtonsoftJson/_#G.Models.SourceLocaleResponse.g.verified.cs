//HintName: G.Models.SourceLocaleResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SourceLocaleResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("locale", Required = global::Newtonsoft.Json.Required.Always)]
        public string Locale { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language", Required = global::Newtonsoft.Json.Required.Always)]
        public string Language { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SourceLocaleResponse" /> class.
        /// </summary>
        /// <param name="locale"></param>
        /// <param name="language"></param>
        public SourceLocaleResponse(
            string locale,
            string language)
        {
            this.Locale = locale ?? throw new global::System.ArgumentNullException(nameof(locale));
            this.Language = language ?? throw new global::System.ArgumentNullException(nameof(language));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SourceLocaleResponse" /> class.
        /// </summary>
        public SourceLocaleResponse()
        {
        }
    }
}