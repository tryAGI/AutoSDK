//HintName: G.Models.DeepSeekModelModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the name of the model. Ex. cognitivecomputations/dolphin-mixtral-8x7b
    /// </summary>
    public enum DeepSeekModelModel
    {
        /// <summary>
        /// 
        /// </summary>
        DeepseekChat,
        /// <summary>
        /// 
        /// </summary>
        DeepseekReasoner,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeepSeekModelModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeepSeekModelModel value)
        {
            return value switch
            {
                DeepSeekModelModel.DeepseekChat => "deepseek-chat",
                DeepSeekModelModel.DeepseekReasoner => "deepseek-reasoner",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeepSeekModelModel? ToEnum(string value)
        {
            return value switch
            {
                "deepseek-chat" => DeepSeekModelModel.DeepseekChat,
                "deepseek-reasoner" => DeepSeekModelModel.DeepseekReasoner,
                _ => null,
            };
        }
    }
}