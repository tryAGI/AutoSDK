//HintName: G.Models.CreateFineTuningJobRequestHyperparametersBatchSize.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateFineTuningJobRequestHyperparametersBatchSize
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
    }

    public static class CreateFineTuningJobRequestHyperparametersBatchSizeExtensions
    {
        public static string ToValueString(this CreateFineTuningJobRequestHyperparametersBatchSize value)
        {
            return value switch
            {
                CreateFineTuningJobRequestHyperparametersBatchSize.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static CreateFineTuningJobRequestHyperparametersBatchSize ToEnum(string value)
        {
            return value switch
            {
                "auto" => CreateFineTuningJobRequestHyperparametersBatchSize.Auto,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static CreateFineTuningJobRequestHyperparametersBatchSize ToEnum(int value)
        {
            return value switch
            {
                0 => CreateFineTuningJobRequestHyperparametersBatchSize.Auto,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}