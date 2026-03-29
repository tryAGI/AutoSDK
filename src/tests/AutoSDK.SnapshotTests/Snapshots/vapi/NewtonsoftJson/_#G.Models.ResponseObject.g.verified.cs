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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The object type<br/>
        /// Default Value: response
        /// </summary>
        /// <default>global::G.ResponseObjectObject.Response</default>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public global::G.ResponseObjectObject Object { get; set; } = global::G.ResponseObjectObject.Response;

        /// <summary>
        /// Unix timestamp (in seconds) of when this Response was created
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public double CreatedAt { get; set; } = default!;

        /// <summary>
        /// Status of the response
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ResponseObjectStatus Status { get; set; } = default!;

        /// <summary>
        /// Error message if the response failed<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Output messages from the model
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ResponseOutputMessage> Output { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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