//HintName: G.Models.CreateTranslationRequestModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateTranslationRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        Whisper1,
    }

    public static class CreateTranslationRequestModelExtensions
    {
        public static string ToValueString(this CreateTranslationRequestModel value)
        {
            return value switch
            {
                CreateTranslationRequestModel.Whisper1 => "whisper-1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static CreateTranslationRequestModel ToEnum(string value)
        {
            return value switch
            {
                "whisper-1" => CreateTranslationRequestModel.Whisper1,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static CreateTranslationRequestModel ToEnum(int value)
        {
            return value switch
            {
                0 => CreateTranslationRequestModel.Whisper1,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}