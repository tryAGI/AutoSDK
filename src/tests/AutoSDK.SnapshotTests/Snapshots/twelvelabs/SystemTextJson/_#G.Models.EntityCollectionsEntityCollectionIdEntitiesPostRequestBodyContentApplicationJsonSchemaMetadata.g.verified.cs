//HintName: G.Models.EntityCollectionsEntityCollectionIdEntitiesPostRequestBodyContentApplicationJsonSchemaMetadata.g.cs

#nullable enable

namespace G
{
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
    public sealed partial class EntityCollectionsEntityCollectionIdEntitiesPostRequestBodyContentApplicationJsonSchemaMetadata
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}