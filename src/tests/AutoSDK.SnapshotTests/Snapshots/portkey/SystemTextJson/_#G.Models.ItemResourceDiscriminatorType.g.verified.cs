//HintName: G.Models.ItemResourceDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ItemResourceDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        ComputerCall,
        /// <summary>
        /// 
        /// </summary>
        FileSearchCall,
        /// <summary>
        /// 
        /// </summary>
        Message,
        /// <summary>
        /// 
        /// </summary>
        WebSearchCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ItemResourceDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ItemResourceDiscriminatorType value)
        {
            return value switch
            {
                ItemResourceDiscriminatorType.ComputerCall => "computer_call",
                ItemResourceDiscriminatorType.FileSearchCall => "file_search_call",
                ItemResourceDiscriminatorType.Message => "message",
                ItemResourceDiscriminatorType.WebSearchCall => "web_search_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ItemResourceDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "computer_call" => ItemResourceDiscriminatorType.ComputerCall,
                "file_search_call" => ItemResourceDiscriminatorType.FileSearchCall,
                "message" => ItemResourceDiscriminatorType.Message,
                "web_search_call" => ItemResourceDiscriminatorType.WebSearchCall,
                _ => null,
            };
        }
    }
}