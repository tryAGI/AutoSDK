//HintName: G.Models.EffectsInputEffectScene.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Effect scene type to apply.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EffectsInputEffectScene
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="christmas")]
        Christmas,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="dual_character")]
        DualCharacter,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="halloween")]
        Halloween,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="new_year")]
        NewYear,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="old_photo_restoration")]
        OldPhotoRestoration,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="spring_festival")]
        SpringFestival,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="thanksgiving")]
        Thanksgiving,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="valentines_day")]
        ValentinesDay,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EffectsInputEffectSceneExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EffectsInputEffectScene value)
        {
            return value switch
            {
                EffectsInputEffectScene.Christmas => "christmas",
                EffectsInputEffectScene.DualCharacter => "dual_character",
                EffectsInputEffectScene.Halloween => "halloween",
                EffectsInputEffectScene.NewYear => "new_year",
                EffectsInputEffectScene.OldPhotoRestoration => "old_photo_restoration",
                EffectsInputEffectScene.SpringFestival => "spring_festival",
                EffectsInputEffectScene.Thanksgiving => "thanksgiving",
                EffectsInputEffectScene.ValentinesDay => "valentines_day",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EffectsInputEffectScene? ToEnum(string value)
        {
            return value switch
            {
                "christmas" => EffectsInputEffectScene.Christmas,
                "dual_character" => EffectsInputEffectScene.DualCharacter,
                "halloween" => EffectsInputEffectScene.Halloween,
                "new_year" => EffectsInputEffectScene.NewYear,
                "old_photo_restoration" => EffectsInputEffectScene.OldPhotoRestoration,
                "spring_festival" => EffectsInputEffectScene.SpringFestival,
                "thanksgiving" => EffectsInputEffectScene.Thanksgiving,
                "valentines_day" => EffectsInputEffectScene.ValentinesDay,
                _ => null,
            };
        }
    }
}