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
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Step that failed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("step")]
        public string? Step { get; set; }

        /// <summary>
        /// Log entries related to the status reason<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logEntries")]
        public global::System.Collections.Generic.IList<global::G.BuildLogEntry>? LogEntries { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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