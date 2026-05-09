//HintName: G.Models.ItemDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        ComputerCall,
        /// <summary>
        /// 
        /// </summary>
        ComputerCallOutput,
        /// <summary>
        /// 
        /// </summary>
        FileSearchCall,
        /// <summary>
        /// 
        /// </summary>
        FunctionCall,
        /// <summary>
        /// 
        /// </summary>
        FunctionCallOutput,
        /// <summary>
        /// 
        /// </summary>
        Message,
        /// <summary>
        /// 
        /// </summary>
        Reasoning,
        /// <summary>
        /// 
        /// </summary>
        WebSearchCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ItemDiscriminatorType value)
        {
            return value switch
            {
                ItemDiscriminatorType.ComputerCall => "computer_call",
                ItemDiscriminatorType.ComputerCallOutput => "computer_call_output",
                ItemDiscriminatorType.FileSearchCall => "file_search_call",
                ItemDiscriminatorType.FunctionCall => "function_call",
                ItemDiscriminatorType.FunctionCallOutput => "function_call_output",
                ItemDiscriminatorType.Message => "message",
                ItemDiscriminatorType.Reasoning => "reasoning",
                ItemDiscriminatorType.WebSearchCall => "web_search_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "computer_call" => ItemDiscriminatorType.ComputerCall,
                "computer_call_output" => ItemDiscriminatorType.ComputerCallOutput,
                "file_search_call" => ItemDiscriminatorType.FileSearchCall,
                "function_call" => ItemDiscriminatorType.FunctionCall,
                "function_call_output" => ItemDiscriminatorType.FunctionCallOutput,
                "message" => ItemDiscriminatorType.Message,
                "reasoning" => ItemDiscriminatorType.Reasoning,
                "web_search_call" => ItemDiscriminatorType.WebSearchCall,
                _ => null,
            };
        }
    }
}