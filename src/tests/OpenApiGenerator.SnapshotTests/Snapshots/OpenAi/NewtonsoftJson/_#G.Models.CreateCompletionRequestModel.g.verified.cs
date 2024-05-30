//HintName: G.Models.CreateCompletionRequestModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateCompletionRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gpt-3.5-turbo-instruct")]
        Gpt35TurboInstruct,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="davinci-002")]
        Davinci002,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="babbage-002")]
        Babbage002,
    }

    public static class CreateCompletionRequestModelExtensions
    {
        public static string ToValueString(this CreateCompletionRequestModel value)
        {
            return value switch
            {
                CreateCompletionRequestModel.Gpt35TurboInstruct => "gpt-3.5-turbo-instruct",
                CreateCompletionRequestModel.Davinci002 => "davinci-002",
                CreateCompletionRequestModel.Babbage002 => "babbage-002",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static CreateCompletionRequestModel ToEnum(string value)
        {
            return value switch
            {
                "gpt-3.5-turbo-instruct" => CreateCompletionRequestModel.Gpt35TurboInstruct,
                "davinci-002" => CreateCompletionRequestModel.Davinci002,
                "babbage-002" => CreateCompletionRequestModel.Babbage002,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static CreateCompletionRequestModel ToEnum(int value)
        {
            return value switch
            {
                0 => CreateCompletionRequestModel.Gpt35TurboInstruct,
                1 => CreateCompletionRequestModel.Davinci002,
                2 => CreateCompletionRequestModel.Babbage002,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}