//HintName: G.Models.PronunciationDetailType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PronunciationDetailType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="IPA")]
        Ipa,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="SAY_AS")]
        SayAs,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PronunciationDetailTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PronunciationDetailType value)
        {
            return value switch
            {
                PronunciationDetailType.Ipa => "IPA",
                PronunciationDetailType.SayAs => "SAY_AS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PronunciationDetailType? ToEnum(string value)
        {
            return value switch
            {
                "IPA" => PronunciationDetailType.Ipa,
                "SAY_AS" => PronunciationDetailType.SayAs,
                _ => null,
            };
        }
    }
}