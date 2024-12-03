//HintName: G.Models.GetUserBlockListResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetUserBlockListResponse
    {
        /// <summary>
        /// The list of blocked users. The list is in descending order by when the user was blocked.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.UserBlockList> Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUserBlockListResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// The list of blocked users. The list is in descending order by when the user was blocked.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public GetUserBlockListResponse(
            global::System.Collections.Generic.IList<global::G.UserBlockList> data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUserBlockListResponse" /> class.
        /// </summary>
        public GetUserBlockListResponse()
        {
        }
    }
}