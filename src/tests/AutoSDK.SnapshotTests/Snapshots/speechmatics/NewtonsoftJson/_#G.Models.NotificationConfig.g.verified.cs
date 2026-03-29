//HintName: G.Models.NotificationConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: [{"url":"https://collector.example.org/callback","contents":["transcript:json-v2"],"auth_headers":["Authorization: Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJ1c2VySWQiOiJiMDhmODZhZi0zNWRhLTQ4ZjItOGZhYi1jZWYzOTA0NjYwYmQifQ.-xN_h82PHVTCMA9vdoHrcZxH-x5mb11y1537t3rGzcM"]}]
    /// </summary>
    public sealed partial class NotificationConfig
    {
        /// <summary>
        /// The url to which a notification message will be sent upon<br/>
        /// completion of the job. The job `id` and `status` are added<br/>
        /// as query parameters, and any combination of the job inputs<br/>
        /// and outputs can be included by listing them in `contents`.<br/>
        /// If `contents` is empty, the body of the request will be<br/>
        /// empty.<br/>
        /// If only one item is listed, it will be sent as the body of<br/>
        /// the request with `Content-Type` set to an appropriate value<br/>
        /// such as `application/octet-stream` or `application/json`.<br/>
        /// If multiple items are listed they will be sent as named file<br/>
        /// attachments using the multipart content type.<br/>
        /// If `contents` is not specified, the `transcript` item will<br/>
        /// be sent as a file attachment named `data_file`, for<br/>
        /// backwards compatibility.<br/>
        /// If the job was rejected or failed during processing, that<br/>
        /// will be indicated by the status, and any output items that<br/>
        /// are not available as a result will be omitted. The body<br/>
        /// formatting rules will still be followed as if all items were<br/>
        /// available.<br/>
        /// The user-agent header is set to `Speechmatics-API/2.0`, or<br/>
        /// `Speechmatics API V2` in older API versions.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Specifies a list of items to be attached to the notification message. When multiple items are requested, they are included as named file attachments.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("contents")]
        public global::System.Collections.Generic.IList<global::G.NotificationConfigContent>? Contents { get; set; }

        /// <summary>
        /// The method to be used with http and https urls. The default is post.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("method")]
        public global::G.NotificationConfigMethod? Method { get; set; }

        /// <summary>
        /// A list of additional headers to be added to the notification request when using http or https. This is intended to support authentication or authorization, for example by supplying an OAuth2 bearer token.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("auth_headers")]
        public global::System.Collections.Generic.IList<string>? AuthHeaders { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationConfig" /> class.
        /// </summary>
        /// <param name="url">
        /// The url to which a notification message will be sent upon<br/>
        /// completion of the job. The job `id` and `status` are added<br/>
        /// as query parameters, and any combination of the job inputs<br/>
        /// and outputs can be included by listing them in `contents`.<br/>
        /// If `contents` is empty, the body of the request will be<br/>
        /// empty.<br/>
        /// If only one item is listed, it will be sent as the body of<br/>
        /// the request with `Content-Type` set to an appropriate value<br/>
        /// such as `application/octet-stream` or `application/json`.<br/>
        /// If multiple items are listed they will be sent as named file<br/>
        /// attachments using the multipart content type.<br/>
        /// If `contents` is not specified, the `transcript` item will<br/>
        /// be sent as a file attachment named `data_file`, for<br/>
        /// backwards compatibility.<br/>
        /// If the job was rejected or failed during processing, that<br/>
        /// will be indicated by the status, and any output items that<br/>
        /// are not available as a result will be omitted. The body<br/>
        /// formatting rules will still be followed as if all items were<br/>
        /// available.<br/>
        /// The user-agent header is set to `Speechmatics-API/2.0`, or<br/>
        /// `Speechmatics API V2` in older API versions.
        /// </param>
        /// <param name="contents">
        /// Specifies a list of items to be attached to the notification message. When multiple items are requested, they are included as named file attachments.
        /// </param>
        /// <param name="method">
        /// The method to be used with http and https urls. The default is post.
        /// </param>
        /// <param name="authHeaders">
        /// A list of additional headers to be added to the notification request when using http or https. This is intended to support authentication or authorization, for example by supplying an OAuth2 bearer token.
        /// </param>
        public NotificationConfig(
            string url,
            global::System.Collections.Generic.IList<global::G.NotificationConfigContent>? contents,
            global::G.NotificationConfigMethod? method,
            global::System.Collections.Generic.IList<string>? authHeaders)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Contents = contents;
            this.Method = method;
            this.AuthHeaders = authHeaders;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationConfig" /> class.
        /// </summary>
        public NotificationConfig()
        {
        }
    }
}