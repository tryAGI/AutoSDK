//HintName: G.Models.TrieveKnowledgeBaseChunkPlan.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TrieveKnowledgeBaseChunkPlan
    {
        /// <summary>
        /// These are the file ids that will be used to create the vector store. To upload files, use the `POST /files` endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileIds")]
        public global::System.Collections.Generic.IList<string>? FileIds { get; set; }

        /// <summary>
        /// These are the websites that will be used to create the vector store.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("websites")]
        public global::System.Collections.Generic.IList<string>? Websites { get; set; }

        /// <summary>
        /// This is an optional field which allows you to specify the number of splits you want per chunk. If not specified, the default 20 is used. However, you may want to use a different number.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("targetSplitsPerChunk")]
        public double? TargetSplitsPerChunk { get; set; }

        /// <summary>
        /// This is an optional field which allows you to specify the delimiters to use when splitting the file before chunking the text. If not specified, the default [.!?\n] are used to split into sentences. However, you may want to use spaces or other delimiters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("splitDelimiters")]
        public global::System.Collections.Generic.IList<string>? SplitDelimiters { get; set; }

        /// <summary>
        /// This is an optional field which allows you to specify whether or not to rebalance the chunks created from the file. If not specified, the default true is used. If true, Trieve will evenly distribute remainder splits across chunks such that 66 splits with a target_splits_per_chunk of 20 will result in 3 chunks with 22 splits each.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rebalanceChunks")]
        public bool? RebalanceChunks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TrieveKnowledgeBaseChunkPlan" /> class.
        /// </summary>
        /// <param name="fileIds">
        /// These are the file ids that will be used to create the vector store. To upload files, use the `POST /files` endpoint.
        /// </param>
        /// <param name="websites">
        /// These are the websites that will be used to create the vector store.
        /// </param>
        /// <param name="targetSplitsPerChunk">
        /// This is an optional field which allows you to specify the number of splits you want per chunk. If not specified, the default 20 is used. However, you may want to use a different number.
        /// </param>
        /// <param name="splitDelimiters">
        /// This is an optional field which allows you to specify the delimiters to use when splitting the file before chunking the text. If not specified, the default [.!?\n] are used to split into sentences. However, you may want to use spaces or other delimiters.
        /// </param>
        /// <param name="rebalanceChunks">
        /// This is an optional field which allows you to specify whether or not to rebalance the chunks created from the file. If not specified, the default true is used. If true, Trieve will evenly distribute remainder splits across chunks such that 66 splits with a target_splits_per_chunk of 20 will result in 3 chunks with 22 splits each.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TrieveKnowledgeBaseChunkPlan(
            global::System.Collections.Generic.IList<string>? fileIds,
            global::System.Collections.Generic.IList<string>? websites,
            double? targetSplitsPerChunk,
            global::System.Collections.Generic.IList<string>? splitDelimiters,
            bool? rebalanceChunks)
        {
            this.FileIds = fileIds;
            this.Websites = websites;
            this.TargetSplitsPerChunk = targetSplitsPerChunk;
            this.SplitDelimiters = splitDelimiters;
            this.RebalanceChunks = rebalanceChunks;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrieveKnowledgeBaseChunkPlan" /> class.
        /// </summary>
        public TrieveKnowledgeBaseChunkPlan()
        {
        }
    }
}