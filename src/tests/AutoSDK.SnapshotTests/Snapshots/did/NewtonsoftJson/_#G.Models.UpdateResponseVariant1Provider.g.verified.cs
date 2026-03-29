//HintName: G.Models.UpdateResponseVariant1Provider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The provider of the agent
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UpdateResponseVariant1Provider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="d-id-agents")]
        DIdAgents,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateResponseVariant1ProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateResponseVariant1Provider value)
        {
            return value switch
            {
                UpdateResponseVariant1Provider.DIdAgents => "d-id-agents",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateResponseVariant1Provider? ToEnum(string value)
        {
            return value switch
            {
                "d-id-agents" => UpdateResponseVariant1Provider.DIdAgents,
                _ => null,
            };
        }
    }
}