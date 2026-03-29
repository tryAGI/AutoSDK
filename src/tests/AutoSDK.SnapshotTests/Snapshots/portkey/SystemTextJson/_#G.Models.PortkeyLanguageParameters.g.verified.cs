//HintName: G.Models.PortkeyLanguageParameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PortkeyLanguageParameters
    {
        /// <summary>
        /// Language that should be allowed in content
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PortkeyLanguageParametersLanguageJsonConverter))]
        public global::G.PortkeyLanguageParametersLanguage? Language { get; set; }

        /// <summary>
        /// If true, the verdict will be inverted<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("not")]
        public bool? Not { get; set; }

        /// <summary>
        /// Timeout in milliseconds<br/>
        /// Default Value: 5000
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout")]
        public double? Timeout { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PortkeyLanguageParameters" /> class.
        /// </summary>
        /// <param name="language">
        /// Language that should be allowed in content
        /// </param>
        /// <param name="not">
        /// If true, the verdict will be inverted<br/>
        /// Default Value: false
        /// </param>
        /// <param name="timeout">
        /// Timeout in milliseconds<br/>
        /// Default Value: 5000
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PortkeyLanguageParameters(
            global::G.PortkeyLanguageParametersLanguage? language,
            bool? not,
            double? timeout)
        {
            this.Language = language;
            this.Not = not;
            this.Timeout = timeout;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PortkeyLanguageParameters" /> class.
        /// </summary>
        public PortkeyLanguageParameters()
        {
        }
    }
}