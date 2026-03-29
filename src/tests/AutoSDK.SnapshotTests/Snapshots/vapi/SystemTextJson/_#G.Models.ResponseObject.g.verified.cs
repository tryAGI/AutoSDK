//HintName: G.Models.ResponseObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseObject
    {
        /// <summary>
        /// Unique identifier for this Response
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The object type<br/>
        /// Default Value: response
        /// </summary>
        /// <default>global::G.ResponseObjectObject.Response</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ResponseObjectObjectJsonConverter))]
        public global::G.ResponseObjectObject Object { get; set; } = global::G.ResponseObjectObject.Response;

        /// <summary>
        /// Unix timestamp (in seconds) of when this Response was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CreatedAt { get; set; }

        /// <summary>
        /// Status of the response
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ResponseObjectStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ResponseObjectStatus Status { get; set; }

        /// <summary>
        /// Error message if the response failed<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Output messages from the model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ResponseOutputMessage> Output { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseObject" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for this Response
        /// </param>
        /// <param name="createdAt">
        /// Unix timestamp (in seconds) of when this Response was created
        /// </param>
        /// <param name="status">
        /// Status of the response
        /// </param>
        /// <param name="output">
        /// Output messages from the model
        /// </param>
        /// <param name="error">
        /// Error message if the response failed<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="object">
        /// The object type<br/>
        /// Default Value: response
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseObject(
            string id,
            double createdAt,
            global::G.ResponseObjectStatus status,
            global::System.Collections.Generic.IList<global::G.ResponseOutputMessage> output,
            string? error,
            global::G.ResponseObjectObject @object = global::G.ResponseObjectObject.Response)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
            this.CreatedAt = createdAt;
            this.Status = status;
            this.Error = error;
            this.Output = output ?? throw new global::System.ArgumentNullException(nameof(output));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseObject" /> class.
        /// </summary>
        public ResponseObject()
        {
        }
    }
}