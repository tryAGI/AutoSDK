//HintName: G.Models.DubbingModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DubbingModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="dubbing_e2e_v1")]
        DubbingE2eV1,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="dubbing_v2")]
        DubbingV2,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="dubbing_v3")]
        DubbingV3,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DubbingModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DubbingModel value)
        {
            return value switch
            {
                DubbingModel.DubbingE2eV1 => "dubbing_e2e_v1",
                DubbingModel.DubbingV2 => "dubbing_v2",
                DubbingModel.DubbingV3 => "dubbing_v3",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DubbingModel? ToEnum(string value)
        {
            return value switch
            {
                "dubbing_e2e_v1" => DubbingModel.DubbingE2eV1,
                "dubbing_v2" => DubbingModel.DubbingV2,
                "dubbing_v3" => DubbingModel.DubbingV3,
                _ => null,
            };
        }
    }
}