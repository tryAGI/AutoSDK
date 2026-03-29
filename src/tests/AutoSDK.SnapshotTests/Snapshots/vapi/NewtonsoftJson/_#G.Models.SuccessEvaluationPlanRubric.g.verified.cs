//HintName: G.Models.SuccessEvaluationPlanRubric.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This enforces the rubric of the evaluation. The output is stored in `call.analysis.successEvaluation`.<br/>
    /// Options include:<br/>
    /// - 'NumericScale': A scale of 1 to 10.<br/>
    /// - 'DescriptiveScale': A scale of Excellent, Good, Fair, Poor.<br/>
    /// - 'Checklist': A checklist of criteria and their status.<br/>
    /// - 'Matrix': A grid that evaluates multiple criteria across different performance levels.<br/>
    /// - 'PercentageScale': A scale of 0% to 100%.<br/>
    /// - 'LikertScale': A scale of Strongly Agree, Agree, Neutral, Disagree, Strongly Disagree.<br/>
    /// - 'AutomaticRubric': Automatically break down evaluation into several criteria, each with its own score.<br/>
    /// - 'PassFail': A simple 'true' if call passed, 'false' if not.<br/>
    /// Default is 'PassFail'.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SuccessEvaluationPlanRubric
    {
        /// <summary>
        /// Automatically break down evaluation into several criteria, each with its own score.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="AutomaticRubric")]
        AutomaticRubric,
        /// <summary>
        /// A checklist of criteria and their status.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Checklist")]
        Checklist,
        /// <summary>
        /// A scale of Excellent, Good, Fair, Poor.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="DescriptiveScale")]
        DescriptiveScale,
        /// <summary>
        /// A scale of Strongly Agree, Agree, Neutral, Disagree, Strongly Disagree.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="LikertScale")]
        LikertScale,
        /// <summary>
        /// A grid that evaluates multiple criteria across different performance levels.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Matrix")]
        Matrix,
        /// <summary>
        /// A scale of 1 to 10.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="NumericScale")]
        NumericScale,
        /// <summary>
        /// A simple 'true' if call passed, 'false' if not.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PassFail")]
        PassFail,
        /// <summary>
        /// A scale of 0% to 100%.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PercentageScale")]
        PercentageScale,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SuccessEvaluationPlanRubricExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SuccessEvaluationPlanRubric value)
        {
            return value switch
            {
                SuccessEvaluationPlanRubric.AutomaticRubric => "AutomaticRubric",
                SuccessEvaluationPlanRubric.Checklist => "Checklist",
                SuccessEvaluationPlanRubric.DescriptiveScale => "DescriptiveScale",
                SuccessEvaluationPlanRubric.LikertScale => "LikertScale",
                SuccessEvaluationPlanRubric.Matrix => "Matrix",
                SuccessEvaluationPlanRubric.NumericScale => "NumericScale",
                SuccessEvaluationPlanRubric.PassFail => "PassFail",
                SuccessEvaluationPlanRubric.PercentageScale => "PercentageScale",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SuccessEvaluationPlanRubric? ToEnum(string value)
        {
            return value switch
            {
                "AutomaticRubric" => SuccessEvaluationPlanRubric.AutomaticRubric,
                "Checklist" => SuccessEvaluationPlanRubric.Checklist,
                "DescriptiveScale" => SuccessEvaluationPlanRubric.DescriptiveScale,
                "LikertScale" => SuccessEvaluationPlanRubric.LikertScale,
                "Matrix" => SuccessEvaluationPlanRubric.Matrix,
                "NumericScale" => SuccessEvaluationPlanRubric.NumericScale,
                "PassFail" => SuccessEvaluationPlanRubric.PassFail,
                "PercentageScale" => SuccessEvaluationPlanRubric.PercentageScale,
                _ => null,
            };
        }
    }
}