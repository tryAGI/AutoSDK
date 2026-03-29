//HintName: G.Models.HealthCheck.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HealthCheck
    {
        /// <summary>
        /// A valid http status code
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public int Status { get; set; } = default!;

        /// <summary>
        /// A message explaining the status
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HealthCheck" /> class.
        /// </summary>
        /// <param name="status">
        /// A valid http status code
        /// </param>
        /// <param name="message">
        /// A message explaining the status
        /// </param>
        public HealthCheck(
            int status,
            string message)
        {
            this.Status = status;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HealthCheck" /> class.
        /// </summary>
        public HealthCheck()
        {
        }
    }
}