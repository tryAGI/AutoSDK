//HintName: G.Models.InflectionAIModelModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the name of the model. Ex. cognitivecomputations/dolphin-mixtral-8x7b
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum InflectionAIModelModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="inflection_3_pi")]
        Inflection3Pi,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InflectionAIModelModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InflectionAIModelModel value)
        {
            return value switch
            {
                InflectionAIModelModel.Inflection3Pi => "inflection_3_pi",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InflectionAIModelModel? ToEnum(string value)
        {
            return value switch
            {
                "inflection_3_pi" => InflectionAIModelModel.Inflection3Pi,
                _ => null,
            };
        }
    }
}