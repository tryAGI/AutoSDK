//HintName: G.Models.ExpressiveAgentSentimentSentiment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The sentiment of the avatar's expression<br/>
    /// Example: happy
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ExpressiveAgentSentimentSentiment
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Empathetic")]
        Empathetic,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Excited")]
        Excited,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Friendly")]
        Friendly,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Frustrated")]
        Frustrated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Professional")]
        Professional,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExpressiveAgentSentimentSentimentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExpressiveAgentSentimentSentiment value)
        {
            return value switch
            {
                ExpressiveAgentSentimentSentiment.Empathetic => "Empathetic",
                ExpressiveAgentSentimentSentiment.Excited => "Excited",
                ExpressiveAgentSentimentSentiment.Friendly => "Friendly",
                ExpressiveAgentSentimentSentiment.Frustrated => "Frustrated",
                ExpressiveAgentSentimentSentiment.Professional => "Professional",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExpressiveAgentSentimentSentiment? ToEnum(string value)
        {
            return value switch
            {
                "Empathetic" => ExpressiveAgentSentimentSentiment.Empathetic,
                "Excited" => ExpressiveAgentSentimentSentiment.Excited,
                "Friendly" => ExpressiveAgentSentimentSentiment.Friendly,
                "Frustrated" => ExpressiveAgentSentimentSentiment.Frustrated,
                "Professional" => ExpressiveAgentSentimentSentiment.Professional,
                _ => null,
            };
        }
    }
}