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
        [global::Newtonsoft.Json.JsonProperty("json")]
        public global::G.RecordStringUnknown? Json { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("textBody")]
        public string? TextBody { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public double Status { get; set; } = default!;

        /// <summary>
        /// Construct a type with a set of properties K of type T
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("headers", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, string> Headers { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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