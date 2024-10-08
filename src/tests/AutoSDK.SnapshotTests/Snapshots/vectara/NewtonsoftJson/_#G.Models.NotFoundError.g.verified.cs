//HintName: G.Models.NotFoundError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NotFoundError
    {
        /// <summary>
        /// The ID cannot be found.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("messages")]
        public global::System.Collections.Generic.IList<string>? Messages { get; set; }

        /// <summary>
        /// ID of the request that can be used to help Vectara support debug what went wrong.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("request_id")]
        public string? RequestId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}