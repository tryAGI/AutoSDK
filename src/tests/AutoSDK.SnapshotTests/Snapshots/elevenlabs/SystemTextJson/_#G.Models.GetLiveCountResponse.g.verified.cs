//HintName: G.Models.GetLiveCountResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetLiveCountResponse
    {
        /// <summary>
        /// The number of active ongoing conversations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Count { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetLiveCountResponse" /> class.
        /// </summary>
        /// <param name="count">
        /// The number of active ongoing conversations.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetLiveCountResponse(
            int count)
        {
            this.Count = count;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetLiveCountResponse" /> class.
        /// </summary>
        public GetLiveCountResponse()
        {
        }
    }
}