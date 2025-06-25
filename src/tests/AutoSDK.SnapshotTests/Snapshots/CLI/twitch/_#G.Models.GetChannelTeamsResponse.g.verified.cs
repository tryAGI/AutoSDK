//HintName: G.Models.GetChannelTeamsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetChannelTeamsResponse
    {
        /// <summary>
        /// The list of teams that the broadcaster is a member of. Returns an empty array if the broadcaster is not a member of a team.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ChannelTeam> Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetChannelTeamsResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// The list of teams that the broadcaster is a member of. Returns an empty array if the broadcaster is not a member of a team.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetChannelTeamsResponse(
            global::System.Collections.Generic.IList<global::G.ChannelTeam> data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetChannelTeamsResponse" /> class.
        /// </summary>
        public GetChannelTeamsResponse()
        {
        }
    }
}