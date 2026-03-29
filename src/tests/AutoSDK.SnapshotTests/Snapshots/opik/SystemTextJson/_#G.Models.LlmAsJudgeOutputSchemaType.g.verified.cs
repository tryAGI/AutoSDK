//HintName: G.Models.LlmAsJudgeOutputSchemaType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum LlmAsJudgeOutputSchemaType
    {
        /// <summary>
        /// 
        /// </summary>
        Boolean,
        /// <summary>
        /// 
        /// </summary>
        Double,
        /// <summary>
        /// 
        /// </summary>
        Integer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LlmAsJudgeOutputSchemaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LlmAsJudgeOutputSchemaType value)
        {
            return value switch
            {
                LlmAsJudgeOutputSchemaType.Boolean => "BOOLEAN",
                LlmAsJudgeOutputSchemaType.Double => "DOUBLE",
                LlmAsJudgeOutputSchemaType.Integer => "INTEGER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LlmAsJudgeOutputSchemaType? ToEnum(string value)
        {
            return value switch
            {
                "BOOLEAN" => LlmAsJudgeOutputSchemaType.Boolean,
                "DOUBLE" => LlmAsJudgeOutputSchemaType.Double,
                "INTEGER" => LlmAsJudgeOutputSchemaType.Integer,
                _ => null,
            };
        }
    }
}