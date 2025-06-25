//HintName: G.Models.GetShieldModeStatusResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetShieldModeStatusResponse
    {
        /// <summary>
        /// A list that contains a single object with the broadcaster’s Shield Mode status.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.GetShieldModeStatusResponseDataItem> Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetShieldModeStatusResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// A list that contains a single object with the broadcaster’s Shield Mode status.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetShieldModeStatusResponse(
            global::System.Collections.Generic.IList<global::G.GetShieldModeStatusResponseDataItem> data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetShieldModeStatusResponse" /> class.
        /// </summary>
        public GetShieldModeStatusResponse()
        {
        }
    }
}