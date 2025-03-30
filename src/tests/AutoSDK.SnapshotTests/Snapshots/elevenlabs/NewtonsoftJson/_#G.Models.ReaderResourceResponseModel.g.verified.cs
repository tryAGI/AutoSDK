//HintName: G.Models.ReaderResourceResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReaderResourceResponseModel
    {
        /// <summary>
        /// The type of resource.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("resource_type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ReaderResourceResponseModelResourceType ResourceType { get; set; } = default!;

        /// <summary>
        /// The ID of the resource.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("resource_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ResourceId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReaderResourceResponseModel" /> class.
        /// </summary>
        /// <param name="resourceType">
        /// The type of resource.
        /// </param>
        /// <param name="resourceId">
        /// The ID of the resource.
        /// </param>
        public ReaderResourceResponseModel(
            global::G.ReaderResourceResponseModelResourceType resourceType,
            string resourceId)
        {
            this.ResourceType = resourceType;
            this.ResourceId = resourceId ?? throw new global::System.ArgumentNullException(nameof(resourceId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReaderResourceResponseModel" /> class.
        /// </summary>
        public ReaderResourceResponseModel()
        {
        }
    }
}