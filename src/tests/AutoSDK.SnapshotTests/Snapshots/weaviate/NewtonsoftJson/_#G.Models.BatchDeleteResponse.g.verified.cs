//HintName: G.Models.BatchDeleteResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Delete Objects response.
    /// </summary>
    public sealed partial class BatchDeleteResponse
    {
        /// <summary>
        /// Outlines how to find the objects to be deleted.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("match")]
        public global::G.BatchDeleteResponseMatch? Match { get; set; }

        /// <summary>
        /// Controls the verbosity of the output.<br/>
        /// Default Value: minimal
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output")]
        public global::G.BatchDeleteResponseOutput? Output { get; set; }

        /// <summary>
        /// If true, objects will not be deleted yet, but merely listed. Defaults to false.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dryRun")]
        public bool? DryRun { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("results")]
        public global::G.BatchDeleteResponseResults? Results { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchDeleteResponse" /> class.
        /// </summary>
        /// <param name="match">
        /// Outlines how to find the objects to be deleted.
        /// </param>
        /// <param name="output">
        /// Controls the verbosity of the output.<br/>
        /// Default Value: minimal
        /// </param>
        /// <param name="dryRun">
        /// If true, objects will not be deleted yet, but merely listed. Defaults to false.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="results"></param>
        public BatchDeleteResponse(
            global::G.BatchDeleteResponseMatch? match,
            global::G.BatchDeleteResponseOutput? output,
            bool? dryRun,
            global::G.BatchDeleteResponseResults? results)
        {
            this.Match = match;
            this.Output = output;
            this.DryRun = dryRun;
            this.Results = results;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchDeleteResponse" /> class.
        /// </summary>
        public BatchDeleteResponse()
        {
        }
    }
}