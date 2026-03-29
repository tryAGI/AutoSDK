//HintName: G.Models.ToolDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ToolDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="function")]
        Function,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="graph")]
        Graph,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="llm")]
        Llm,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="translation")]
        Translation,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="vision")]
        Vision,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="web_search")]
        WebSearch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolDiscriminatorType value)
        {
            return value switch
            {
                ToolDiscriminatorType.Function => "function",
                ToolDiscriminatorType.Graph => "graph",
                ToolDiscriminatorType.Llm => "llm",
                ToolDiscriminatorType.Translation => "translation",
                ToolDiscriminatorType.Vision => "vision",
                ToolDiscriminatorType.WebSearch => "web_search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "function" => ToolDiscriminatorType.Function,
                "graph" => ToolDiscriminatorType.Graph,
                "llm" => ToolDiscriminatorType.Llm,
                "translation" => ToolDiscriminatorType.Translation,
                "vision" => ToolDiscriminatorType.Vision,
                "web_search" => ToolDiscriminatorType.WebSearch,
                _ => null,
            };
        }
    }
}