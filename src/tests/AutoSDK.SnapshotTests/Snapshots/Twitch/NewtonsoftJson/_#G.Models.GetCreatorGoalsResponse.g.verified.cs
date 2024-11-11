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
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.CreatorGoal> Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCreatorGoalsResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// The list of goals. The list is empty if the broadcaster hasn’t created goals.
        /// </param>
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