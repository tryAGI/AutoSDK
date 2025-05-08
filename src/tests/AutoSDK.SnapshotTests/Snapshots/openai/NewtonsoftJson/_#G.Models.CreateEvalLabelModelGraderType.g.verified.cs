//HintName: G.Models.CreateEvalLabelModelGraderType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The object type, which is always `label_model`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateEvalLabelModelGraderType
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
    public static class CreateEvalLabelModelGraderTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateEvalLabelModelGraderType value)
        {
            return value switch
            {
                CreateEvalLabelModelGraderType.LabelModel => "label_model",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateEvalLabelModelGraderType? ToEnum(string value)
        {
            return value switch
            {
                "label_model" => CreateEvalLabelModelGraderType.LabelModel,
                _ => null,
            };
        }
    }
}