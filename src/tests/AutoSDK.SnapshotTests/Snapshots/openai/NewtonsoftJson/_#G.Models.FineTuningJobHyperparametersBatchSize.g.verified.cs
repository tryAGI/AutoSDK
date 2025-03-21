//HintName: G.Models.FineTuningJobHyperparametersBatchSize.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FineTuningJobHyperparametersBatchSize
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
    public static class FineTuningJobHyperparametersBatchSizeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FineTuningJobHyperparametersBatchSize value)
        {
            return value switch
            {
                FineTuningJobHyperparametersBatchSize.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FineTuningJobHyperparametersBatchSize? ToEnum(string value)
        {
            return value switch
            {
                "auto" => FineTuningJobHyperparametersBatchSize.Auto,
                _ => null,
            };
        }
    }
}