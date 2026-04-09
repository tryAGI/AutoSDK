//HintName: G.Models.CallbackConfigDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CallbackConfigDto
    {
        /// <summary>
        /// The URL to be called with the result of the transcription<br/>
        /// Example: http://callback.example
        /// </summary>
        /// <example>http://callback.example</example>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// The HTTP method to be used. Allowed values are `POST` or `PUT` (default: `POST`)<br/>
        /// Default Value: POST<br/>
        /// Example: POST
        /// </summary>
        /// <example>POST</example>
        [global::Newtonsoft.Json.JsonProperty("method")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CallbackMethodEnumJsonConverter))]
        public global::G.CallbackMethodEnum? Method { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallbackConfigDto" /> class.
        /// </summary>
        /// <param name="url">
        /// The URL to be called with the result of the transcription<br/>
        /// Example: http://callback.example
        /// </param>
        /// <param name="method">
        /// The HTTP method to be used. Allowed values are `POST` or `PUT` (default: `POST`)<br/>
        /// Default Value: POST<br/>
        /// Example: POST
        /// </param>
        public CallbackConfigDto(
            string url,
            global::G.CallbackMethodEnum? method)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Method = method;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallbackConfigDto" /> class.
        /// </summary>
        public CallbackConfigDto()
        {
        }
    }
}