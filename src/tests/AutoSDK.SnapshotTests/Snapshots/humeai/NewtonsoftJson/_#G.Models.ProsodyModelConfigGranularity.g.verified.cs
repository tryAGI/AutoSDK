//HintName: G.Models.ProsodyModelConfigGranularity.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ProsodyModelConfigGranularity
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="conversational_turn")]
        ConversationalTurn,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="sentence")]
        Sentence,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="utterance")]
        Utterance,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="word")]
        Word,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProsodyModelConfigGranularityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProsodyModelConfigGranularity value)
        {
            return value switch
            {
                ProsodyModelConfigGranularity.ConversationalTurn => "conversational_turn",
                ProsodyModelConfigGranularity.Sentence => "sentence",
                ProsodyModelConfigGranularity.Utterance => "utterance",
                ProsodyModelConfigGranularity.Word => "word",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProsodyModelConfigGranularity? ToEnum(string value)
        {
            return value switch
            {
                "conversational_turn" => ProsodyModelConfigGranularity.ConversationalTurn,
                "sentence" => ProsodyModelConfigGranularity.Sentence,
                "utterance" => ProsodyModelConfigGranularity.Utterance,
                "word" => ProsodyModelConfigGranularity.Word,
                _ => null,
            };
        }
    }
}