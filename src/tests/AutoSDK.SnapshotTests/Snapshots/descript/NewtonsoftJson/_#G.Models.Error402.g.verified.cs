//HintName: G.Models.Error402.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Error402
    {
        /// <summary>
        /// Example: payment_required
        /// </summary>
        /// <example>payment_required</example>
        [global::Newtonsoft.Json.JsonProperty("error", Required = global::Newtonsoft.Json.Required.Always)]
        public string Error { get; set; } = default!;

        /// <summary>
        /// Example: Insufficient media minutes to start the job
        /// </summary>
        /// <example>Insufficient media minutes to start the job</example>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Error402" /> class.
        /// </summary>
        /// <param name="error">
        /// Example: payment_required
        /// </param>
        /// <param name="message">
        /// Example: Insufficient media minutes to start the job
        /// </param>
        public Error402(
            string error,
            string message)
        {
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Error402" /> class.
        /// </summary>
        public Error402()
        {
        }
    }
}