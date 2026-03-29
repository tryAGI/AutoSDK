//HintName: G.Models.XaiModelModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the name of the model. Ex. cognitivecomputations/dolphin-mixtral-8x7b
    /// </summary>
    public enum XaiModelModel
    {
        /// <summary>
        /// 
        /// </summary>
        Grok2,
        /// <summary>
        /// 
        /// </summary>
        Grok3,
        /// <summary>
        /// 
        /// </summary>
        Grok4FastNonReasoning,
        /// <summary>
        /// 
        /// </summary>
        Grok4FastReasoning,
        /// <summary>
        /// 
        /// </summary>
        GrokBeta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class XaiModelModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this XaiModelModel value)
        {
            return value switch
            {
                XaiModelModel.Grok2 => "grok-2",
                XaiModelModel.Grok3 => "grok-3",
                XaiModelModel.Grok4FastNonReasoning => "grok-4-fast-non-reasoning",
                XaiModelModel.Grok4FastReasoning => "grok-4-fast-reasoning",
                XaiModelModel.GrokBeta => "grok-beta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static XaiModelModel? ToEnum(string value)
        {
            return value switch
            {
                "grok-2" => XaiModelModel.Grok2,
                "grok-3" => XaiModelModel.Grok3,
                "grok-4-fast-non-reasoning" => XaiModelModel.Grok4FastNonReasoning,
                "grok-4-fast-reasoning" => XaiModelModel.Grok4FastReasoning,
                "grok-beta" => XaiModelModel.GrokBeta,
                _ => null,
            };
        }
    }
}