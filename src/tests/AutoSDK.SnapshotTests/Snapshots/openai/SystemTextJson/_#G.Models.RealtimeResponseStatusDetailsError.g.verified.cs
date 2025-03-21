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
        /// Error code, if any.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// The type of error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeResponseStatusDetailsError" /> class.
        /// </summary>
        /// <param name="code">
        /// Error code, if any.
        /// </param>
        /// <param name="type">
        /// The type of error.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeResponseStatusDetailsError(
            string? code,
            string? type)
        {
            this.Code = code;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeResponseStatusDetailsError" /> class.
        /// </summary>
        public RealtimeResponseStatusDetailsError()
        {
        }
    }
}