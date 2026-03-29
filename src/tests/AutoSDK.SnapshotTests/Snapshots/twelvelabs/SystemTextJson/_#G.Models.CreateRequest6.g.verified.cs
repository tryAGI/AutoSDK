//HintName: G.Models.CreateRequest6.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateRequest6
    {
        /// <summary>
        /// The name of the entity. Make sure you use a succinct and descriptive name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// An optional description of the entity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Optional metadata for the entity, provided as key-value pairs to store additional context or attributes. Use metadata to categorize or describe the entity for easier management and search. Keys must be of type `string`, and values can be of type `string`, `integer`, `float`, or `boolean`.<br/>
        /// **Example**:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "sport": "soccer",<br/>
        ///   "teamId": 42,<br/>
        ///   "performanceScore": 8.7,<br/>
        ///   "isActive": true<br/>
        /// }<br/>
        /// ```<br/>
        /// &lt;Note title="Note"&gt;<br/>
        ///   To store complex data types such as objects or arrays, convert them to string values before including them in the metadata.<br/>
        /// &lt;/Note&gt;
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::G.EntityCollectionsEntityCollectionIdEntitiesPostRequestBodyContentApplicationJsonSchemaMetadata? Metadata { get; set; }

        /// <summary>
        /// An array of asset IDs to associate with the entity. You must provide at least one value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("asset_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> AssetIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRequest6" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the entity. Make sure you use a succinct and descriptive name.
        /// </param>
        /// <param name="assetIds">
        /// An array of asset IDs to associate with the entity. You must provide at least one value.
        /// </param>
        /// <param name="description">
        /// An optional description of the entity.
        /// </param>
        /// <param name="metadata">
        /// Optional metadata for the entity, provided as key-value pairs to store additional context or attributes. Use metadata to categorize or describe the entity for easier management and search. Keys must be of type `string`, and values can be of type `string`, `integer`, `float`, or `boolean`.<br/>
        /// **Example**:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "sport": "soccer",<br/>
        ///   "teamId": 42,<br/>
        ///   "performanceScore": 8.7,<br/>
        ///   "isActive": true<br/>
        /// }<br/>
        /// ```<br/>
        /// &lt;Note title="Note"&gt;<br/>
        ///   To store complex data types such as objects or arrays, convert them to string values before including them in the metadata.<br/>
        /// &lt;/Note&gt;
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateRequest6(
            string name,
            global::System.Collections.Generic.IList<string> assetIds,
            string? description,
            global::G.EntityCollectionsEntityCollectionIdEntitiesPostRequestBodyContentApplicationJsonSchemaMetadata? metadata)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Metadata = metadata;
            this.AssetIds = assetIds ?? throw new global::System.ArgumentNullException(nameof(assetIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRequest6" /> class.
        /// </summary>
        public CreateRequest6()
        {
        }
    }
}