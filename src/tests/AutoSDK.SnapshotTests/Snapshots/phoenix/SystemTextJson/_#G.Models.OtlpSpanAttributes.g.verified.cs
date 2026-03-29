//HintName: G.Models.OtlpSpanAttributes.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// attributes is a collection of key/value pairs. Note, global attributes like server name can be set using the resource API. Examples of attributes:<br/>
    ///     "/http/user_agent": "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_14_2) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/71.0.3578.98 Safari/537.36"<br/>
    ///     "/http/server_latency": 300<br/>
    ///     "example.com/myattribute": true<br/>
    ///     "example.com/score": 10.239<br/>
    /// The OpenTelemetry API specification further restricts the allowed value types:<br/>
    /// https://github.com/open-telemetry/opentelemetry-specification/blob/main/specification/common/README.md#attribute<br/>
    /// Attribute keys MUST be unique (it is not allowed to have more than one attribute with the same key).
    /// </summary>
    public sealed partial class OtlpSpanAttributes
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}