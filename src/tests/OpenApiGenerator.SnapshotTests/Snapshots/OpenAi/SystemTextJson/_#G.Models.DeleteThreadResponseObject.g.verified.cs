//HintName: G.Models.DeleteThreadResponseObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum DeleteThreadResponseObject
    {
        /// <summary>
        /// 
        /// </summary>
        Threaddeleted,
    }

    public static class DeleteThreadResponseObjectExtensions
    {
        public static string ToValueString(this DeleteThreadResponseObject value)
        {
            return value switch
            {
                DeleteThreadResponseObject.Threaddeleted => "thread.deleted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static DeleteThreadResponseObject ToEnum(string value)
        {
            return value switch
            {
                "thread.deleted" => DeleteThreadResponseObject.Threaddeleted,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static DeleteThreadResponseObject ToEnum(int value)
        {
            return value switch
            {
                0 => DeleteThreadResponseObject.Threaddeleted,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}