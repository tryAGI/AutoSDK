//HintName: G.Models.OptimizersConfig.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OptimizersConfig
    {
        /// <summary>
        /// The minimal fraction of deleted vectors in a segment, required to perform segment optimization<br/>
        /// Default Value: 0.2F
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deleted_threshold")]
        public double? DeletedThreshold { get; set; }

        /// <summary>
        /// The minimal number of vectors in a segment, required to perform segment optimization<br/>
        /// Default Value: 1000
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vacuum_min_vector_number")]
        public int? VacuumMinVectorNumber { get; set; }

        /// <summary>
        /// Target amount of segments optimizer will try to keep. Real amount of segments may vary depending on multiple parameters: - Amount of stored points - Current write RPS<br/>
        /// It is recommended to select default number of segments as a factor of the number of search threads, so that each segment would be handled evenly by one of the threads. If `default_segment_number = 0`, will be automatically selected by the number of available CPUs.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("default_segment_number", Required = global::Newtonsoft.Json.Required.Always)]
        public int DefaultSegmentNumber { get; set; } = default!;

        /// <summary>
        /// Do not create segments larger this size (in kilobytes). Large segments might require disproportionately long indexation times, therefore it makes sense to limit the size of segments.<br/>
        /// If indexing speed is more important - make this parameter lower. If search speed is more important - make this parameter higher. Note: 1Kb = 1 vector of size 256 If not set, will be automatically selected considering the number of available CPUs.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_segment_size")]
        public int? MaxSegmentSize { get; set; }

        /// <summary>
        /// Maximum size (in kilobytes) of vectors to store in-memory per segment. Segments larger than this threshold will be stored as read-only memmapped file.<br/>
        /// Memmap storage is disabled by default, to enable it, set this threshold to a reasonable value.<br/>
        /// To disable memmap storage, set this to `0`. Internally it will use the largest threshold possible.<br/>
        /// Note: 1Kb = 1 vector of size 256<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("memmap_threshold")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public int? MemmapThreshold { get; set; }

        /// <summary>
        /// Maximum size (in kilobytes) of vectors allowed for plain index, exceeding this threshold will enable vector indexing<br/>
        /// Default value is 10,000, based on experiments and observations.<br/>
        /// To disable vector indexing, set to `0`.<br/>
        /// Note: 1kB = 1 vector of size 256.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("indexing_threshold")]
        public int? IndexingThreshold { get; set; }

        /// <summary>
        /// Minimum interval between forced flushes.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("flush_interval_sec", Required = global::Newtonsoft.Json.Required.Always)]
        public int FlushIntervalSec { get; set; } = default!;

        /// <summary>
        /// Max number of threads (jobs) for running optimizations per shard. Note: each optimization job will also use `max_indexing_threads` threads by itself for index building. If null - have no limit and choose dynamically to saturate CPU. If 0 - no optimization threads, optimizations will be disabled.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_optimization_threads")]
        public int? MaxOptimizationThreads { get; set; }

        /// <summary>
        /// If this option is set, service will try to prevent creation of large unoptimized segments. When enabled, updates may be blocked at request level if there are unoptimized segments larger than indexing threshold. Updates will be resumed when optimization is completed and segments are optimized below the threshold. Using this option may lead to increased delay between submitting an update and its application. Default is disabled.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prevent_unoptimized")]
        public bool? PreventUnoptimized { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OptimizersConfig" /> class.
        /// </summary>
        /// <param name="defaultSegmentNumber">
        /// Target amount of segments optimizer will try to keep. Real amount of segments may vary depending on multiple parameters: - Amount of stored points - Current write RPS<br/>
        /// It is recommended to select default number of segments as a factor of the number of search threads, so that each segment would be handled evenly by one of the threads. If `default_segment_number = 0`, will be automatically selected by the number of available CPUs.
        /// </param>
        /// <param name="flushIntervalSec">
        /// Minimum interval between forced flushes.
        /// </param>
        /// <param name="deletedThreshold">
        /// The minimal fraction of deleted vectors in a segment, required to perform segment optimization<br/>
        /// Default Value: 0.2F
        /// </param>
        /// <param name="vacuumMinVectorNumber">
        /// The minimal number of vectors in a segment, required to perform segment optimization<br/>
        /// Default Value: 1000
        /// </param>
        /// <param name="maxSegmentSize">
        /// Do not create segments larger this size (in kilobytes). Large segments might require disproportionately long indexation times, therefore it makes sense to limit the size of segments.<br/>
        /// If indexing speed is more important - make this parameter lower. If search speed is more important - make this parameter higher. Note: 1Kb = 1 vector of size 256 If not set, will be automatically selected considering the number of available CPUs.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="indexingThreshold">
        /// Maximum size (in kilobytes) of vectors allowed for plain index, exceeding this threshold will enable vector indexing<br/>
        /// Default value is 10,000, based on experiments and observations.<br/>
        /// To disable vector indexing, set to `0`.<br/>
        /// Note: 1kB = 1 vector of size 256.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="maxOptimizationThreads">
        /// Max number of threads (jobs) for running optimizations per shard. Note: each optimization job will also use `max_indexing_threads` threads by itself for index building. If null - have no limit and choose dynamically to saturate CPU. If 0 - no optimization threads, optimizations will be disabled.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="preventUnoptimized">
        /// If this option is set, service will try to prevent creation of large unoptimized segments. When enabled, updates may be blocked at request level if there are unoptimized segments larger than indexing threshold. Updates will be resumed when optimization is completed and segments are optimized below the threshold. Using this option may lead to increased delay between submitting an update and its application. Default is disabled.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        public OptimizersConfig(
            int defaultSegmentNumber,
            int flushIntervalSec,
            double? deletedThreshold,
            int? vacuumMinVectorNumber,
            int? maxSegmentSize,
            int? indexingThreshold,
            int? maxOptimizationThreads,
            bool? preventUnoptimized)
        {
            this.DeletedThreshold = deletedThreshold;
            this.VacuumMinVectorNumber = vacuumMinVectorNumber;
            this.DefaultSegmentNumber = defaultSegmentNumber;
            this.MaxSegmentSize = maxSegmentSize;
            this.IndexingThreshold = indexingThreshold;
            this.FlushIntervalSec = flushIntervalSec;
            this.MaxOptimizationThreads = maxOptimizationThreads;
            this.PreventUnoptimized = preventUnoptimized;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OptimizersConfig" /> class.
        /// </summary>
        public OptimizersConfig()
        {
        }
    }
}