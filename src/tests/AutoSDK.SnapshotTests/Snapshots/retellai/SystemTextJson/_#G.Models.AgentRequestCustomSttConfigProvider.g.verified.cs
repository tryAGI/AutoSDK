//HintName: G.Models.AgentRequestCustomSttConfigProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The STT provider to use.
    /// </summary>
    public enum AgentRequestCustomSttConfigProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Azure,
        /// <summary>
        /// 
        /// </summary>
        Deepgram,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentRequestCustomSttConfigProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentRequestCustomSttConfigProvider value)
        {
            return value switch
            {
                AgentRequestCustomSttConfigProvider.Azure => "azure",
                AgentRequestCustomSttConfigProvider.Deepgram => "deepgram",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentRequestCustomSttConfigProvider? ToEnum(string value)
        {
            return value switch
            {
                "azure" => AgentRequestCustomSttConfigProvider.Azure,
                "deepgram" => AgentRequestCustomSttConfigProvider.Deepgram,
                _ => null,
            };
        }
    }
}