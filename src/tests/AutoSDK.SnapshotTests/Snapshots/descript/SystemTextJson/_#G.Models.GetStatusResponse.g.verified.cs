//HintName: G.Models.GetStatusResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetStatusResponse
    {
        /// <summary>
        /// API status indicator<br/>
        /// Example: ok
        /// </summary>
        /// <example>ok</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.GetStatusResponseStatusJsonConverter))]
        public global::G.GetStatusResponseStatus Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetStatusResponse" /> class.
        /// </summary>
        /// <param name="status">
        /// API status indicator<br/>
        /// Example: ok
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetStatusResponse(
            global::G.GetStatusResponseStatus status)
        {
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetStatusResponse" /> class.
        /// </summary>
        public GetStatusResponse()
        {
        }
    }
}