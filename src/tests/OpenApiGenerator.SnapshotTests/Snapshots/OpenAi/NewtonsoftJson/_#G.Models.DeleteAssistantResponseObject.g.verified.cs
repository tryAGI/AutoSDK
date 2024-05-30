//HintName: G.Models.DeleteAssistantResponseObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DeleteAssistantResponseObject
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant.deleted")]
        Assistantdeleted,
    }

    public static class DeleteAssistantResponseObjectExtensions
    {
        public static string ToValueString(this DeleteAssistantResponseObject value)
        {
            return value switch
            {
                DeleteAssistantResponseObject.Assistantdeleted => "assistant.deleted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static DeleteAssistantResponseObject ToEnum(string value)
        {
            return value switch
            {
                "assistant.deleted" => DeleteAssistantResponseObject.Assistantdeleted,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static DeleteAssistantResponseObject ToEnum(int value)
        {
            return value switch
            {
                0 => DeleteAssistantResponseObject.Assistantdeleted,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}