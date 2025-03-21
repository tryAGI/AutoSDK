//HintName: G.Models.RealtimeResponseStatusDetailsError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A description of the error that caused the response to fail, <br/>
    /// populated when the `status` is `failed`.
    /// </summary>
    public sealed partial class RealtimeResponseStatusDetailsError
    {
        /// <summary>
        /// The type of error.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Error code, if any.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("code")]
        public string? Code { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeResponseStatusDetailsError" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of error.
        /// </param>
        /// <param name="code">
        /// Error code, if any.
        /// </param>
        public RealtimeResponseStatusDetailsError(
            string? type,
            string? code)
        {
            this.Type = type;
            this.Code = code;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeResponseStatusDetailsError" /> class.
        /// </summary>
        public RealtimeResponseStatusDetailsError()
        {
        }
    }
}