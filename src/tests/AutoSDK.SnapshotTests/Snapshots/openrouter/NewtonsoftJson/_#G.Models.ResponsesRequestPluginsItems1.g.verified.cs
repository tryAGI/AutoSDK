//HintName: G.Models.ResponsesRequestPluginsItems1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponsesRequestPluginsItems1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public global::G.ResponsesRequestPluginsItemsOneOf1Id Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesRequestPluginsItems1" /> class.
        /// </summary>
        /// <param name="id"></param>
        public ResponsesRequestPluginsItems1(
            global::G.ResponsesRequestPluginsItemsOneOf1Id id)
        {
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesRequestPluginsItems1" /> class.
        /// </summary>
        public ResponsesRequestPluginsItems1()
        {
        }
    }
}