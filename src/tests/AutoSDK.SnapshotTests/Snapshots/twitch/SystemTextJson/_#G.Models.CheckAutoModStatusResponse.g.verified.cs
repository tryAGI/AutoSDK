//HintName: G.Models.CheckAutoModStatusResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CheckAutoModStatusResponse
    {
        /// <summary>
        /// The list of messages and whether Twitch would approve them for chat.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.AutoModStatus> Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckAutoModStatusResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// The list of messages and whether Twitch would approve them for chat.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CheckAutoModStatusResponse(
            global::System.Collections.Generic.IList<global::G.AutoModStatus> data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckAutoModStatusResponse" /> class.
        /// </summary>
        public CheckAutoModStatusResponse()
        {
        }
    }
}