//HintName: G.Models.TestConditionResultCommonModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TestConditionResultCommonModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("result", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.EvaluationSuccessResultJsonConverter))]
        public global::G.EvaluationSuccessResult Result { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rationale")]
        public global::G.TestConditionRationaleCommonModel? Rationale { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TestConditionResultCommonModel" /> class.
        /// </summary>
        /// <param name="result"></param>
        /// <param name="rationale"></param>
        public TestConditionResultCommonModel(
            global::G.EvaluationSuccessResult result,
            global::G.TestConditionRationaleCommonModel? rationale)
        {
            this.Result = result;
            this.Rationale = rationale;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestConditionResultCommonModel" /> class.
        /// </summary>
        public TestConditionResultCommonModel()
        {
        }
    }
}