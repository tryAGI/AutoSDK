//HintName: G.Models.GetUserActiveExtensionsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetUserActiveExtensionsResponse
    {
        /// <summary>
        /// The active extensions that the broadcaster has installed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::G.GetUserActiveExtensionsResponseData? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUserActiveExtensionsResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// The active extensions that the broadcaster has installed.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetUserActiveExtensionsResponse(
            global::G.GetUserActiveExtensionsResponseData? data)
        {
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUserActiveExtensionsResponse" /> class.
        /// </summary>
        public GetUserActiveExtensionsResponse()
        {
        }
    }
}