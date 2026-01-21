//HintName: G.Models.BatchError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BatchError
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// Default Value: 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("count")]
        public int? Count { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchError" /> class.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="count">
        /// Default Value: 1
        /// </param>
        public BatchError(
            string message,
            int? count)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Count = count;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchError" /> class.
        /// </summary>
        public BatchError()
        {
        }
    }
}