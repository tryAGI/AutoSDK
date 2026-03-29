//HintName: G.Models.DeleteKnowledgeBaseSourceResponseStatus3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DeleteKnowledgeBaseSourceResponseStatus3
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
    public static class DeleteKnowledgeBaseSourceResponseStatus3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteKnowledgeBaseSourceResponseStatus3 value)
        {
            return value switch
            {
                DeleteKnowledgeBaseSourceResponseStatus3.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteKnowledgeBaseSourceResponseStatus3? ToEnum(string value)
        {
            return value switch
            {
                "error" => DeleteKnowledgeBaseSourceResponseStatus3.Error,
                _ => null,
            };
        }
    }
}