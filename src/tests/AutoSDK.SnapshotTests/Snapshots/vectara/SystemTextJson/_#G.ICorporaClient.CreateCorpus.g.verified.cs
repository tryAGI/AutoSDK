//HintName: G.ICorporaClient.CreateCorpus.g.cs
#nullable enable

namespace G
{
    public partial interface ICorporaClient
    {
        /// <summary>
        /// Create a corpus<br/>
        /// The Create Corpus API lets you create a corpus to store and manage your documents. A corpus is a container for documents and their associated metadata. When creating a corpus, you can specify various settings such as the corpus key, name, description, encoder, and filter attributes.<br/>
        /// ## Corpus object<br/>
        /// When you create a `corpus` object, the `corpus_key` property is required to uniquely identify the corpus. The `name` parameter is optional and defaults to the value of `key`. The optional `description` properties lets you provide additional information about the corpus. When creating a new corpus, you also have the flexibility to specify a custom `corpus_key` that follows a naming convention of your choice. This allows you to assign easily identifiable keys to your corpora, making it easier to manage and reference them in your application.<br/>
        /// You can specify whether to treat queries or documents in the corpus as questions or answers using the `queries_are_answers` and `documents_are_questions` boolean properties. These settings affect the semantics of the encoder used at query time and indexing time.<br/>
        /// ## Add metadata as filter attributes<br/>
        /// When creating a corpus with this endpoint or the Vectara Console, you define metadata fields using the `filter_attributes` object. This ensures the corpus supports filtering on specific metadata attributes, either at the document level or the part level.<br/>
        /// Filter attributes enable you to attach metadata to your data at the document (`doc`) or `part` level, which you can use later in filter expressions to narrow the scope of your queries. A filter attribute must specify a unique `name` (up to 64 characters long), and a `level` which indicates whether it exists in the `doc` or `part` level metadata. At indexing time, metadata with this name is extracted and made available for filter expressions to operate on. [Learn more](https://docs.vectara.com/docs/build/prepare-data/metadata-filters)<br/>
        /// ### Doc and part filter levels<br/>
        /// The `doc` attribute applies to the entire document. Use this for metadata that is consistent across the whole document, such as author, publication date, and document ID.<br/>
        /// The `part` attribute applies to specific sections or chunks within a document. Use for metadata that may vary within different parts of the document, such as sections, page numbers, and sentiment scores.<br/>
        /// If `indexed` is true, the system will build an index on the extracted values to further improve the performance of filter expressions involving the attribute.<br/>
        /// Filter attributes must specify a `type`, which is validated when documents are indexed. The four supported types are `integer`, which stores signed whole-number values up to eight bytes in length; `real`, for storing floating point values in [IEEE 754 8-byte format]; `text` for storing textual strings in [UTF-8 encoding], and `boolean` for storing true/false values.<br/>
        /// After you define filter attributes, you can use them within your queries. For example:<br/>
        /// * Document-level attribute: `doc.publication_year &gt; 2020`<br/>
        /// * Part-level attribute: `part.sentiment_score &gt; 0.7`<br/>
        /// ## Custom dimensions <br/>
        /// Custom dimensions let you add additional context to your data that contain user-defined values in addition to what Vectara automatically extracts and stores from the text. For example, *upvotes* can be a custom dimension. For example, see [Add custom dimensions to boost content](/docs/tutorials/add-custom-dimensions)."
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Corpus> CreateCorpusAsync(

            global::G.CreateCorpusRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a corpus<br/>
        /// The Create Corpus API lets you create a corpus to store and manage your documents. A corpus is a container for documents and their associated metadata. When creating a corpus, you can specify various settings such as the corpus key, name, description, encoder, and filter attributes.<br/>
        /// ## Corpus object<br/>
        /// When you create a `corpus` object, the `corpus_key` property is required to uniquely identify the corpus. The `name` parameter is optional and defaults to the value of `key`. The optional `description` properties lets you provide additional information about the corpus. When creating a new corpus, you also have the flexibility to specify a custom `corpus_key` that follows a naming convention of your choice. This allows you to assign easily identifiable keys to your corpora, making it easier to manage and reference them in your application.<br/>
        /// You can specify whether to treat queries or documents in the corpus as questions or answers using the `queries_are_answers` and `documents_are_questions` boolean properties. These settings affect the semantics of the encoder used at query time and indexing time.<br/>
        /// ## Add metadata as filter attributes<br/>
        /// When creating a corpus with this endpoint or the Vectara Console, you define metadata fields using the `filter_attributes` object. This ensures the corpus supports filtering on specific metadata attributes, either at the document level or the part level.<br/>
        /// Filter attributes enable you to attach metadata to your data at the document (`doc`) or `part` level, which you can use later in filter expressions to narrow the scope of your queries. A filter attribute must specify a unique `name` (up to 64 characters long), and a `level` which indicates whether it exists in the `doc` or `part` level metadata. At indexing time, metadata with this name is extracted and made available for filter expressions to operate on. [Learn more](https://docs.vectara.com/docs/build/prepare-data/metadata-filters)<br/>
        /// ### Doc and part filter levels<br/>
        /// The `doc` attribute applies to the entire document. Use this for metadata that is consistent across the whole document, such as author, publication date, and document ID.<br/>
        /// The `part` attribute applies to specific sections or chunks within a document. Use for metadata that may vary within different parts of the document, such as sections, page numbers, and sentiment scores.<br/>
        /// If `indexed` is true, the system will build an index on the extracted values to further improve the performance of filter expressions involving the attribute.<br/>
        /// Filter attributes must specify a `type`, which is validated when documents are indexed. The four supported types are `integer`, which stores signed whole-number values up to eight bytes in length; `real`, for storing floating point values in [IEEE 754 8-byte format]; `text` for storing textual strings in [UTF-8 encoding], and `boolean` for storing true/false values.<br/>
        /// After you define filter attributes, you can use them within your queries. For example:<br/>
        /// * Document-level attribute: `doc.publication_year &gt; 2020`<br/>
        /// * Part-level attribute: `part.sentiment_score &gt; 0.7`<br/>
        /// ## Custom dimensions <br/>
        /// Custom dimensions let you add additional context to your data that contain user-defined values in addition to what Vectara automatically extracts and stores from the text. For example, *upvotes* can be a custom dimension. For example, see [Add custom dimensions to boost content](/docs/tutorials/add-custom-dimensions)."
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="key">
        /// A user-provided key for a corpus.<br/>
        /// Example: my-corpus
        /// </param>
        /// <param name="name">
        /// The name for the corpus. This value defaults to the key.<br/>
        /// Example: My corpus
        /// </param>
        /// <param name="description">
        /// Description of the corpus.<br/>
        /// Example: Documents with important information for my prompt.
        /// </param>
        /// <param name="saveHistory">
        /// Indicates whether to save corpus queries to query history by default.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="queriesAreAnswers">
        /// Queries made to this corpus are considered answers, and not questions.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="documentsAreQuestions">
        /// Documents inside this corpus are considered questions, and not answers.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="encoderName">
        /// The encoder used by the corpus, `boomerang-2023-q3`.<br/>
        /// Example: boomerang-2023-q3
        /// </param>
        /// <param name="filterAttributes">
        /// The new filter attributes of the corpus. If unset then the corpus will not have filter attributes.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="customDimensions">
        /// A custom dimension is an additional numerical field attached to a document part. You can then multiply this numerical field with a query time custom dimension of the same name. This allows boosting (or burying) document parts for arbitrary reasons. This feature is only enabled for Pro and Enterprise customers.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Corpus> CreateCorpusAsync(
            string key,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            string? name = default,
            string? description = default,
            bool? saveHistory = default,
            bool? queriesAreAnswers = default,
            bool? documentsAreQuestions = default,
            string? encoderName = default,
            global::System.Collections.Generic.IList<global::G.FilterAttribute>? filterAttributes = default,
            global::System.Collections.Generic.IList<global::G.CorpusCustomDimension>? customDimensions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}