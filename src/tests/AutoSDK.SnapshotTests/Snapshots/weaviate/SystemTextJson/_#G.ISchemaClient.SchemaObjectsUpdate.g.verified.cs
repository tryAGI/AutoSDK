//HintName: G.ISchemaClient.SchemaObjectsUpdate.g.cs
#nullable enable

namespace G
{
    public partial interface ISchemaClient
    {
        /// <summary>
        /// Update an existing collection.<br/>
        /// Alter an existing collection definition. &lt;br/&gt;&lt;br/&gt;Note that not all settings are mutable ([see this list](https://weaviate.io/developers/weaviate/config-refs/schema#mutability)). To update any other (i.e. immutable) setting, you need to delete the collection, re-create it with the correct setting and then re-import the data. &lt;br/&gt;&lt;br/&gt;This endpoint cannot be used to modify properties. Instead use POST /v1/schema/{className}/properties. A typical use case for this endpoint is to update a index configuration, such as `vectorIndexConfig/dynamicEfFactor`. &lt;br/&gt;&lt;br/&gt;You should attach a body to this PUT request with the entire new configuration of the collection.
        /// </summary>
        /// <param name="className"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Class> SchemaObjectsUpdateAsync(
            string className,
            global::G.Class request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update an existing collection.<br/>
        /// Alter an existing collection definition. &lt;br/&gt;&lt;br/&gt;Note that not all settings are mutable ([see this list](https://weaviate.io/developers/weaviate/config-refs/schema#mutability)). To update any other (i.e. immutable) setting, you need to delete the collection, re-create it with the correct setting and then re-import the data. &lt;br/&gt;&lt;br/&gt;This endpoint cannot be used to modify properties. Instead use POST /v1/schema/{className}/properties. A typical use case for this endpoint is to update a index configuration, such as `vectorIndexConfig/dynamicEfFactor`. &lt;br/&gt;&lt;br/&gt;You should attach a body to this PUT request with the entire new configuration of the collection.
        /// </summary>
        /// <param name="className"></param>
        /// <param name="class1">
        /// Name of the collection (a.k.a. class). Multiple words should be concatenated in CamelCase, e.g. `ArticleAuthor`.
        /// </param>
        /// <param name="vectorConfig">
        /// Configure named vectors (https://weaviate.io/developers/weaviate/config-refs/schema/multi-vector). Either use this field or `vectorizer`, `vectorIndexType`, and `vectorIndexConfig` fields. Available from `v1.24.0`.
        /// </param>
        /// <param name="vectorIndexType">
        /// Name of the vector index to use, eg. (HNSW)<br/>
        /// Default Value: hnsw
        /// </param>
        /// <param name="vectorIndexConfig">
        /// Vector index type specific settings. See the [vector index configuration page](https://weaviate.io/developers/weaviate/config-refs/schema/vector-index) for more details
        /// </param>
        /// <param name="shardingConfig">
        /// Specify how the index should be sharded and distributed in the cluster
        /// </param>
        /// <param name="replicationConfig">
        /// Configure how replication is executed in a cluster
        /// </param>
        /// <param name="invertedIndexConfig">
        /// Configure the inverted index built into Weaviate
        /// </param>
        /// <param name="multiTenancyConfig">
        /// Configuration related to multi-tenancy within a class
        /// </param>
        /// <param name="vectorizer">
        /// Vectorizer for this collection (e.g. `text2vec-transformers`). This will override any cluster-wide default set by an environment variable. &lt;br/&gt;&lt;br/&gt;If `none`, you must import a vector with each object yourself.
        /// </param>
        /// <param name="moduleConfig">
        /// Configuration specific to modules in a collection context.
        /// </param>
        /// <param name="description">
        /// Description of the collection for documentation purposes.
        /// </param>
        /// <param name="properties">
        /// Define properties of the collection.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Class> SchemaObjectsUpdateAsync(
            string className,
            string class1,
            global::G.ClassVectorConfig? vectorConfig = default,
            global::G.VectorIndexType? vectorIndexType = global::G.VectorIndexType.Hnsw,
            global::G.VectorIndexConfig? vectorIndexConfig = default,
            global::G.ShardingConfig? shardingConfig = default,
            global::G.ReplicationConfig? replicationConfig = default,
            global::G.InvertedIndexConfig? invertedIndexConfig = default,
            global::G.MultiTenancyConfig? multiTenancyConfig = default,
            global::G.Vectorizer? vectorizer = default,
            global::G.ClassModuleConfig? moduleConfig = default,
            string? description = default,
            global::System.Collections.Generic.IList<global::G.Property>? properties = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}