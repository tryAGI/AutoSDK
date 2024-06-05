//HintName: G.Models.CreateFineTuningJobRequestModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateFineTuningJobRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="babbage-002")]
        Babbage002,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="davinci-002")]
        Davinci002,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-3.5-turbo")]
        Gpt35Turbo,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateFineTuningJobRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
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
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateFineTuningJobRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "babbage-002" => CreateFineTuningJobRequestModel.Babbage002,
                "davinci-002" => CreateFineTuningJobRequestModel.Davinci002,
                "gpt-3.5-turbo" => CreateFineTuningJobRequestModel.Gpt35Turbo,
                _ => null,
            };
        }
    }
}