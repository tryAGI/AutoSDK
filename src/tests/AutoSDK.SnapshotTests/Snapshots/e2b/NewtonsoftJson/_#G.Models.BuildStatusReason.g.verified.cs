//HintName: G.Models.BuildStatusReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BuildStatusReason
    {
        /// <summary>
        /// Message with the status reason, currently reporting only for error status
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// Step that failed
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("step")]
        public string? Step { get; set; }

        /// <summary>
        /// Log entries related to the status reason<br/>
        /// Default Value: []
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("logEntries")]
        public global::System.Collections.Generic.IList<global::G.BuildLogEntry>? LogEntries { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildStatusReason" /> class.
        /// </summary>
        /// <param name="message">
        /// Message with the status reason, currently reporting only for error status
        /// </param>
        /// <param name="step">
        /// Step that failed
        /// </param>
        /// <param name="logEntries">
        /// Log entries related to the status reason<br/>
        /// Default Value: []
        /// </param>
        public BuildStatusReason(
            string message,
            string? step,
            global::System.Collections.Generic.IList<global::G.BuildLogEntry>? logEntries)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Step = step;
            this.LogEntries = logEntries;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildStatusReason" /> class.
        /// </summary>
        public BuildStatusReason()
        {
        }
    }
}