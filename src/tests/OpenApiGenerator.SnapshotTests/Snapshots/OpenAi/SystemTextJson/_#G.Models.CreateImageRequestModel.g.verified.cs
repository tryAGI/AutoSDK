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
    }

    public static class CreateImageRequestModelExtensions
    {
        public static string ToValueString(this CreateImageRequestModel value)
        {
            return value switch
            {
                CreateImageRequestModel.DallE2 => "dall-e-2",
                CreateImageRequestModel.DallE3 => "dall-e-3",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static CreateImageRequestModel ToEnum(string value)
        {
            return value switch
            {
                "dall-e-2" => CreateImageRequestModel.DallE2,
                "dall-e-3" => CreateImageRequestModel.DallE3,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static CreateImageRequestModel ToEnum(int value)
        {
            return value switch
            {
                0 => CreateImageRequestModel.DallE2,
                1 => CreateImageRequestModel.DallE3,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}