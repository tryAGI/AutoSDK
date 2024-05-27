//HintName: G.Models.StartRaidResponseData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StartRaidResponseData
    {
        /// <summary>
        /// The UTC date and time, in RFC3339 format, of when the raid was requested.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// A Boolean value that indicates whether the channel being raided contains mature content.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_mature", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsMature { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}