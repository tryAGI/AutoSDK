//HintName: G.Models.FineTuneSupervisedMethodHyperparametersNEpochs.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FineTuneSupervisedMethodHyperparametersNEpochs
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="auto")]
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FineTuneSupervisedMethodHyperparametersNEpochsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FineTuneSupervisedMethodHyperparametersNEpochs value)
        {
            return value switch
            {
                FineTuneSupervisedMethodHyperparametersNEpochs.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FineTuneSupervisedMethodHyperparametersNEpochs? ToEnum(string value)
        {
            return value switch
            {
                "auto" => FineTuneSupervisedMethodHyperparametersNEpochs.Auto,
                _ => null,
            };
        }
    }
}