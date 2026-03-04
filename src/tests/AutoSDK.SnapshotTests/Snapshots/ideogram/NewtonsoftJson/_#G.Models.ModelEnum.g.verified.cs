//HintName: G.Models.ModelEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The model used to generate. Defaults to V_2.<br/>
    /// Default Value: V_2<br/>
    /// Example: V_2_TURBO
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ModelEnum
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="V_1")]
        V1,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="V_1_TURBO")]
        V1Turbo,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="V_2")]
        V2,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="V_2_TURBO")]
        V2Turbo,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelEnum value)
        {
            return value switch
            {
                ModelEnum.V1 => "V_1",
                ModelEnum.V1Turbo => "V_1_TURBO",
                ModelEnum.V2 => "V_2",
                ModelEnum.V2Turbo => "V_2_TURBO",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelEnum? ToEnum(string value)
        {
            return value switch
            {
                "V_1" => ModelEnum.V1,
                "V_1_TURBO" => ModelEnum.V1Turbo,
                "V_2" => ModelEnum.V2,
                "V_2_TURBO" => ModelEnum.V2Turbo,
                _ => null,
            };
        }
    }
}