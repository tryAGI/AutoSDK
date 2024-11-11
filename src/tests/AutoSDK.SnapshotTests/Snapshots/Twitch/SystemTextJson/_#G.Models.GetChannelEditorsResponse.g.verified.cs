//HintName: G.Models.GetChannelEditorsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetChannelEditorsResponse
    {
        /// <summary>
        /// A list of users that are editors for the specified broadcaster. The list is empty if the broadcaster doesn’t have editors.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ChannelEditor> Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetChannelEditorsResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// A list of users that are editors for the specified broadcaster. The list is empty if the broadcaster doesn’t have editors.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public GetChannelEditorsResponse(
            global::System.Collections.Generic.IList<global::G.ChannelEditor> data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetChannelEditorsResponse" /> class.
        /// </summary>
        public GetChannelEditorsResponse()
        {
        }
    }
}