//HintName: G.Models.CreateTextToVideoRequestDiscriminatorModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateTextToVideoRequestDiscriminatorModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="veo3")]
        Veo3,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="veo3.1")]
        Veo31,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="veo3.1_fast")]
        Veo31Fast,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTextToVideoRequestDiscriminatorModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToVideoRequestDiscriminatorModel value)
        {
            return value switch
            {
                CreateTextToVideoRequestDiscriminatorModel.Veo3 => "veo3",
                CreateTextToVideoRequestDiscriminatorModel.Veo31 => "veo3.1",
                CreateTextToVideoRequestDiscriminatorModel.Veo31Fast => "veo3.1_fast",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToVideoRequestDiscriminatorModel? ToEnum(string value)
        {
            return value switch
            {
                "veo3" => CreateTextToVideoRequestDiscriminatorModel.Veo3,
                "veo3.1" => CreateTextToVideoRequestDiscriminatorModel.Veo31,
                "veo3.1_fast" => CreateTextToVideoRequestDiscriminatorModel.Veo31Fast,
                _ => null,
            };
        }
    }
}