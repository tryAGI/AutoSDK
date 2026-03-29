//HintName: G.Models.LlmAsJudgeOutputSchemaPublicType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum LlmAsJudgeOutputSchemaPublicType
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
    public static class LlmAsJudgeOutputSchemaPublicTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LlmAsJudgeOutputSchemaPublicType value)
        {
            return value switch
            {
                LlmAsJudgeOutputSchemaPublicType.Boolean => "BOOLEAN",
                LlmAsJudgeOutputSchemaPublicType.Double => "DOUBLE",
                LlmAsJudgeOutputSchemaPublicType.Integer => "INTEGER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LlmAsJudgeOutputSchemaPublicType? ToEnum(string value)
        {
            return value switch
            {
                "BOOLEAN" => LlmAsJudgeOutputSchemaPublicType.Boolean,
                "DOUBLE" => LlmAsJudgeOutputSchemaPublicType.Double,
                "INTEGER" => LlmAsJudgeOutputSchemaPublicType.Integer,
                _ => null,
            };
        }
    }
}