//HintName: G.Models.GetGamesResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetGamesResponse
    {
        /// <summary>
        /// The list of categories and games. The list is empty if the specified categories and games weren’t found.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.Game> Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetGamesResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// The list of categories and games. The list is empty if the specified categories and games weren’t found.
        /// </param>
        public GetGamesResponse(
            global::System.Collections.Generic.IList<global::G.Game> data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetGamesResponse" /> class.
        /// </summary>
        public GetGamesResponse()
        {
        }
    }
}