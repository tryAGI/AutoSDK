//HintName: G.Models.CreateTranscriptionRequestModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateTranscriptionRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        Whisper1,
    }

    public static class CreateTranscriptionRequestModelExtensions
    {
        public static string ToValueString(this CreateTranscriptionRequestModel value)
        {
            return value switch
            {
                CreateTranscriptionRequestModel.Whisper1 => "whisper-1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static CreateTranscriptionRequestModel ToEnum(string value)
        {
            return value switch
            {
                "whisper-1" => CreateTranscriptionRequestModel.Whisper1,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static CreateTranscriptionRequestModel ToEnum(int value)
        {
            return value switch
            {
                0 => CreateTranscriptionRequestModel.Whisper1,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}