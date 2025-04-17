//HintName: G.Models.FineTuneableModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The name of the model to fine-tune.
    /// </summary>
    public enum FineTuneableModel
    {
        /// <summary>
        /// 
        /// </summary>
        OpenMistral7b,
        /// <summary>
        /// 
        /// </summary>
        MistralSmallLatest,
        /// <summary>
        /// 
        /// </summary>
        CodestralLatest,
        /// <summary>
        /// 
        /// </summary>
        MistralLargeLatest,
        /// <summary>
        /// 
        /// </summary>
        OpenMistralNemo,
        /// <summary>
        /// 
        /// </summary>
        Ministral3bLatest,
        /// <summary>
        /// 
        /// </summary>
        Ministral8bLatest,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FineTuneableModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FineTuneableModel value)
        {
            return value switch
            {
                FineTuneableModel.OpenMistral7b => "open-mistral-7b",
                FineTuneableModel.MistralSmallLatest => "mistral-small-latest",
                FineTuneableModel.CodestralLatest => "codestral-latest",
                FineTuneableModel.MistralLargeLatest => "mistral-large-latest",
                FineTuneableModel.OpenMistralNemo => "open-mistral-nemo",
                FineTuneableModel.Ministral3bLatest => "ministral-3b-latest",
                FineTuneableModel.Ministral8bLatest => "ministral-8b-latest",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FineTuneableModel? ToEnum(string value)
        {
            return value switch
            {
                "open-mistral-7b" => FineTuneableModel.OpenMistral7b,
                "mistral-small-latest" => FineTuneableModel.MistralSmallLatest,
                "codestral-latest" => FineTuneableModel.CodestralLatest,
                "mistral-large-latest" => FineTuneableModel.MistralLargeLatest,
                "open-mistral-nemo" => FineTuneableModel.OpenMistralNemo,
                "ministral-3b-latest" => FineTuneableModel.Ministral3bLatest,
                "ministral-8b-latest" => FineTuneableModel.Ministral8bLatest,
                _ => null,
            };
        }
    }
}