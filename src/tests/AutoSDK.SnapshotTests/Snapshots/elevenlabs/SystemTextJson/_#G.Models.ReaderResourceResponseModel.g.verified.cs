//HintName: G.Models.ReaderResourceResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"resource_id":"FCwhRBWXzGAHq8TQ4Fs18","resource_type":"read"}
    /// </summary>
    public sealed partial class ReaderResourceResponseModel
    {
        /// <summary>
        /// The type of resource.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ReaderResourceResponseModelResourceTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ReaderResourceResponseModelResourceType ResourceType { get; set; }

        /// <summary>
        /// The ID of the resource.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ResourceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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