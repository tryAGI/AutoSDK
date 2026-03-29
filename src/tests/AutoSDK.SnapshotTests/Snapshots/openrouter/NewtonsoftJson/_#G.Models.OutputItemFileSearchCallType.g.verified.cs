//HintName: G.Models.OutputItemFileSearchCallType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum OutputItemFileSearchCallType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="file_search_call")]
        FileSearchCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputItemFileSearchCallTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputItemFileSearchCallType value)
        {
            return value switch
            {
                OutputItemFileSearchCallType.FileSearchCall => "file_search_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputItemFileSearchCallType? ToEnum(string value)
        {
            return value switch
            {
                "file_search_call" => OutputItemFileSearchCallType.FileSearchCall,
                _ => null,
            };
        }
    }
}