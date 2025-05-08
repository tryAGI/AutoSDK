//HintName: G.Models.VoiceIdsSharedEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum VoiceIdsSharedEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Alloy,
        /// <summary>
        /// 
        /// </summary>
        Ash,
        /// <summary>
        /// 
        /// </summary>
        Ballad,
        /// <summary>
        /// 
        /// </summary>
        Coral,
        /// <summary>
        /// 
        /// </summary>
        Echo,
        /// <summary>
        /// 
        /// </summary>
        Fable,
        /// <summary>
        /// 
        /// </summary>
        Onyx,
        /// <summary>
        /// 
        /// </summary>
        Nova,
        /// <summary>
        /// 
        /// </summary>
        Sage,
        /// <summary>
        /// 
        /// </summary>
        Shimmer,
        /// <summary>
        /// 
        /// </summary>
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