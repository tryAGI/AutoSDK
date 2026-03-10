//HintName: G.Models.MCPToolConfigInputInputOverridesDiscriminatorSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MCPToolConfigInputInputOverridesDiscriminatorSource
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="constant")]
        Constant,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="dynamic_variable")]
        DynamicVariable,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="llm")]
        Llm,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MCPToolConfigInputInputOverridesDiscriminatorSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MCPToolConfigInputInputOverridesDiscriminatorSource value)
        {
            return value switch
            {
                MCPToolConfigInputInputOverridesDiscriminatorSource.Constant => "constant",
                MCPToolConfigInputInputOverridesDiscriminatorSource.DynamicVariable => "dynamic_variable",
                MCPToolConfigInputInputOverridesDiscriminatorSource.Llm => "llm",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MCPToolConfigInputInputOverridesDiscriminatorSource? ToEnum(string value)
        {
            return value switch
            {
                "constant" => MCPToolConfigInputInputOverridesDiscriminatorSource.Constant,
                "dynamic_variable" => MCPToolConfigInputInputOverridesDiscriminatorSource.DynamicVariable,
                "llm" => MCPToolConfigInputInputOverridesDiscriminatorSource.Llm,
                _ => null,
            };
        }
    }
}