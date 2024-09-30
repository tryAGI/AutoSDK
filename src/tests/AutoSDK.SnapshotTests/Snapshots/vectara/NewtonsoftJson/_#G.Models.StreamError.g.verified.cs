//HintName: G.Models.StreamError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Event signaling there was an error with the request.
    /// </summary>
    public sealed partial class StreamError
    {
        /// <summary>
        /// If the stream errors, an event with type `error` will<br/>
        /// be sent.<br/>
        /// Default Value: error
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; } = "error";

        /// <summary>
        /// The error messages.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("messages")]
        public global::System.Collections.Generic.IList<string>? Messages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}