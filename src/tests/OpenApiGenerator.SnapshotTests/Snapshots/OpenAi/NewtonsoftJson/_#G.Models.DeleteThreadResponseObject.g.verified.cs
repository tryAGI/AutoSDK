//HintName: G.Models.DeleteThreadResponseObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DeleteThreadResponseObject
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="thread.deleted")]
        Threaddeleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeleteThreadResponseObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteThreadResponseObject value)
        {
            return value switch
            {
                DeleteThreadResponseObject.Threaddeleted => "thread.deleted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteThreadResponseObject? ToEnum(string value)
        {
            return value switch
            {
                "thread.deleted" => DeleteThreadResponseObject.Threaddeleted,
                _ => null,
            };
        }
    }
}