//HintName: G.Models.WebhookRegistryPackagePublishedRegistryPackagePackageVersionNugetMetadataItem.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookRegistryPackagePublishedRegistryPackagePackageVersionNugetMetadataItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<string, object, int?>))]
        public global::G.OneOf<string, object, int?>? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<bool?, string, int?, global::G.WebhookRegistryPackagePublishedRegistryPackagePackageVersionNugetMetadataItemValue>))]
        public global::G.OneOf<bool?, string, int?, global::G.WebhookRegistryPackagePublishedRegistryPackagePackageVersionNugetMetadataItemValue>? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookRegistryPackagePublishedRegistryPackagePackageVersionNugetMetadataItem" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="value"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookRegistryPackagePublishedRegistryPackagePackageVersionNugetMetadataItem(
            global::G.OneOf<string, object, int?>? id,
            string? name,
            global::G.OneOf<bool?, string, int?, global::G.WebhookRegistryPackagePublishedRegistryPackagePackageVersionNugetMetadataItemValue>? value)
        {
            this.Id = id;
            this.Name = name;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookRegistryPackagePublishedRegistryPackagePackageVersionNugetMetadataItem" /> class.
        /// </summary>
        public WebhookRegistryPackagePublishedRegistryPackagePackageVersionNugetMetadataItem()
        {
        }
    }
}