//HintName: G.Models.GetCreatorGoalsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetCreatorGoalsResponse
    {
        /// <summary>
        /// The list of goals. The list is empty if the broadcaster hasn’t created goals.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.CreatorGoal> Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCreatorGoalsResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// The list of goals. The list is empty if the broadcaster hasn’t created goals.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public GetCreatorGoalsResponse(
            global::System.Collections.Generic.IList<global::G.CreatorGoal> data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCreatorGoalsResponse" /> class.
        /// </summary>
        public GetCreatorGoalsResponse()
        {
        }
    }
}