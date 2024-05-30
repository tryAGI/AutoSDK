//HintName: G.Models.CreateImageVariationRequestModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateImageVariationRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="dall-e-2")]
        DallE2,
    }

    public static class CreateImageVariationRequestModelExtensions
    {
        public static string ToValueString(this CreateImageVariationRequestModel value)
        {
            return value switch
            {
                CreateImageVariationRequestModel.DallE2 => "dall-e-2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static CreateImageVariationRequestModel ToEnum(string value)
        {
            return value switch
            {
                "dall-e-2" => CreateImageVariationRequestModel.DallE2,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static CreateImageVariationRequestModel ToEnum(int value)
        {
            return value switch
            {
                0 => CreateImageVariationRequestModel.DallE2,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}