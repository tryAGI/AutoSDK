//HintName: G.Models.JobDetailError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class JobDetailError
    {
        /// <summary>
        /// Example: 2021-07-14 11:53:49.242000+00:00
        /// </summary>
        /// <example>2021-07-14 11:53:49.242000+00:00</example>
        [global::Newtonsoft.Json.JsonProperty("timestamp", Required = global::Newtonsoft.Json.Required.Always)]
        public string Timestamp { get; set; } = default!;

        /// <summary>
        /// Example: Audio fetch error, http status 418
        /// </summary>
        /// <example>Audio fetch error, http status 418</example>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JobDetailError" /> class.
        /// </summary>
        /// <param name="timestamp">
        /// Example: 2021-07-14 11:53:49.242000+00:00
        /// </param>
        /// <param name="message">
        /// Example: Audio fetch error, http status 418
        /// </param>
        public JobDetailError(
            string timestamp,
            string message)
        {
            this.Timestamp = timestamp ?? throw new global::System.ArgumentNullException(nameof(timestamp));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JobDetailError" /> class.
        /// </summary>
        public JobDetailError()
        {
        }
    }
}