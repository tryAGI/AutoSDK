//HintName: G.Models.ListenV1ServerEventDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListenV1ServerEventDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Metadata")]
        Metadata,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Results")]
        Results,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListenV1ServerEventDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListenV1ServerEventDiscriminatorType value)
        {
            return value switch
            {
                ListenV1ServerEventDiscriminatorType.Metadata => "Metadata",
                ListenV1ServerEventDiscriminatorType.Results => "Results",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListenV1ServerEventDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "Metadata" => ListenV1ServerEventDiscriminatorType.Metadata,
                "Results" => ListenV1ServerEventDiscriminatorType.Results,
                _ => null,
            };
        }
    }
}