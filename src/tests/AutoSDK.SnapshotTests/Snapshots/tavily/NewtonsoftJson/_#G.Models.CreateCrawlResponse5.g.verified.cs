//HintName: G.Models.CreateCrawlResponse5.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateCrawlResponse5
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("detail")]
        public global::G.CreateCrawlResponseDetail4? Detail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCrawlResponse5" /> class.
        /// </summary>
        /// <param name="detail"></param>
        public CreateCrawlResponse5(
            global::G.CreateCrawlResponseDetail4? detail)
        {
            this.Detail = detail;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCrawlResponse5" /> class.
        /// </summary>
        public CreateCrawlResponse5()
        {
        }
    }
}