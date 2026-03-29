//HintName: G.Models.OutputItemWebSearchCallActionOneOf0SourcesItemsType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum OutputItemWebSearchCallActionOneOf0SourcesItemsType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="url")]
        Url,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputItemWebSearchCallActionOneOf0SourcesItemsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputItemWebSearchCallActionOneOf0SourcesItemsType value)
        {
            return value switch
            {
                OutputItemWebSearchCallActionOneOf0SourcesItemsType.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputItemWebSearchCallActionOneOf0SourcesItemsType? ToEnum(string value)
        {
            return value switch
            {
                "url" => OutputItemWebSearchCallActionOneOf0SourcesItemsType.Url,
                _ => null,
            };
        }
    }
}