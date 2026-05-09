//HintName: G.Models.ResearchEventDtoClassVariant1Variant2OutputDiscriminatorOutputType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ResearchEventDtoClassVariant1Variant2OutputDiscriminatorOutputType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="completed")]
        Completed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="failed")]
        Failed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResearchEventDtoClassVariant1Variant2OutputDiscriminatorOutputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResearchEventDtoClassVariant1Variant2OutputDiscriminatorOutputType value)
        {
            return value switch
            {
                ResearchEventDtoClassVariant1Variant2OutputDiscriminatorOutputType.Completed => "completed",
                ResearchEventDtoClassVariant1Variant2OutputDiscriminatorOutputType.Failed => "failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResearchEventDtoClassVariant1Variant2OutputDiscriminatorOutputType? ToEnum(string value)
        {
            return value switch
            {
                "completed" => ResearchEventDtoClassVariant1Variant2OutputDiscriminatorOutputType.Completed,
                "failed" => ResearchEventDtoClassVariant1Variant2OutputDiscriminatorOutputType.Failed,
                _ => null,
            };
        }
    }
}