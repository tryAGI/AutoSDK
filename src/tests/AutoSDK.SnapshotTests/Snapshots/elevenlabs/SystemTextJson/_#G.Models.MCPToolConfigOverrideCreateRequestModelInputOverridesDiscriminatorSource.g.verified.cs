//HintName: G.Models.MCPToolConfigOverrideCreateRequestModelInputOverridesDiscriminatorSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum MCPToolConfigOverrideCreateRequestModelInputOverridesDiscriminatorSource
    {
        /// <summary>
        /// 
        /// </summary>
        Constant,
        /// <summary>
        /// 
        /// </summary>
        DynamicVariable,
        /// <summary>
        /// 
        /// </summary>
        Llm,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MCPToolConfigOverrideCreateRequestModelInputOverridesDiscriminatorSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MCPToolConfigOverrideCreateRequestModelInputOverridesDiscriminatorSource value)
        {
            return value switch
            {
                MCPToolConfigOverrideCreateRequestModelInputOverridesDiscriminatorSource.Constant => "constant",
                MCPToolConfigOverrideCreateRequestModelInputOverridesDiscriminatorSource.DynamicVariable => "dynamic_variable",
                MCPToolConfigOverrideCreateRequestModelInputOverridesDiscriminatorSource.Llm => "llm",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MCPToolConfigOverrideCreateRequestModelInputOverridesDiscriminatorSource? ToEnum(string value)
        {
            return value switch
            {
                "constant" => MCPToolConfigOverrideCreateRequestModelInputOverridesDiscriminatorSource.Constant,
                "dynamic_variable" => MCPToolConfigOverrideCreateRequestModelInputOverridesDiscriminatorSource.DynamicVariable,
                "llm" => MCPToolConfigOverrideCreateRequestModelInputOverridesDiscriminatorSource.Llm,
                _ => null,
            };
        }
    }
}