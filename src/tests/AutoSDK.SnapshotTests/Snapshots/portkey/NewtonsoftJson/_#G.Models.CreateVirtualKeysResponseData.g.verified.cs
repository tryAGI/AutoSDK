//HintName: G.Models.CreateVirtualKeysResponseData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateVirtualKeysResponseData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("slug")]
        public string? Slug { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVirtualKeysResponseData" /> class.
        /// </summary>
        /// <param name="slug"></param>
        public CreateVirtualKeysResponseData(
            string? slug)
        {
            this.Slug = slug;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVirtualKeysResponseData" /> class.
        /// </summary>
        public CreateVirtualKeysResponseData()
        {
        }
    }
}