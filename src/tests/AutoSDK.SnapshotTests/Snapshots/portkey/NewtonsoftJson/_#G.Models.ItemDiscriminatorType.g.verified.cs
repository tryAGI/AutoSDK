//HintName: G.Models.ItemDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="computer_call")]
        ComputerCall,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="computer_call_output")]
        ComputerCallOutput,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="file_search_call")]
        FileSearchCall,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="function_call")]
        FunctionCall,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="function_call_output")]
        FunctionCallOutput,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="message")]
        Message,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="reasoning")]
        Reasoning,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="web_search_call")]
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