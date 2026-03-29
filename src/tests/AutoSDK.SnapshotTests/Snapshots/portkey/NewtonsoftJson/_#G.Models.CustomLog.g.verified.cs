//HintName: G.Models.CustomLog.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CustomLog
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("request", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CustomLogRequest Request { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CustomLogResponse Response { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public global::G.CustomLogMetadata? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomLog" /> class.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="response"></param>
        /// <param name="metadata"></param>
        public CustomLog(
            global::G.CustomLogRequest request,
            global::G.CustomLogResponse response,
            global::G.CustomLogMetadata? metadata)
        {
            this.Request = request ?? throw new global::System.ArgumentNullException(nameof(request));
            this.Response = response ?? throw new global::System.ArgumentNullException(nameof(response));
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomLog" /> class.
        /// </summary>
        public CustomLog()
        {
        }
    }
}