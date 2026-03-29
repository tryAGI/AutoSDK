//HintName: G.Models.ModelImagePricing.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Image generation pricing by quality and size<br/>
    /// Example: {"standard":{"1024x1024":{"price":4},"1024x1792":{"price":8}},"hd":{"1024x1024":{"price":8},"1024x1792":{"price":12}}}
    /// </summary>
    public sealed partial class ModelImagePricing
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}