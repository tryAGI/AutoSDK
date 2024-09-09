//HintName: G.Models.DeleteMessageResponseObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DeleteMessageResponseObject
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="thread.message.deleted")]
        ThreadMessageDeleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeleteMessageResponseObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteMessageResponseObject value)
        {
            return value switch
            {
                DeleteMessageResponseObject.ThreadMessageDeleted => "thread.message.deleted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteMessageResponseObject? ToEnum(string value)
        {
            return value switch
            {
                "thread.message.deleted" => DeleteMessageResponseObject.ThreadMessageDeleted,
                _ => null,
            };
        }
    }
}