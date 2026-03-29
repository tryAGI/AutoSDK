//HintName: G.Models.CreateKnowledgeBaseResponseStatus5.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateKnowledgeBaseResponseStatus5
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="error")]
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateKnowledgeBaseResponseStatus5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateKnowledgeBaseResponseStatus5 value)
        {
            return value switch
            {
                CreateKnowledgeBaseResponseStatus5.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateKnowledgeBaseResponseStatus5? ToEnum(string value)
        {
            return value switch
            {
                "error" => CreateKnowledgeBaseResponseStatus5.Error,
                _ => null,
            };
        }
    }
}