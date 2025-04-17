//HintName: G.Models.FineTuneableModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The name of the model to fine-tune.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FineTuneableModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="open-mistral-7b")]
        OpenMistral7b,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mistral-small-latest")]
        MistralSmallLatest,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="codestral-latest")]
        CodestralLatest,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mistral-large-latest")]
        MistralLargeLatest,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="open-mistral-nemo")]
        OpenMistralNemo,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ministral-3b-latest")]
        Ministral3bLatest,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ministral-8b-latest")]
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