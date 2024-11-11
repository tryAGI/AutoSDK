//HintName: G.Models.BatchDelete.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BatchDelete
    {
        /// <summary>
        /// Outlines how to find the objects to be deleted.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("match")]
        public global::G.BatchDeleteMatch? Match { get; set; }

        /// <summary>
        /// Controls the verbosity of the output.<br/>
        /// Default Value: minimal
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output")]
        public global::G.BatchDeleteOutput? Output { get; set; }

        /// <summary>
        /// If true, the call will show which objects would be matched using the specified filter without deleting any objects. &lt;br/&gt;&lt;br/&gt;Depending on the configured verbosity, you will either receive a count of affected objects, or a list of IDs.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dryRun")]
        public bool? DryRun { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchDelete" /> class.
        /// </summary>
        /// <param name="match">
        /// Outlines how to find the objects to be deleted.
        /// </param>
        /// <param name="output">
        /// Controls the verbosity of the output.<br/>
        /// Default Value: minimal
        /// </param>
        /// <param name="dryRun">
        /// If true, the call will show which objects would be matched using the specified filter without deleting any objects. &lt;br/&gt;&lt;br/&gt;Depending on the configured verbosity, you will either receive a count of affected objects, or a list of IDs.<br/>
        /// Default Value: false
        /// </param>
        public BatchDelete(
            global::G.BatchDeleteMatch? match,
            global::G.BatchDeleteOutput? output,
            bool? dryRun)
        {
            this.Match = match;
            this.Output = output;
            this.DryRun = dryRun;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchDelete" /> class.
        /// </summary>
        public BatchDelete()
        {
        }
    }
}