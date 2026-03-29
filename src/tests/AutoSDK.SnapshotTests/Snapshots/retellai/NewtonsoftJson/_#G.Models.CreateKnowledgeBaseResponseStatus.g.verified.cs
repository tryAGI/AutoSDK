//HintName: G.Models.CreateKnowledgeBaseResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateKnowledgeBaseResponseStatus
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
    public static class CreateKnowledgeBaseResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateKnowledgeBaseResponseStatus value)
        {
            return value switch
            {
                CreateKnowledgeBaseResponseStatus.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateKnowledgeBaseResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => CreateKnowledgeBaseResponseStatus.Error,
                _ => null,
            };
        }
    }
}