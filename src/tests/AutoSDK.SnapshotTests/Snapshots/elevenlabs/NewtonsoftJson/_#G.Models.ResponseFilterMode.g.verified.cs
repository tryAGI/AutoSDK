//HintName: G.Models.ResponseFilterMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Controls how tool responses are filtered before being visible to the agent.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ResponseFilterMode
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="all")]
        All,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="allow")]
        Allow,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseFilterModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseFilterMode value)
        {
            return value switch
            {
                ResponseFilterMode.All => "all",
                ResponseFilterMode.Allow => "allow",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseFilterMode? ToEnum(string value)
        {
            return value switch
            {
                "all" => ResponseFilterMode.All,
                "allow" => ResponseFilterMode.Allow,
                _ => null,
            };
        }
    }
}