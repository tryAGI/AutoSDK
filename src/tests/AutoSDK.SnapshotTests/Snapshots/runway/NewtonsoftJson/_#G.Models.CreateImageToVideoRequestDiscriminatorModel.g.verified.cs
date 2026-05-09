//HintName: G.Models.CreateImageToVideoRequestDiscriminatorModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateImageToVideoRequestDiscriminatorModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gen3a_turbo")]
        Gen3aTurbo,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gen4_turbo")]
        Gen4Turbo,
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
    public static class CreateImageToVideoRequestDiscriminatorModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateImageToVideoRequestDiscriminatorModel value)
        {
            return value switch
            {
                CreateImageToVideoRequestDiscriminatorModel.Gen3aTurbo => "gen3a_turbo",
                CreateImageToVideoRequestDiscriminatorModel.Gen4Turbo => "gen4_turbo",
                CreateImageToVideoRequestDiscriminatorModel.Veo3 => "veo3",
                CreateImageToVideoRequestDiscriminatorModel.Veo31 => "veo3.1",
                CreateImageToVideoRequestDiscriminatorModel.Veo31Fast => "veo3.1_fast",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateImageToVideoRequestDiscriminatorModel? ToEnum(string value)
        {
            return value switch
            {
                "gen3a_turbo" => CreateImageToVideoRequestDiscriminatorModel.Gen3aTurbo,
                "gen4_turbo" => CreateImageToVideoRequestDiscriminatorModel.Gen4Turbo,
                "veo3" => CreateImageToVideoRequestDiscriminatorModel.Veo3,
                "veo3.1" => CreateImageToVideoRequestDiscriminatorModel.Veo31,
                "veo3.1_fast" => CreateImageToVideoRequestDiscriminatorModel.Veo31Fast,
                _ => null,
            };
        }
    }
}