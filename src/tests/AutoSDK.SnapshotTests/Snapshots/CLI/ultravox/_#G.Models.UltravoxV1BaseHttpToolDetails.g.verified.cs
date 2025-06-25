//HintName: G.Models.UltravoxV1BaseHttpToolDetails.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Details for invoking a tool via HTTP.
    /// </summary>
    public sealed partial class UltravoxV1BaseHttpToolDetails
    {
        /// <summary>
        /// The base URL pattern for the tool, possibly with placeholders for path parameters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("baseUrlPattern")]
        public string? BaseUrlPattern { get; set; }

        /// <summary>
        /// The HTTP method for the tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("httpMethod")]
        public string? HttpMethod { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1BaseHttpToolDetails" /> class.
        /// </summary>
        /// <param name="baseUrlPattern">
        /// The base URL pattern for the tool, possibly with placeholders for path parameters.
        /// </param>
        /// <param name="httpMethod">
        /// The HTTP method for the tool.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UltravoxV1BaseHttpToolDetails(
            string? baseUrlPattern,
            string? httpMethod)
        {
            this.BaseUrlPattern = baseUrlPattern;
            this.HttpMethod = httpMethod;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1BaseHttpToolDetails" /> class.
        /// </summary>
        public UltravoxV1BaseHttpToolDetails()
        {
        }
    }
}