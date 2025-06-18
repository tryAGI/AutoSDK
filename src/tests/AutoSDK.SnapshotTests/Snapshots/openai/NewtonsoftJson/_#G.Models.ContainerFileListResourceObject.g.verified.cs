//HintName: G.Models.ContainerFileListResourceObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of object returned, must be 'list'.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ContainerFileListResourceObject
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="list")]
        List,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ContainerFileListResourceObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContainerFileListResourceObject value)
        {
            return value switch
            {
                ContainerFileListResourceObject.List => "list",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContainerFileListResourceObject? ToEnum(string value)
        {
            return value switch
            {
                "list" => ContainerFileListResourceObject.List,
                _ => null,
            };
        }
    }
}