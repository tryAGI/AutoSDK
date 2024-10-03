//HintName: G.Models.ObjectsListOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ObjectsListOrder
    {
        /// <summary>
        /// `sort=author_name,title&order=desc,asc`.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="asc")]
        Asc,
        /// <summary>
        /// `sort=author_name,title&order=desc,asc`.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="desc")]
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ObjectsListOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ObjectsListOrder value)
        {
            return value switch
            {
                ObjectsListOrder.Asc => "asc",
                ObjectsListOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ObjectsListOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => ObjectsListOrder.Asc,
                "desc" => ObjectsListOrder.Desc,
                _ => null,
            };
        }
    }
}