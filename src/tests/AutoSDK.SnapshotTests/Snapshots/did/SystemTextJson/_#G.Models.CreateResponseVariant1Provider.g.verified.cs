//HintName: G.Models.CreateResponseVariant1Provider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The provider of the agent
    /// </summary>
    public enum CreateResponseVariant1Provider
    {
        /// <summary>
        /// 
        /// </summary>
        DIdAgents,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateResponseVariant1ProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateResponseVariant1Provider value)
        {
            return value switch
            {
                CreateResponseVariant1Provider.DIdAgents => "d-id-agents",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateResponseVariant1Provider? ToEnum(string value)
        {
            return value switch
            {
                "d-id-agents" => CreateResponseVariant1Provider.DIdAgents,
                _ => null,
            };
        }
    }
}