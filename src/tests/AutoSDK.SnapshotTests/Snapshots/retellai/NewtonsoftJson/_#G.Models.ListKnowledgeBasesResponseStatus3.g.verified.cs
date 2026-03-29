//HintName: G.Models.ListKnowledgeBasesResponseStatus3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListKnowledgeBasesResponseStatus3
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
    public static class ListKnowledgeBasesResponseStatus3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListKnowledgeBasesResponseStatus3 value)
        {
            return value switch
            {
                ListKnowledgeBasesResponseStatus3.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListKnowledgeBasesResponseStatus3? ToEnum(string value)
        {
            return value switch
            {
                "error" => ListKnowledgeBasesResponseStatus3.Error,
                _ => null,
            };
        }
    }
}