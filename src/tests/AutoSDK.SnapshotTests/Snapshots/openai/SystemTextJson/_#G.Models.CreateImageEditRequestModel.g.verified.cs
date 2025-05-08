//HintName: G.Models.CreateImageEditRequestModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateImageEditRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        DallE2,
        /// <summary>
        /// 
        /// </summary>
        GptImage1,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateImageEditRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateImageEditRequestModel value)
        {
            return value switch
            {
                CreateImageEditRequestModel.DallE2 => "dall-e-2",
                CreateImageEditRequestModel.GptImage1 => "gpt-image-1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateImageEditRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "dall-e-2" => CreateImageEditRequestModel.DallE2,
                "gpt-image-1" => CreateImageEditRequestModel.GptImage1,
                _ => null,
            };
        }
    }
}