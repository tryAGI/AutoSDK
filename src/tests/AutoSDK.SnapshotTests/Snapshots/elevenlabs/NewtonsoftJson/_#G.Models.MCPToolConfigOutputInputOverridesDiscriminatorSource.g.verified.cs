//HintName: G.Models.MCPToolConfigOutputInputOverridesDiscriminatorSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MCPToolConfigOutputInputOverridesDiscriminatorSource
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
    public static class MCPToolConfigOutputInputOverridesDiscriminatorSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MCPToolConfigOutputInputOverridesDiscriminatorSource value)
        {
            return value switch
            {
                MCPToolConfigOutputInputOverridesDiscriminatorSource.Constant => "constant",
                MCPToolConfigOutputInputOverridesDiscriminatorSource.DynamicVariable => "dynamic_variable",
                MCPToolConfigOutputInputOverridesDiscriminatorSource.Llm => "llm",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MCPToolConfigOutputInputOverridesDiscriminatorSource? ToEnum(string value)
        {
            return value switch
            {
                "constant" => MCPToolConfigOutputInputOverridesDiscriminatorSource.Constant,
                "dynamic_variable" => MCPToolConfigOutputInputOverridesDiscriminatorSource.DynamicVariable,
                "llm" => MCPToolConfigOutputInputOverridesDiscriminatorSource.Llm,
                _ => null,
            };
        }
    }
}