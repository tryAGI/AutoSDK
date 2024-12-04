//HintName: G.Models.ListFilesOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: desc
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListFilesOrder
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

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListFilesOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListFilesOrder value)
        {
            return value switch
            {
                ListFilesOrder.Asc => "asc",
                ListFilesOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListFilesOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => ListFilesOrder.Asc,
                "desc" => ListFilesOrder.Desc,
                _ => null,
            };
        }
    }
}