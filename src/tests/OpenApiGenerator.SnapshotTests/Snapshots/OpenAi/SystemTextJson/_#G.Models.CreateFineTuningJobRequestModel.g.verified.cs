//HintName: G.Models.CreateFineTuningJobRequestModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateFineTuningJobRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        Babbage002,
        /// <summary>
        /// 
        /// </summary>
        Davinci002,
        /// <summary>
        /// 
        /// </summary>
        Gpt35Turbo,
    }

    public static class CreateFineTuningJobRequestModelExtensions
    {
        public static string ToValueString(this CreateFineTuningJobRequestModel value)
        {
            return value switch
            {
                CreateFineTuningJobRequestModel.Babbage002 => "babbage-002",
                CreateFineTuningJobRequestModel.Davinci002 => "davinci-002",
                CreateFineTuningJobRequestModel.Gpt35Turbo => "gpt-3.5-turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static CreateFineTuningJobRequestModel ToEnum(string value)
        {
            return value switch
            {
                "babbage-002" => CreateFineTuningJobRequestModel.Babbage002,
                "davinci-002" => CreateFineTuningJobRequestModel.Davinci002,
                "gpt-3.5-turbo" => CreateFineTuningJobRequestModel.Gpt35Turbo,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static CreateFineTuningJobRequestModel ToEnum(int value)
        {
            return value switch
            {
                0 => CreateFineTuningJobRequestModel.Babbage002,
                1 => CreateFineTuningJobRequestModel.Davinci002,
                2 => CreateFineTuningJobRequestModel.Gpt35Turbo,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}