//HintName: G.Models.CreateImageRequestModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateImageRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        DallE2,
        /// <summary>
        /// 
        /// </summary>
        DallE3,
        /// <summary>
        /// 
        /// </summary>
        GptImage1,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateImageRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateImageRequestModel value)
        {
            return value switch
            {
                CreateImageRequestModel.DallE2 => "dall-e-2",
                CreateImageRequestModel.DallE3 => "dall-e-3",
                CreateImageRequestModel.GptImage1 => "gpt-image-1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateImageRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "dall-e-2" => CreateImageRequestModel.DallE2,
                "dall-e-3" => CreateImageRequestModel.DallE3,
                "gpt-image-1" => CreateImageRequestModel.GptImage1,
                _ => null,
            };
        }
    }
}