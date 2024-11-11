//HintName: G.Models.GetGuestStarSessionResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetGuestStarSessionResponse
    {
        /// <summary>
        /// Summary of the session details
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.GuestStarSession> Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetGuestStarSessionResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// Summary of the session details
        /// </param>
        public GetGuestStarSessionResponse(
            global::System.Collections.Generic.IList<global::G.GuestStarSession> data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetGuestStarSessionResponse" /> class.
        /// </summary>
        public GetGuestStarSessionResponse()
        {
        }
    }
}