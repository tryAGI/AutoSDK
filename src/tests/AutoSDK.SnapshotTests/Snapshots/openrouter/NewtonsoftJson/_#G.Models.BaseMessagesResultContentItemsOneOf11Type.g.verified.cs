//HintName: G.Models.BaseMessagesResultContentItemsOneOf11Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BaseMessagesResultContentItemsOneOf11Type
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="container_upload")]
        ContainerUpload,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BaseMessagesResultContentItemsOneOf11TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaseMessagesResultContentItemsOneOf11Type value)
        {
            return value switch
            {
                BaseMessagesResultContentItemsOneOf11Type.ContainerUpload => "container_upload",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaseMessagesResultContentItemsOneOf11Type? ToEnum(string value)
        {
            return value switch
            {
                "container_upload" => BaseMessagesResultContentItemsOneOf11Type.ContainerUpload,
                _ => null,
            };
        }
    }
}