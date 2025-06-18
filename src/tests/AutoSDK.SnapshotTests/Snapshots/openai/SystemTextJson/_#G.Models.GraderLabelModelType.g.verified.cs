//HintName: G.Models.GraderLabelModelType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The object type, which is always `label_model`.
    /// </summary>
    public enum GraderLabelModelType
    {
        /// <summary>
        /// 
        /// </summary>
        LabelModel,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GraderLabelModelTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GraderLabelModelType value)
        {
            return value switch
            {
                GraderLabelModelType.LabelModel => "label_model",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GraderLabelModelType? ToEnum(string value)
        {
            return value switch
            {
                "label_model" => GraderLabelModelType.LabelModel,
                _ => null,
            };
        }
    }
}