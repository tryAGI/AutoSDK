//HintName: G.Models.DeleteAssistantResponseObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum DeleteAssistantResponseObject
    {
        /// <summary>
        /// 
        /// </summary>
        Assistantdeleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeleteAssistantResponseObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteAssistantResponseObject value)
        {
            return value switch
            {
                DeleteAssistantResponseObject.Assistantdeleted => "assistant.deleted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteAssistantResponseObject? ToEnum(string value)
        {
            return value switch
            {
                "assistant.deleted" => DeleteAssistantResponseObject.Assistantdeleted,
                _ => null,
            };
        }
    }
}