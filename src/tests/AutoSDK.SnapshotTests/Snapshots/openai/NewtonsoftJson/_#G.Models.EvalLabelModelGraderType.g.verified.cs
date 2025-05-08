//HintName: G.Models.EvalLabelModelGraderType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The object type, which is always `label_model`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EvalLabelModelGraderType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="label_model")]
        LabelModel,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EvalLabelModelGraderTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvalLabelModelGraderType value)
        {
            return value switch
            {
                EvalLabelModelGraderType.LabelModel => "label_model",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvalLabelModelGraderType? ToEnum(string value)
        {
            return value switch
            {
                "label_model" => EvalLabelModelGraderType.LabelModel,
                _ => null,
            };
        }
    }
}