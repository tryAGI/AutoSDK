//HintName: G.Models.MCPToolConfigOverrideInputOverridesDiscriminatorSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MCPToolConfigOverrideInputOverridesDiscriminatorSource
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
    public static class MCPToolConfigOverrideInputOverridesDiscriminatorSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MCPToolConfigOverrideInputOverridesDiscriminatorSource value)
        {
            return value switch
            {
                MCPToolConfigOverrideInputOverridesDiscriminatorSource.Constant => "constant",
                MCPToolConfigOverrideInputOverridesDiscriminatorSource.DynamicVariable => "dynamic_variable",
                MCPToolConfigOverrideInputOverridesDiscriminatorSource.Llm => "llm",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MCPToolConfigOverrideInputOverridesDiscriminatorSource? ToEnum(string value)
        {
            return value switch
            {
                "constant" => MCPToolConfigOverrideInputOverridesDiscriminatorSource.Constant,
                "dynamic_variable" => MCPToolConfigOverrideInputOverridesDiscriminatorSource.DynamicVariable,
                "llm" => MCPToolConfigOverrideInputOverridesDiscriminatorSource.Llm,
                _ => null,
            };
        }
    }
}