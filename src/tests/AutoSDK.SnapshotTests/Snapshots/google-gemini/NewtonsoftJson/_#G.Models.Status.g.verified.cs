//HintName: G.Models.Status.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The `Status` type defines a logical error model that is suitable for different programming environments, including REST APIs and RPC APIs. It is used by [gRPC](https://github.com/grpc). Each `Status` message contains three pieces of data: error code, error message, and error details. You can find out more about this error model and how to work with it in the [API Design Guide](https://cloud.google.com/apis/design/errors).
    /// </summary>
    public sealed partial class Status
    {
        /// <summary>
        /// The status code, which should be an enum value of google.rpc.Code.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("code")]
        public int? Code { get; set; }

        /// <summary>
        /// A developer-facing error message, which should be in English. Any user-facing error message should be localized and sent in the google.rpc.Status.details field, or localized by the client.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message")]
        public string? Message { get; set; }

        /// <summary>
        /// A list of messages that carry the error details. There is a common set of message types for APIs to use.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("details")]
        public global::System.Collections.Generic.IList<global::G.StatusDetail>? Details { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}