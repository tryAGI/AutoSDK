//HintName: G.Models.CopilotAddCopilotSeatsForTeamsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The total number of seat assignments created.
    /// </summary>
    public sealed partial class CopilotAddCopilotSeatsForTeamsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("seats_created", Required = global::Newtonsoft.Json.Required.Always)]
        public int SeatsCreated { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}