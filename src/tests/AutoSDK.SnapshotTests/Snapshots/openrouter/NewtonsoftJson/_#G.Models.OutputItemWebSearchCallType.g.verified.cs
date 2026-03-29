//HintName: G.Models.OutputItemWebSearchCallType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum OutputItemWebSearchCallType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="web_search_call")]
        WebSearchCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputItemWebSearchCallTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputItemWebSearchCallType value)
        {
            return value switch
            {
                OutputItemWebSearchCallType.WebSearchCall => "web_search_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputItemWebSearchCallType? ToEnum(string value)
        {
            return value switch
            {
                "web_search_call" => OutputItemWebSearchCallType.WebSearchCall,
                _ => null,
            };
        }
    }
}