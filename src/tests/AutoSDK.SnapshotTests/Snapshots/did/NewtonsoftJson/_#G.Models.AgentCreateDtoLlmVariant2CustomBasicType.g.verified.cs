//HintName: G.Models.AgentCreateDtoLlmVariant2CustomBasicType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AgentCreateDtoLlmVariant2CustomBasicType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="basic")]
        Basic,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentCreateDtoLlmVariant2CustomBasicTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentCreateDtoLlmVariant2CustomBasicType value)
        {
            return value switch
            {
                AgentCreateDtoLlmVariant2CustomBasicType.Basic => "basic",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentCreateDtoLlmVariant2CustomBasicType? ToEnum(string value)
        {
            return value switch
            {
                "basic" => AgentCreateDtoLlmVariant2CustomBasicType.Basic,
                _ => null,
            };
        }
    }
}