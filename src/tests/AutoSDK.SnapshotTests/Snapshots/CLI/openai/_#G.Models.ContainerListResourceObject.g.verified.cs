//HintName: G.Models.ContainerListResourceObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of object returned, must be 'list'.
    /// </summary>
    public enum ContainerListResourceObject
    {
        /// <summary>
        /// 
        /// </summary>
        List,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ContainerListResourceObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContainerListResourceObject value)
        {
            return value switch
            {
                ContainerListResourceObject.List => "list",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContainerListResourceObject? ToEnum(string value)
        {
            return value switch
            {
                "list" => ContainerListResourceObject.List,
                _ => null,
            };
        }
    }
}