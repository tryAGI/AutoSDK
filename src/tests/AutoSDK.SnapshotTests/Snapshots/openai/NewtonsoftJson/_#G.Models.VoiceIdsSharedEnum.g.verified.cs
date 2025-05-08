//HintName: G.Models.VoiceIdsSharedEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum VoiceIdsSharedEnum
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="alloy")]
        Alloy,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ash")]
        Ash,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ballad")]
        Ballad,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="coral")]
        Coral,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="echo")]
        Echo,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fable")]
        Fable,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="onyx")]
        Onyx,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="nova")]
        Nova,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="sage")]
        Sage,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="shimmer")]
        Shimmer,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="verse")]
        Verse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VoiceIdsSharedEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VoiceIdsSharedEnum value)
        {
            return value switch
            {
                VoiceIdsSharedEnum.Alloy => "alloy",
                VoiceIdsSharedEnum.Ash => "ash",
                VoiceIdsSharedEnum.Ballad => "ballad",
                VoiceIdsSharedEnum.Coral => "coral",
                VoiceIdsSharedEnum.Echo => "echo",
                VoiceIdsSharedEnum.Fable => "fable",
                VoiceIdsSharedEnum.Onyx => "onyx",
                VoiceIdsSharedEnum.Nova => "nova",
                VoiceIdsSharedEnum.Sage => "sage",
                VoiceIdsSharedEnum.Shimmer => "shimmer",
                VoiceIdsSharedEnum.Verse => "verse",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VoiceIdsSharedEnum? ToEnum(string value)
        {
            return value switch
            {
                "alloy" => VoiceIdsSharedEnum.Alloy,
                "ash" => VoiceIdsSharedEnum.Ash,
                "ballad" => VoiceIdsSharedEnum.Ballad,
                "coral" => VoiceIdsSharedEnum.Coral,
                "echo" => VoiceIdsSharedEnum.Echo,
                "fable" => VoiceIdsSharedEnum.Fable,
                "onyx" => VoiceIdsSharedEnum.Onyx,
                "nova" => VoiceIdsSharedEnum.Nova,
                "sage" => VoiceIdsSharedEnum.Sage,
                "shimmer" => VoiceIdsSharedEnum.Shimmer,
                "verse" => VoiceIdsSharedEnum.Verse,
                _ => null,
            };
        }
    }
}