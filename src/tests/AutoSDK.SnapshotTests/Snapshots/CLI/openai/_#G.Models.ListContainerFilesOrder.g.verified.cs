//HintName: G.Models.ListContainerFilesOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: desc
    /// </summary>
    public enum ListContainerFilesOrder
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
    public static class ListContainerFilesOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListContainerFilesOrder value)
        {
            return value switch
            {
                ListContainerFilesOrder.Asc => "asc",
                ListContainerFilesOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListContainerFilesOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => ListContainerFilesOrder.Asc,
                "desc" => ListContainerFilesOrder.Desc,
                _ => null,
            };
        }
    }
}