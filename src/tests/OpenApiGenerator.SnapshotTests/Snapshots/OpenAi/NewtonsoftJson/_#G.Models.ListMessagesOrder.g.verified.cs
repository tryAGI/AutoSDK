//HintName: G.Models.ListMessagesOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// <br/>Default Value: desc
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListMessagesOrder
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="asc")]
        Asc,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="desc")]
        Desc,
    }

    public static class ListMessagesOrderExtensions
    {
        public static string ToValueString(this ListMessagesOrder value)
        {
            return value switch
            {
                ListMessagesOrder.Asc => "asc",
                ListMessagesOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static ListMessagesOrder ToEnum(string value)
        {
            return value switch
            {
                "asc" => ListMessagesOrder.Asc,
                "desc" => ListMessagesOrder.Desc,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static ListMessagesOrder ToEnum(int value)
        {
            return value switch
            {
                0 => ListMessagesOrder.Asc,
                1 => ListMessagesOrder.Desc,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}