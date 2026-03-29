//HintName: G.Models.ListKnowledgeBasesResponseStatus2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListKnowledgeBasesResponseStatus2
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListKnowledgeBasesResponseStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListKnowledgeBasesResponseStatus2 value)
        {
            return value switch
            {
                ListKnowledgeBasesResponseStatus2.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListKnowledgeBasesResponseStatus2? ToEnum(string value)
        {
            return value switch
            {
                "error" => ListKnowledgeBasesResponseStatus2.Error,
                _ => null,
            };
        }
    }
}