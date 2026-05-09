//HintName: G.Models.CreateCharacterPerformanceRequestDiscriminatorModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateCharacterPerformanceRequestDiscriminatorModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="act_two")]
        ActTwo,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateCharacterPerformanceRequestDiscriminatorModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCharacterPerformanceRequestDiscriminatorModel value)
        {
            return value switch
            {
                CreateCharacterPerformanceRequestDiscriminatorModel.ActTwo => "act_two",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCharacterPerformanceRequestDiscriminatorModel? ToEnum(string value)
        {
            return value switch
            {
                "act_two" => CreateCharacterPerformanceRequestDiscriminatorModel.ActTwo,
                _ => null,
            };
        }
    }
}