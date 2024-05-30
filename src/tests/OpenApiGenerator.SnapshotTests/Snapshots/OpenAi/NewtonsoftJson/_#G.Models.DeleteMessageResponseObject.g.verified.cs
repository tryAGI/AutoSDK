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
        Threadmessagedeleted,
    }

    public static class DeleteMessageResponseObjectExtensions
    {
        public static string ToValueString(this DeleteMessageResponseObject value)
        {
            return value switch
            {
                DeleteMessageResponseObject.Threadmessagedeleted => "thread.message.deleted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static DeleteMessageResponseObject ToEnum(string value)
        {
            return value switch
            {
                "thread.message.deleted" => DeleteMessageResponseObject.Threadmessagedeleted,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static DeleteMessageResponseObject ToEnum(int value)
        {
            return value switch
            {
                0 => DeleteMessageResponseObject.Threadmessagedeleted,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}