//HintName: G.Models.MCPToolConfigOverrideUpdateRequestModelInputOverridesDiscriminatorSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MCPToolConfigOverrideUpdateRequestModelInputOverridesDiscriminatorSource
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
    public static class MCPToolConfigOverrideUpdateRequestModelInputOverridesDiscriminatorSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MCPToolConfigOverrideUpdateRequestModelInputOverridesDiscriminatorSource value)
        {
            return value switch
            {
                MCPToolConfigOverrideUpdateRequestModelInputOverridesDiscriminatorSource.Constant => "constant",
                MCPToolConfigOverrideUpdateRequestModelInputOverridesDiscriminatorSource.DynamicVariable => "dynamic_variable",
                MCPToolConfigOverrideUpdateRequestModelInputOverridesDiscriminatorSource.Llm => "llm",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MCPToolConfigOverrideUpdateRequestModelInputOverridesDiscriminatorSource? ToEnum(string value)
        {
            return value switch
            {
                "constant" => MCPToolConfigOverrideUpdateRequestModelInputOverridesDiscriminatorSource.Constant,
                "dynamic_variable" => MCPToolConfigOverrideUpdateRequestModelInputOverridesDiscriminatorSource.DynamicVariable,
                "llm" => MCPToolConfigOverrideUpdateRequestModelInputOverridesDiscriminatorSource.Llm,
                _ => null,
            };
        }
    }
}