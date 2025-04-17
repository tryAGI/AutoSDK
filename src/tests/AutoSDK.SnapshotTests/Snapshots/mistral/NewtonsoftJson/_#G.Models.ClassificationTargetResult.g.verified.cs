//HintName: G.Models.ClassificationTargetResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ClassificationTargetResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("scores", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, double> Scores { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassificationTargetResult" /> class.
        /// </summary>
        /// <param name="scores"></param>
        public ClassificationTargetResult(
            global::System.Collections.Generic.Dictionary<string, double> scores)
        {
            this.Scores = scores ?? throw new global::System.ArgumentNullException(nameof(scores));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassificationTargetResult" /> class.
        /// </summary>
        public ClassificationTargetResult()
        {
        }
    }
}