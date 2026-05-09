//HintName: G.Models.OutputItemDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum OutputItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="computer_call")]
        ComputerCall,
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
    public static class OutputItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputItemDiscriminatorType value)
        {
            return value switch
            {
                OutputItemDiscriminatorType.ComputerCall => "computer_call",
                OutputItemDiscriminatorType.FileSearchCall => "file_search_call",
                OutputItemDiscriminatorType.FunctionCall => "function_call",
                OutputItemDiscriminatorType.Message => "message",
                OutputItemDiscriminatorType.Reasoning => "reasoning",
                OutputItemDiscriminatorType.WebSearchCall => "web_search_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "computer_call" => OutputItemDiscriminatorType.ComputerCall,
                "file_search_call" => OutputItemDiscriminatorType.FileSearchCall,
                "function_call" => OutputItemDiscriminatorType.FunctionCall,
                "message" => OutputItemDiscriminatorType.Message,
                "reasoning" => OutputItemDiscriminatorType.Reasoning,
                "web_search_call" => OutputItemDiscriminatorType.WebSearchCall,
                _ => null,
            };
        }
    }
}