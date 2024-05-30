//HintName: G.Models.DeleteMessageResponseObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum DeleteMessageResponseObject
    {
        /// <summary>
        /// 
        /// </summary>
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