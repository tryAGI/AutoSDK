//HintName: G.Models.ResearchOperationDtoClassVariant3Result.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResearchOperationDtoClassVariant3Result
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchOperationDtoClassVariant3Result" /> class.
        /// </summary>
        /// <param name="url"></param>
        public ResearchOperationDtoClassVariant3Result(
            string url)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchOperationDtoClassVariant3Result" /> class.
        /// </summary>
        public ResearchOperationDtoClassVariant3Result()
        {
        }
    }
}