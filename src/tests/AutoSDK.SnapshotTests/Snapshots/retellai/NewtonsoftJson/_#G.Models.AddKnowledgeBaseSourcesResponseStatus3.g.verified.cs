//HintName: G.Models.AddKnowledgeBaseSourcesResponseStatus3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AddKnowledgeBaseSourcesResponseStatus3
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
    public static class AddKnowledgeBaseSourcesResponseStatus3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AddKnowledgeBaseSourcesResponseStatus3 value)
        {
            return value switch
            {
                AddKnowledgeBaseSourcesResponseStatus3.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AddKnowledgeBaseSourcesResponseStatus3? ToEnum(string value)
        {
            return value switch
            {
                "error" => AddKnowledgeBaseSourcesResponseStatus3.Error,
                _ => null,
            };
        }
    }
}