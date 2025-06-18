//HintName: G.Models.GraderMulti.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// A MultiGrader object combines the output of multiple graders to produce a single score.
    /// </summary>
    public sealed partial class GraderMulti
    {
        /// <summary>
        /// The object type, which is always `multi`.<br/>
        /// Default Value: multi
        /// </summary>
        /// <default>global::G.GraderMultiType.Multi</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.GraderMultiType Type { get; set; } = global::G.GraderMultiType.Multi;

        /// <summary>
        /// The name of the grader.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("graders", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<global::G.GraderStringCheck, global::G.GraderTextSimilarity, global::G.GraderPython, global::G.GraderScoreModel, global::G.GraderLabelModel> Graders { get; set; } = default!;

        /// <summary>
        /// A formula to calculate the output based on grader results.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("calculate_output", Required = global::Newtonsoft.Json.Required.Always)]
        public string CalculateOutput { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GraderMulti" /> class.
        /// </summary>
        /// <param name="type">
        /// The object type, which is always `multi`.<br/>
        /// Default Value: multi
        /// </param>
        /// <param name="name">
        /// The name of the grader.
        /// </param>
        /// <param name="graders"></param>
        /// <param name="calculateOutput">
        /// A formula to calculate the output based on grader results.
        /// </param>
        public GraderMulti(
            string name,
            global::G.OneOf<global::G.GraderStringCheck, global::G.GraderTextSimilarity, global::G.GraderPython, global::G.GraderScoreModel, global::G.GraderLabelModel> graders,
            string calculateOutput,
            global::G.GraderMultiType type = global::G.GraderMultiType.Multi)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Graders = graders;
            this.CalculateOutput = calculateOutput ?? throw new global::System.ArgumentNullException(nameof(calculateOutput));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GraderMulti" /> class.
        /// </summary>
        public GraderMulti()
        {
        }
    }
}