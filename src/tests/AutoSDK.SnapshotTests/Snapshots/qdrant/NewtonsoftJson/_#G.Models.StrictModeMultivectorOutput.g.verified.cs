//HintName: G.Models.StrictModeMultivectorOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StrictModeMultivectorOutput
    {
        /// <summary>
        /// Max number of vectors in a multivector
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_vectors")]
        public int? MaxVectors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StrictModeMultivectorOutput" /> class.
        /// </summary>
        /// <param name="maxVectors">
        /// Max number of vectors in a multivector
        /// </param>
        public StrictModeMultivectorOutput(
            int? maxVectors)
        {
            this.MaxVectors = maxVectors;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StrictModeMultivectorOutput" /> class.
        /// </summary>
        public StrictModeMultivectorOutput()
        {
        }
    }
}