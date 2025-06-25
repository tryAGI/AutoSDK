//HintName: G.Models.ListContainersOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: desc
    /// </summary>
    public enum ListContainersOrder
    {
        /// <summary>
        /// 
        /// </summary>
        Asc,
        /// <summary>
        /// 
        /// </summary>
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListContainersOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListContainersOrder value)
        {
            return value switch
            {
                ListContainersOrder.Asc => "asc",
                ListContainersOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListContainersOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => ListContainersOrder.Asc,
                "desc" => ListContainersOrder.Desc,
                _ => null,
            };
        }
    }
}