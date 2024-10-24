//HintName: G.ISchemaClient.SchemaObjectsPropertiesAdd.g.cs
#nullable enable

namespace G
{
    public partial interface ISchemaClient
    {
        /// <summary>
        /// Add a property.<br/>
        /// Add a property to an existing collection. &lt;br/&gt;&lt;br/&gt;If possible, we encourage you to create all required properties at collection creation time. Adding a property after collection creation can lead to [some indexing limitations](https://weaviate.io/developers/weaviate/config-refs/schema).
        /// </summary>
        /// <param name="className"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Property> SchemaObjectsPropertiesAddAsync(
            string className,
            global::G.Property request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Add a property.<br/>
        /// Add a property to an existing collection. &lt;br/&gt;&lt;br/&gt;If possible, we encourage you to create all required properties at collection creation time. Adding a property after collection creation can lead to [some indexing limitations](https://weaviate.io/developers/weaviate/config-refs/schema).
        /// </summary>
        /// <param name="className"></param>
        /// <param name="dataType">
        /// Data type of the property. If it starts with a capital (for example Person), may be a reference to another type.
        /// </param>
        /// <param name="description">
        /// Description of the property for documentation purposes.
        /// </param>
        /// <param name="moduleConfig">
        /// Configuration specific to modules in a property context.
        /// </param>
        /// <param name="name">
        /// The name of the property. Multiple words should be concatenated in camelCase, e.g. `nameOfAuthor`.
        /// </param>
        /// <param name="indexInverted">
        /// (Deprecated) Whether to include this property in the inverted index. If `false`, this property cannot be used in `where` filters, `bm25` or `hybrid` search. &lt;br/&gt;&lt;br/&gt;Unrelated to vectorization behavior (deprecated as of v1.19; use indexFilterable or/and indexSearchable instead)<br/>
        /// Default Value: true
        /// </param>
        /// <param name="indexFilterable">
        /// Whether to include this property in the filterable, Roaring Bitmap index. If `false`, this property cannot be used in `where` filters. &lt;br/&gt;&lt;br/&gt;Unrelated to vectorization behavior.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="indexSearchable">
        /// Whether to include this property in the searchable, inverted index. Applicable only to properties of data type text and text[]. If `false`, this property cannot be used in `bm25` or `hybrid` searches. &lt;br/&gt;&lt;br/&gt;Unrelated to vectorization behavior.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="indexRangeFilters">
        /// Whether to include this property in the filterable, range-based Roaring Bitmap inverted index. Defaults to false. Provides better performance for range queries compared to filterable index in large datasets. Applicable only to properties of data type int, number, date.
        /// </param>
        /// <param name="tokenization">
        /// Set tokenization of the property as separate words or whole field. Applies to text and text[] data types.<br/>
        /// Default Value: word
        /// </param>
        /// <param name="nestedProperties">
        /// The properties of the nested object(s). Applies to object and object[] data types.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Property> SchemaObjectsPropertiesAddAsync(
            string className,
            global::System.Collections.Generic.IList<global::G.DataTypeItem> dataType,
            string name,
            string? description = default,
            global::G.PropertyModuleConfig? moduleConfig = default,
            bool? indexInverted = default,
            bool? indexFilterable = default,
            bool? indexSearchable = default,
            bool? indexRangeFilters = default,
            global::G.Tokenization? tokenization = default,
            global::System.Collections.Generic.IList<global::G.NestedProperty>? nestedProperties = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}