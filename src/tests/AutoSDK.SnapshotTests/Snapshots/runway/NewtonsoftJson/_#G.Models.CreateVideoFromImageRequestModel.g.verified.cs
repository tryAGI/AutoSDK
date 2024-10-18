//HintName: G.Models.CreateVideoFromImageRequestModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The model variant to use.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateVideoFromImageRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gen3a_turbo")]
        Gen3aTurbo,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateVideoFromImageRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateVideoFromImageRequestModel value)
        {
            return value switch
            {
                CreateVideoFromImageRequestModel.Gen3aTurbo => "gen3a_turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateVideoFromImageRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "gen3a_turbo" => CreateVideoFromImageRequestModel.Gen3aTurbo,
                _ => null,
            };
        }
    }
}