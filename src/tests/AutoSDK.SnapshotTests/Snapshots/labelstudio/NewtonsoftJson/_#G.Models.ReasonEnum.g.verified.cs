//HintName: G.Models.ReasonEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// * `MANUAL` - Manual<br/>
    /// * `BEHAVIOR_BASED` - Behavior-based<br/>
    /// * `ANNOTATOR_EVALUATION` - Annotator evaluation<br/>
    /// * `ANNOTATION_LIMIT` - Annotation limit<br/>
    /// * `CUSTOM_SCRIPT` - Custom script
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ReasonEnum
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ANNOTATION_LIMIT")]
        AnnotationLimit,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ANNOTATOR_EVALUATION")]
        AnnotatorEvaluation,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="BEHAVIOR_BASED")]
        BehaviorBased,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CUSTOM_SCRIPT")]
        CustomScript,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="MANUAL")]
        Manual,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReasonEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReasonEnum value)
        {
            return value switch
            {
                ReasonEnum.AnnotationLimit => "ANNOTATION_LIMIT",
                ReasonEnum.AnnotatorEvaluation => "ANNOTATOR_EVALUATION",
                ReasonEnum.BehaviorBased => "BEHAVIOR_BASED",
                ReasonEnum.CustomScript => "CUSTOM_SCRIPT",
                ReasonEnum.Manual => "MANUAL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReasonEnum? ToEnum(string value)
        {
            return value switch
            {
                "ANNOTATION_LIMIT" => ReasonEnum.AnnotationLimit,
                "ANNOTATOR_EVALUATION" => ReasonEnum.AnnotatorEvaluation,
                "BEHAVIOR_BASED" => ReasonEnum.BehaviorBased,
                "CUSTOM_SCRIPT" => ReasonEnum.CustomScript,
                "MANUAL" => ReasonEnum.Manual,
                _ => null,
            };
        }
    }
}