//HintName: G.Models.StrictModeSparseOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StrictModeSparseOutput
    {
        /// <summary>
        /// Max length of sparse vector
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_length")]
        public int? MaxLength { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StrictModeSparseOutput" /> class.
        /// </summary>
        /// <param name="maxLength">
        /// Max length of sparse vector
        /// </param>
        public StrictModeSparseOutput(
            int? maxLength)
        {
            this.MaxLength = maxLength;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StrictModeSparseOutput" /> class.
        /// </summary>
        public StrictModeSparseOutput()
        {
        }
    }
}