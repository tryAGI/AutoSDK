//HintName: G.Models.TypedProviderResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TypedProviderResponse
    {
        /// <summary>
        /// Construct a type with a set of properties K of type T
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("json")]
        public global::G.RecordStringUnknown? Json { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("textBody")]
        public string? TextBody { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Status { get; set; }

        /// <summary>
        /// Construct a type with a set of properties K of type T
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> Headers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TypedProviderResponse" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="headers">
        /// Construct a type with a set of properties K of type T
        /// </param>
        /// <param name="json">
        /// Construct a type with a set of properties K of type T
        /// </param>
        /// <param name="textBody"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TypedProviderResponse(
            double status,
            global::System.Collections.Generic.Dictionary<string, string> headers,
            global::G.RecordStringUnknown? json,
            string? textBody)
        {
            this.Json = json;
            this.TextBody = textBody;
            this.Status = status;
            this.Headers = headers ?? throw new global::System.ArgumentNullException(nameof(headers));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TypedProviderResponse" /> class.
        /// </summary>
        public TypedProviderResponse()
        {
        }
    }
}