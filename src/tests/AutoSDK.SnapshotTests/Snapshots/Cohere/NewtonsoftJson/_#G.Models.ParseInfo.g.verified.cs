//HintName: G.Models.ParseInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Included only in requests
    /// </summary>
    public sealed partial class ParseInfo
    {
        /// <summary>
        /// Included only in requests
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("separator")]
        public string? Separator { get; set; }

        /// <summary>
        /// Included only in requests
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("delimiter")]
        public string? Delimiter { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}