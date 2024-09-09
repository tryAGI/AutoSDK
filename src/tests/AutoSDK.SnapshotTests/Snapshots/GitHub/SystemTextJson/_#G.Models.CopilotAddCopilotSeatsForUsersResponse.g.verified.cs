//HintName: G.Models.CopilotAddCopilotSeatsForUsersResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The total number of seat assignments created.
    /// </summary>
    public sealed partial class CopilotAddCopilotSeatsForUsersResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seats_created")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SeatsCreated { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}