//HintName: G.Models.StreamError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StreamError
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("code", Required = global::Newtonsoft.Json.Required.Always)]
        public string Code { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("retry_after")]
        public int? RetryAfter { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamError" /> class.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="retryAfter"></param>
        public StreamError(
            string code,
            int? retryAfter)
        {
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.RetryAfter = retryAfter;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamError" /> class.
        /// </summary>
        public StreamError()
        {
        }

    }
}