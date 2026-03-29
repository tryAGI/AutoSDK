//HintName: G.Models.LlmAsJudgeOutputSchemaWriteType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum LlmAsJudgeOutputSchemaWriteType
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
    public static class LlmAsJudgeOutputSchemaWriteTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LlmAsJudgeOutputSchemaWriteType value)
        {
            return value switch
            {
                LlmAsJudgeOutputSchemaWriteType.Boolean => "BOOLEAN",
                LlmAsJudgeOutputSchemaWriteType.Double => "DOUBLE",
                LlmAsJudgeOutputSchemaWriteType.Integer => "INTEGER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LlmAsJudgeOutputSchemaWriteType? ToEnum(string value)
        {
            return value switch
            {
                "BOOLEAN" => LlmAsJudgeOutputSchemaWriteType.Boolean,
                "DOUBLE" => LlmAsJudgeOutputSchemaWriteType.Double,
                "INTEGER" => LlmAsJudgeOutputSchemaWriteType.Integer,
                _ => null,
            };
        }
    }
}