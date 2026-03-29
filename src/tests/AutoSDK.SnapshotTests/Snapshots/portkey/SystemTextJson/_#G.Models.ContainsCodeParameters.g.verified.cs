//HintName: G.Models.ContainsCodeParameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ContainsCodeParameters
    {
        /// <summary>
        /// Code format to check for
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ContainsCodeParametersFormatJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ContainsCodeParametersFormat Format { get; set; }

        /// <summary>
        /// If true, the verdict will be inverted<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("not")]
        public bool? Not { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainsCodeParameters" /> class.
        /// </summary>
        /// <param name="format">
        /// Code format to check for
        /// </param>
        /// <param name="not">
        /// If true, the verdict will be inverted<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContainsCodeParameters(
            global::G.ContainsCodeParametersFormat format,
            bool? not)
        {
            this.Format = format;
            this.Not = not;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainsCodeParameters" /> class.
        /// </summary>
        public ContainsCodeParameters()
        {
        }
    }
}