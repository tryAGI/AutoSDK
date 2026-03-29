//HintName: G.Models.EvaluationStatusComplete.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EvaluationStatusComplete
    {
        /// <summary>
        /// Default Value: complete
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("code")]
        public string? Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output", Required = global::Newtonsoft.Json.Required.Always)]
        public object Output { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationStatusComplete" /> class.
        /// </summary>
        /// <param name="output"></param>
        /// <param name="code">
        /// Default Value: complete
        /// </param>
        public EvaluationStatusComplete(
            object output,
            string? code)
        {
            this.Code = code;
            this.Output = output ?? throw new global::System.ArgumentNullException(nameof(output));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationStatusComplete" /> class.
        /// </summary>
        public EvaluationStatusComplete()
        {
        }
    }
}