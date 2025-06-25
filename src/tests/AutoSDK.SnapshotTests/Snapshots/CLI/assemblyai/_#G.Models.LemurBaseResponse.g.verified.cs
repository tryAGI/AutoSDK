//HintName: G.Models.LemurBaseResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LemurBaseResponse
    {
        /// <summary>
        /// The ID of the LeMUR request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid RequestId { get; set; }

        /// <summary>
        /// The usage numbers for the LeMUR request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.LemurUsage Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LemurBaseResponse" /> class.
        /// </summary>
        /// <param name="requestId">
        /// The ID of the LeMUR request
        /// </param>
        /// <param name="usage">
        /// The usage numbers for the LeMUR request
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LemurBaseResponse(
            global::System.Guid requestId,
            global::G.LemurUsage usage)
        {
            this.RequestId = requestId;
            this.Usage = usage ?? throw new global::System.ArgumentNullException(nameof(usage));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LemurBaseResponse" /> class.
        /// </summary>
        public LemurBaseResponse()
        {
        }
    }
}