//HintName: G.Models.LlmAsJudgeOutputSchemaType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum LlmAsJudgeOutputSchemaType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="BOOLEAN")]
        Boolean,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="DOUBLE")]
        Double,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="INTEGER")]
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