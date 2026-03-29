//HintName: G.Models.RequestCountBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RequestCountBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filter", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.FilterNode Filter { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("isCached")]
        public bool? IsCached { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestCountBody" /> class.
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="isCached"></param>
        public RequestCountBody(
            global::G.FilterNode filter,
            bool? isCached)
        {
            this.Filter = filter;
            this.IsCached = isCached;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestCountBody" /> class.
        /// </summary>
        public RequestCountBody()
        {
        }
    }
}