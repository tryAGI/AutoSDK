//HintName: G.Models.ListKnowledgeBasesResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListKnowledgeBasesResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListKnowledgeBasesResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListKnowledgeBasesResponseStatus value)
        {
            return value switch
            {
                ListKnowledgeBasesResponseStatus.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListKnowledgeBasesResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => ListKnowledgeBasesResponseStatus.Error,
                _ => null,
            };
        }
    }
}